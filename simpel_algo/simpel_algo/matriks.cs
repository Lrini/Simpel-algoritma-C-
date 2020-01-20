using System;
namespace simpel_algo
{
    public partial class matriks : Gtk.Window
    {
        public matriks() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void onclick_m(object sender, EventArgs e)
        {
            int baris = Convert.ToInt16(entry1.Text);
            int kolom = Convert.ToInt16(entry2.Text);

            int[,] matriks_a = new int[baris, kolom];
            int[,] matriks_b = new int[baris, kolom];

            for(int i = 0; i <baris; i++)
            {
                for(int j = 0; j <kolom; j++)
                {
                    label3.Text += matriks_a[i, j];
                }
            }

        }
    }
}
