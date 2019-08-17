using ITE.Entidades.UnitControl;


// Abstract Factory
 
namespace ITE.Forms.Menus
{
    /// <summary>
    /// Todos os tratamento verificações serão implementas aqui
    /// </summary>
    public class MenuController
    {
        //Objeto compartilhado
        private XFrmMenu _menu;

        public VendaMenuController VendasController { get;  }
        public FinanceiroMenuController FinanceiroController { get;  }
        public AdministrativoMenuController AdministrativoController { get;  }
        public SistemaMenuController SistemaController { get;  }
        public ReportMenuController ReportController { get;  }
        public CadastroMenuController CadastroController { get;  }
        public InformaticaMenuController InformaticaController { get; }

        public CEController CEController { get; }
        public DemonstrativoController DemonstrativoController { get; }
        
        public UnitWork UserControl { get;  }

        private static MenuController instance;

        public static MenuController controller(XFrmMenu menu)
        {
            if (instance == null)
                instance = new MenuController(menu);

            return instance;
        }

        private MenuController(XFrmMenu menu)
        {
            this._menu = menu;
            this.UserControl = new UnitWork();

            //Evita duplicação de form no MDI dentro do Menu principal
            
            //Seção Critica
            this.VendasController = new VendaMenuController(menu);
            this.FinanceiroController = new FinanceiroMenuController(menu);
            this.SistemaController = new SistemaMenuController(menu);
            this.ReportController = new ReportMenuController(menu);
            this.CadastroController = new CadastroMenuController(menu);
            this.InformaticaController = new InformaticaMenuController(menu);
            this.AdministrativoController = new AdministrativoMenuController(menu);

            //Evita duplicação de form no MDI dentro do Menu principal
            //Objeto compartilhado
            //Seção Critica
            this.CEController = new CEController(menu);
            this.DemonstrativoController = new DemonstrativoController(menu);
        }
    }
}
