using System;
using System.Collections;
using System.Collections.Generic;
namespace simpel_algo
{
    public partial class fibonanci : Gtk.Window
    {
        public fibonanci() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void click(object sender, EventArgs e)
        {
            int a,b,cis;
            a = Convert.ToInt16(entry1.Text);
            b = Convert.ToInt16(entry2.Text);
            cis = Convert.ToInt16(entry3.Text);

            int[] bil = new int[cis];
            label5.Text = string.Empty;

           for(int i = 0; i < bil.Length; i++)
            {
                if( i == 0)
                {
                    bil[i] = a;
                    label5.Text += bil[i] + ",";
                }else if (i == 1)
                {
                    bil[i] = b;
                    label5.Text += bil[i] + ",";
                    }
                else
                {
                    bil[i] = bil[i - 1] + bil[i - 2];
                    label5.Text += bil[i] + ",";
                }

            }
        }
    }
}
