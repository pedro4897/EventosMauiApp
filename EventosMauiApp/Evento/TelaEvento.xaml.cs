using EventosMauiApp.Models;

namespace EventosMauiApp.Evento;

public partial class TelaEvento : ContentPage
{
	App PropriedadesApp;
	public TelaEvento()
	{
		InitializeComponent();
		PropriedadesApp = (App)Application.Current;
        pck_nome.ItemsSource = PropriedadesApp.lista_nomes;
        pck_local.ItemsSource = PropriedadesApp.lista_locais;
        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_fim.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_fim.MaximumDate = dtpck_inicio.Date.AddMonths(6);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Dados d = new Dados
            {
                NomeSelecionado = (Nome)pck_nome.SelectedItem,
                DataInicio = dtpck_inicio.Date,
                Datafim = dtpck_fim.Date,
                QntParticipante = Convert.ToInt32(stp_numero.Value),
                LocalSelecionado = (Local)pck_local.SelectedItem,
                Custo = Convert.ToDouble(stp_custo.Value),
               

            };


            await Navigation.PushAsync(new DadosEvento()
            {
                BindingContext = d
            });








        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;
        

        dtpck_fim.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_fim.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}