
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action DeretBilanganAction;

	private global::Gtk.Action FibonanciAction;

	private global::Gtk.Action PrimaAction;

	private global::Gtk.Action KonversiDesimalAction;

	private global::Gtk.Action BinerAction;

	private global::Gtk.Action BinerAction1;

	private global::Gtk.Action HexadesimaAction;

	private global::Gtk.Action MatriksAction;

	private global::Gtk.Action PenjumlahanAction;

	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox4;

	private global::Gtk.MenuBar menubar2;

	private global::Gtk.MenuBar menubar1;

	private global::Gtk.MenuBar menubar3;

	private global::Gtk.Label label1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.DeretBilanganAction = new global::Gtk.Action("DeretBilanganAction", global::Mono.Unix.Catalog.GetString("Deret Bilangan"), null, null);
		this.DeretBilanganAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Deret Bilangan");
		w1.Add(this.DeretBilanganAction, null);
		this.FibonanciAction = new global::Gtk.Action("FibonanciAction", global::Mono.Unix.Catalog.GetString("Fibonanci"), null, null);
		this.FibonanciAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Fibonanci");
		w1.Add(this.FibonanciAction, null);
		this.PrimaAction = new global::Gtk.Action("PrimaAction", global::Mono.Unix.Catalog.GetString("Prima"), null, null);
		this.PrimaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Prima");
		w1.Add(this.PrimaAction, null);
		this.KonversiDesimalAction = new global::Gtk.Action("KonversiDesimalAction", global::Mono.Unix.Catalog.GetString("Konversi Desimal"), null, null);
		this.KonversiDesimalAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Konversi Desimal");
		w1.Add(this.KonversiDesimalAction, null);
		this.BinerAction = new global::Gtk.Action("BinerAction", global::Mono.Unix.Catalog.GetString("Biner"), null, null);
		this.BinerAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Biner");
		w1.Add(this.BinerAction, null);
		this.BinerAction1 = new global::Gtk.Action("BinerAction1", global::Mono.Unix.Catalog.GetString("Biner"), null, null);
		this.BinerAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Biner");
		w1.Add(this.BinerAction1, null);
		this.HexadesimaAction = new global::Gtk.Action("HexadesimaAction", global::Mono.Unix.Catalog.GetString("Hexadesima"), null, null);
		this.HexadesimaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Hexadesima");
		w1.Add(this.HexadesimaAction, null);
		this.MatriksAction = new global::Gtk.Action("MatriksAction", global::Mono.Unix.Catalog.GetString("Matriks"), null, null);
		this.MatriksAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Matriks");
		w1.Add(this.MatriksAction, null);
		this.PenjumlahanAction = new global::Gtk.Action("PenjumlahanAction", global::Mono.Unix.Catalog.GetString("Penjumlahan"), null, null);
		this.PenjumlahanAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Penjumlahan");
		w1.Add(this.PenjumlahanAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar2\'><menu name=\'DeretBilanganAction\' action=\'DeretBilang" +
				"anAction\'><menuitem name=\'FibonanciAction\' action=\'FibonanciAction\'/><menuitem n" +
				"ame=\'PrimaAction\' action=\'PrimaAction\'/></menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.hbox4.Add(this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.menubar2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar1\'><menu name=\'KonversiDesimalAction\' action=\'KonversiD" +
				"esimalAction\'><menuitem name=\'BinerAction1\' action=\'BinerAction1\'/><menuitem nam" +
				"e=\'HexadesimaAction\' action=\'HexadesimaAction\'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.hbox4.Add(this.menubar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.menubar1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar3\'/></ui>");
		this.menubar3 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar3")));
		this.menubar3.Name = "menubar3";
		this.hbox4.Add(this.menubar3);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.menubar3]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox2.Add(this.hbox4);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Simpel Algoritma ");
		this.vbox2.Add(this.label1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 594;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.FibonanciAction.Activated += new global::System.EventHandler(this.onclick_fib);
		this.PrimaAction.Activated += new global::System.EventHandler(this.onclik_p);
		this.BinerAction1.Activated += new global::System.EventHandler(this.onclick_b);
		this.HexadesimaAction.Activated += new global::System.EventHandler(this.onclick_h);
		this.PenjumlahanAction.Activated += new global::System.EventHandler(this.onclick_m);
	}
}
