using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TikTacToy.Presenters;
using TikTacToy.View;

namespace TikTacToy
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
            Registration form1 = new Registration();
            RegistarationPresenter presenter = new RegistarationPresenter(form1);
            Application.Run(form1);


        } }



            
}