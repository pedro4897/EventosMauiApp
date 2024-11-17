 namespace EventosMauiApp.Models
{
    public class Dados
    {
        public Nome NomeSelecionado { get; set; }

        public double Custo { get; set; }

        public int QntParticipante { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime Datafim { get; set; }

        public Local LocalSelecionado { get; set; }

        public int  Duracao 
        {
            get => Datafim.Subtract(DataInicio).Days;
            
        }
        



        public double ValorTotal
        {
            get
            {
                double valor_participantes = QntParticipante * Custo;
                double total = valor_participantes;

                return total;
            }
        }
            
            
    }

    }

