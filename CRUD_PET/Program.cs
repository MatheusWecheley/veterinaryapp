using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_PET.Models;
using CRUD_PET.Presenters;
using CRUD_PET.Repositories;
using CRUD_PET.Views;
using System.Configuration;

namespace CRUD_PET
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
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
