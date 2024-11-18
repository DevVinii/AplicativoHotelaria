namespace AplicativoHotel_correto_.Resources.View;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();
    }
    public void Button_Clicked(object sender, EventArgs e){
        try 
        {
            Navigation.PushAsync( new ContratacaoDeHospedagem());
        }
        catch (Exception ex) {
            DisplayAlert("Ops", ex.Message, "OK");
        }
       
    }
}