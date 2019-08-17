namespace ITE.Entidades.Enumeradores.ContabilEnums
{
    public enum TypeStatusLoteContabil
    {
        //Ainda em digitacao pelo usuário.
        EmEdicao = 0,
        //quando o lote ja foi integrado à contabilidade oficial (Lote 0)
        //Bloqueada qualquer alteração.
        Liberado = 1 
    }
}
