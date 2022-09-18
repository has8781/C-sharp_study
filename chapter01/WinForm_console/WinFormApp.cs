using System;
using System.Windows.Forms;
class WinFormApp : Form
{
    WinFormApp()
    {
        Text = "Hello World!";
    }
    public static void Main()
    {
        Application.Run(new WinFormApp());
    }
}
