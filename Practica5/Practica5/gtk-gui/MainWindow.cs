
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Button Convertir;
	private global::Gtk.Button Limpiar;
	private global::Gtk.Button Salir;
	private global::Gtk.Entry PesosText;
	private global::Gtk.Entry CambioText;
	private global::Gtk.Entry DolatesText;
	private global::Gtk.Label label1;
	private global::Gtk.Label label2;
	private global::Gtk.Label label3;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Convertir = new global::Gtk.Button ();
		this.Convertir.WidthRequest = 100;
		this.Convertir.CanFocus = true;
		this.Convertir.Name = "Convertir";
		this.Convertir.UseUnderline = true;
		this.Convertir.Label = global::Mono.Unix.Catalog.GetString ("Convertir");
		this.fixed1.Add (this.Convertir);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Convertir]));
		w1.X = 250;
		w1.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Limpiar = new global::Gtk.Button ();
		this.Limpiar.WidthRequest = 100;
		this.Limpiar.CanFocus = true;
		this.Limpiar.Name = "Limpiar";
		this.Limpiar.UseUnderline = true;
		this.Limpiar.Label = global::Mono.Unix.Catalog.GetString ("Limpiar");
		this.fixed1.Add (this.Limpiar);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Limpiar]));
		w2.X = 250;
		w2.Y = 140;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Salir = new global::Gtk.Button ();
		this.Salir.WidthRequest = 100;
		this.Salir.CanFocus = true;
		this.Salir.Name = "Salir";
		this.Salir.UseUnderline = true;
		this.Salir.Xalign = 0.57F;
		this.Salir.Label = global::Mono.Unix.Catalog.GetString ("Salir");
		this.fixed1.Add (this.Salir);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Salir]));
		w3.X = 250;
		w3.Y = 178;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.PesosText = new global::Gtk.Entry ();
		this.PesosText.CanFocus = true;
		this.PesosText.Name = "PesosText";
		this.PesosText.IsEditable = true;
		this.PesosText.InvisibleChar = '●';
		this.fixed1.Add (this.PesosText);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.PesosText]));
		w4.X = 70;
		w4.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.CambioText = new global::Gtk.Entry ();
		this.CambioText.CanFocus = true;
		this.CambioText.Name = "CambioText";
		this.CambioText.IsEditable = true;
		this.CambioText.InvisibleChar = '●';
		this.fixed1.Add (this.CambioText);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.CambioText]));
		w5.X = 70;
		w5.Y = 150;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.DolatesText = new global::Gtk.Entry ();
		this.DolatesText.CanFocus = true;
		this.DolatesText.Name = "DolatesText";
		this.DolatesText.IsEditable = false;
		this.DolatesText.InvisibleChar = '●';
		this.fixed1.Add (this.DolatesText);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.DolatesText]));
		w6.X = 70;
		w6.Y = 200;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Pesos");
		this.fixed1.Add (this.label1);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
		w7.X = 80;
		w7.Y = 85;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Dolares");
		this.fixed1.Add (this.label2);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
		w8.X = 80;
		w8.Y = 184;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Tipo de cambio");
		this.fixed1.Add (this.label3);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label3]));
		w9.X = 80;
		w9.Y = 130;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 362;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.Convertir.Clicked += new global::System.EventHandler (this.OnConvertirClicked);
		this.Limpiar.Clicked += new global::System.EventHandler (this.OnLimpiarClicked);
		this.Salir.Clicked += new global::System.EventHandler (this.OnSalirClicked);
	}
}
