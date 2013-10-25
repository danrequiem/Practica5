using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnConvertirClicked (object sender, EventArgs e)
	{

		double pesos,cambio;

		bool conversionPesos =Double.TryParse(PesosText.Text, out pesos);
		bool conversionCambio =Double.TryParse(CambioText.Text, out cambio);

		if( !conversionPesos || !conversionCambio || pesos == 0 || cambio == 0){

			MessageDialog Mensaje = new MessageDialog(
										
									null,
									DialogFlags.Modal,
									MessageType.Warning,
									ButtonsType.None,
									"Error"
				);
			Mensaje.Show();

		}
		else{

			double cambiado = pesos / cambio;
			DolatesText.Text = cambiado.ToString();

		} 

	}

	protected void OnLimpiarClicked (object sender, EventArgs e)
	{
		PesosText.Text = "";
		CambioText.Text = "";
	}

	protected void OnSalirClicked (object sender, EventArgs e)
	{
		Application.Quit ();
	}
}
