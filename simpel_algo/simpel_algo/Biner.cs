using System;
namespace simpel_algo
{
    public partial class Biner : Gtk.Window
    {
        public Biner() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void onclick_b(object sender, EventArgs e)
        {
            int[] bil = new int[10];
            int i;
            int biner = Convert.ToInt16(entry1.Text);


            label2.Text = string.Empty;
            for(i = 0; biner > 0; i++)
            {
                bil[i] = biner % 2;
                biner = biner / 2;
            }

            for (i = i - 1; i >= 0; i--)
            {
                label2.Text += bil[i] + "";
            }
        }
    }
}
