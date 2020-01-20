using System;
namespace simpel_algo
{
    public partial class hexadecimal : Gtk.Window
    {
        public hexadecimal() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void onclick_h(object sender, EventArgs e)
        {
            int[] bil = new int[10];
            int i;
            char tempt;

            int desimal = Convert.ToInt16(entry2.Text);

            for(i = 0; desimal >0; i++)
            {
                bil[i] = desimal % 16;
                desimal = desimal / 16;
            }

            for(i = i -1; i >= 0; i--)
            {
                if(bil[i] == 10)
                {
                    tempt = Convert.ToChar(bil[i]);
                    label4.Text += "A";
                } else if(bil[i] == 11)
                {
                    tempt = Convert.ToChar(bil[i]);
                    label4.Text += "B";
                }else if(bil[i] == 12)
                {
                    tempt = Convert.ToChar(bil[i]);
                    label4.Text += "C";
                }else if(bil[i] == 13)
                {
                    tempt = Convert.ToChar(bil[i]);
                    label4.Text += "D";
                }else if(bil[i] == 14)
                {
                    tempt = Convert.ToChar(bil[i]);
                    label4.Text += "E";
                }else if(bil[i] == 15)
                {
                    tempt = Convert.ToChar(bil[i]);
                    label4.Text += "F";
                }
                else
                {
                    label4.Text += bil[i];
                }
            }
        }
    }
}
