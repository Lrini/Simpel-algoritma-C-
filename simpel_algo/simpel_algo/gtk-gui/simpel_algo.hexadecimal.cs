
// This file has been generated by the GUI designer. Do not modify.
namespace simpel_algo
{
	public partial class hexadecimal
	{
		private global::Gtk.Fixed fixed2;

		private global::Gtk.Label label3;

		private global::Gtk.Entry entry2;

		private global::Gtk.Button button2;

		private global::Gtk.Label label4;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget simpel_algo.hexadecimal
			this.Name = "simpel_algo.hexadecimal";
			this.Title = global::Mono.Unix.Catalog.GetString("hexadecimal");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child simpel_algo.hexadecimal.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Masukan Angka Desimal");
			this.fixed2.Add(this.label3);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label3]));
			w1.X = 27;
			w1.Y = 68;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.entry2 = new global::Gtk.Entry();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.InvisibleChar = '•';
			this.fixed2.Add(this.entry2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.entry2]));
			w2.X = 204;
			w2.Y = 57;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("Proses");
			this.fixed2.Add(this.button2);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button2]));
			w3.X = 139;
			w3.Y = 101;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.fixed2.Add(this.label4);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label4]));
			w4.X = 133;
			w4.Y = 173;
			this.Add(this.fixed2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.button2.Clicked += new global::System.EventHandler(this.onclick_h);
		}
	}
}
