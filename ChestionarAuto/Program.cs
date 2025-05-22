using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChestionarAuto
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            View view = new View(form);
            IModel model = new Model();
            Presenter presenter = new Presenter(model, view);
            view.LoadLoginControl();
            view.SetPresenter(presenter);

            Application.Run(form);
        }
    }
}
