using EventosMauiApp.Models;

namespace EventosMauiApp
{
    public partial class App : Application
    {
        public List<Nome> lista_nomes = new List<Nome>
        {
            new Nome()
            {
                Evento = "Casamento"
            },
            new Nome()
            {
                Evento = "Festa Fantasia"
            },
            new Nome()
            {
                Evento = "Festa"
            }
        };
        public List<Local> lista_locais = new List<Local>
        {
            new Local()
            {
                Lugar = "São Paulo"
            },
            new Local()
            {
                Lugar = "Atibaia"
            },
            new Local()
            {
                Lugar = "Campinas"
            }

            
               
                
        };
        



        
            
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Evento.TelaEvento());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
