using System;
namespace simpel_algo
{
    public partial class Prima : Gtk.Window
    {
        public Prima() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void Onclik(object sender, EventArgs e)
        {
            int tempt = 0;

            int a = Convert.ToInt16(entry1.Text);
            int[] bil = new int[a];
           label2.Text = string.Empty;

            for (int i = 1; i < bil.Length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        tempt += 1;
                    }
                }
                if (tempt == 2)
                {
                    label2.Text += i + ",";
                }
                tempt = 0;
            }

        }
    }
}
