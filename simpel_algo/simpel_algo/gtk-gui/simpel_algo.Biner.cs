
// This file has been generated by the GUI designer. Do not modify.
namespace simpel_algo
{
	public partial class Biner
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Label label1;

		private global::Gtk.Entry entry1;

		private global::Gtk.Button button1;

		private global::Gtk.Label label2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget simpel_algo.Biner
			this.Name = "simpel_algo.Biner";
			this.Title = global::Mono.Unix.Catalog.GetString("Biner");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child simpel_algo.Biner.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Masukan Desimal");
			this.fixed1.Add(this.label1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
			w1.X = 37;
			w1.Y = 45;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.fixed1.Add(this.entry1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry1]));
			w2.X = 172;
			w2.Y = 40;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Proses");
			this.fixed1.Add(this.button1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
			w3.X = 138;
			w3.Y = 96;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.fixed1.Add(this.label2);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
			w4.X = 144;
			w4.Y = 170;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.button1.Clicked += new global::System.EventHandler(this.onclick_b);
		}
	}
}
