using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void onclick_fib(object sender, EventArgs e)
    {
        simpel_algo.fibonanci frd = new simpel_algo.fibonanci();
        frd.Show();
    }

    protected void onclik_p(object sender, EventArgs e)
    {
        simpel_algo.Prima frh = new simpel_algo.Prima();
        frh.Show();
    }

    protected void onclick_b(object sender, EventArgs e)
    {
        simpel_algo.Biner frk = new simpel_algo.Biner();
        frk.Show();
    }

    protected void onclick_h(object sender, EventArgs e)
    {
        simpel_algo.hexadecimal frt = new simpel_algo.hexadecimal();
        frt.Show();
    }

    protected void onclick_m(object sender, EventArgs e)
    {
        simpel_algo.matriks frm = new simpel_algo.matriks();
        frm.Show();
    }
       
}
