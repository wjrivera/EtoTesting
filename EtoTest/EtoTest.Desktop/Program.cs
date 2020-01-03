using System;
using Eto.Forms;
using Eto.Drawing;
using EtoOtherForm;

namespace EtoTest.Desktop
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new Application(Eto.Platform.Detect).Run(new MainOtherForm());
        }
    }
}