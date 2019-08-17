using System;
using System.Linq;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Entidades.DaoManager
{
    public class UsuarioDaoManager
    {
        /// <summary>
        /// Verifica se o usuário informado é um gerente ou administrador
        /// </summary>
        /// <param name="login"></param>
        /// Logon do usuário
        /// <returns></returns>true gerente caso contrário false
        public bool IsSuperUser(Usuario login)
        {
            if (login == null) return false;

            var user = FindUserByNameOrId(login);

            var grupo = user != null ? user.GrupoUsuario.NomeGrupoUsuario : "";

            return grupo == "Gerente" || grupo == "Administrador";
        }

        /// <summary>
        /// Verifica se o usuário informado é um gerente ou administrador
        /// </summary>
        /// <param name="logon"></param>Logon do usuário
        /// <returns></returns>true gerente caso contrário false
        public bool IsSuperUser(string logon)
        {
            if (logon == null) return false;
            var user = FindUserByNameOrId(logon);

            var grupo = user != null ? user.GrupoUsuario.NomeGrupoUsuario : "";

            return grupo == "Gerente" || grupo == "Administrador";
        }

        public Usuario GetSuperUser(string logon)
        {
            if (logon == null) return null;
            var user = FindUserByNameOrId(logon);

            var grupo = user != null ? user.GrupoUsuario.NomeGrupoUsuario : "";

            if (grupo == "Gerente" || grupo == "Administrador")
                return user;
            return null;
        }

        /// <summary>
        /// Verifica se o usuário informado é um gerente ou administrador
        /// </summary>
        /// <param name="logon"></param>Logon do usuário
        /// <returns></returns>trueadministrador caso contrário false
        public bool IsAdm(string logon)
        {
            var user = FindUserByNameOrId(logon);

            return user != null && user.GrupoUsuario.NomeGrupoUsuario == "Administrador";
        }

        /// <summary>
        /// Verificase se o usuário informado é um gerente
        /// </summary>
        /// <param name="logon"></param>
        /// <returns></returns>usuário existe caso contrário null
        public bool IsGerente(string logon)
        {
            var user = FindUserByNameOrId(logon);

            return user != null && user.GrupoUsuario.NomeGrupoUsuario == "Gerente";
        }

        public Usuario IsLogin(string logon, string senha)
        {
            Usuario user = null;

            try
            {
                //codifica a senha pois ela foi criptografa no banco
                //entao nao sabemos qual é a verdadeira senha
                var result = ASCIIEncodingIts.Coded(senha);
          
                using (var ctx = new BalcaoContext())
                {
                    if (logon.IsContainsLetters())

                    {
                        //busca o User com a senha codificada
                        user = ctx.UsuarioDao
                            .Where(u => u.NomeUtilizador == logon && u.Senha == result).First();
                    }
                    else
                    {
                        //tente pelo ID
                        var id = ParseUtil.ToInt(logon);
                        user = ctx.UsuarioDao
                            .Where(u => u.IdUsuario == id && u.Senha == result).First();
                    }
                    //pega ele
                    return user;
                }
            }

            // Exceptions:
            //   T:System.ArgumentNullException:
            //     source is null.
            //
            //   T:System.InvalidOperationException:
            //     The source sequence is empty.
            catch (ArgumentNullException ex)
            {
                LoggerUtilIts.GenerateLogs(ex);
            }
            catch (InvalidOperationException ex)
            {
                LoggerUtilIts.GenerateLogs(ex);
            }
            catch (System.Reflection.TargetInvocationException ex)
            {
                LoggerUtilIts.GenerateLogs(ex);
                XMessageIts.ExceptionMessage(ex);
            }
            catch (Exception ex)
            {
                LoggerUtilIts.GenerateLogs(ex);
                XMessageIts.ExceptionMessage(ex);
            }
            return user;
        }

        /// <summary>
        /// Localiza o usuario pelo nome do utilizador ou pelo ID
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Usuario FindUserByNameOrId(Usuario user)
        {
            if (user.IdUsuario == 0)
                return FindUserByNameOrId(user.NomeUtilizador);
            else
                return FindUserByNameOrId("" + user.IdUsuario);
        }

        public Usuario FindUserByNameOrId(string logon)
        {
            Usuario usuario = null;

            if (string.IsNullOrWhiteSpace(logon) == false)
            {
                try
                {
                    using (var ctx = new BalcaoContext())
                    {

                        if (logon.IsContainsLetters())
                        {
                            usuario = ctx.Usuarios.First(u => u.NomeUtilizador.Equals(logon));

                        }
                        else
                        {
                            int id = ParseUtil.ToInt(logon);
                            usuario = ctx.Usuarios.First(u => u.IdUsuario == id);

                        }
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Usuario nao encontrado => " + ex.Message);
                    return null;
                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionLogs(ex);
                    return null;

                }

            }
            return usuario;
        }

        public void SaveSkin(Usuario user, string skin)
        {
            using (var ctx = new BalcaoContext())
            {
                {
                    try
                    {
                        //padrão eh PT-BR
                        var r = ctx.SkinDevExpressDao.First(s => s.SkinNamePtBr == skin);
                        //use o nome orginal do skin
                        skin = r.SkinName;
                    }
                    catch {
                        //Console.WriteLine("Skin em pt-br nao encontrado => procurando em en-us");
                        Console.WriteLine("Skin em pt-br nao encontrado !");
                        Console.WriteLine("Usando skin setado pela inteface: " + skin);
                         try
                        {
                            var r = ctx.SkinDevExpressDao.First(s => s.SkinName == skin);
                            //use o nome orginal do skin
                            skin = r.SkinName;
                        }
                        catch  
                        {
                            Console.WriteLine("Skin em en-us nao encontrado !");
                            Console.WriteLine("Usando skin setado pela inteface: " + skin);
                        }
                    }


                    var u = ctx.UsuarioDao.Find(user.IdUsuario);
                    u.Skin = skin;

                    //a senha continua mesma mas preciso confirmar 
                    //para que a alteração seja efetivada e a senha continue criptografada
                    u.ConfirmarSenha = u.Senha;
                    //efetiva a alteração no banco
                    ctx.UsuarioDao.Update(u);
                }
            }
        }

        private bool save(Usuario novo, BalcaoContext ctx)
        {
            //persiste o objeto
            if (ctx.UsuarioDao.Save(novo))
            {
                XMessageIts.Mensagem("Usuário cadastrado com sucesso!");
                return true;
            }
            return false;
        }

        private bool update(Usuario novo, BalcaoContext ctx)
        {
            //passe o objeto pro contexto
            var current = ctx.UsuarioDao.Find(novo.IdUsuario);

            //atualiza o objeto encontrado com os dados do form
            current.Update(novo);

            if (ctx.UsuarioDao.Update(current))
            {
                XMessageIts.Mensagem("Alteração efetivada com sucesso.");
                return true;
            }
            return false;
        }

        public bool SaveUpdate(Usuario novo)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    Usuario result = ctx.UsuarioDao
                                .First(f => f.NomeUtilizador == novo.NomeUtilizador);

                    //se encontrei um forma de pagamento 
                    //que nao eh a igual a que foi informada
                    if (result.IdUsuario != novo.IdUsuario)
                    {
                        XMessageIts.Advertencia("Nome de acesso \""
                            + result.NomeUtilizador + "\" não está disponível!", "Alerta");
                        return false;

                    }
                    else
                    {
                        //a pk eh zero entao vou salvar
                        return update(novo, ctx);
                    }
                }
                catch (Exception)
                {
                    //nao achei a forma de pagamento entao vai pelo nome
                    return save(novo, ctx);
                }
            }
        }

        public void ApplyMD5Passwords()
        {
            using (var ctx = new BalcaoContext())
            {
                var lista = ctx.UsuarioDao.FindAll();

                foreach (var item in lista)
                {
                    //codifica
                    item.Senha = MD5Its.Hasher.Hash(item.Senha);
                    ctx.UsuarioDao.Update(item);
                }
            }
        }
    }
}
