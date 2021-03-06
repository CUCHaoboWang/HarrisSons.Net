using HarrisSons.Net.Data.Tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisSons.Net.WinForm
{
    static class Program
    {
        public static IConfiguration Configuration;
        public static IServiceProvider ServiceProvider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceProvider = new ServiceCollection()
                .AddDbContext<HarrisSonsDbContext>(options => options
                .UseMySql(Configuration.GetConnectionString("MySQLDbConnection"), x => x.ServerVersion("8.0.16-mysql"))).BuildServiceProvider();

            DbInitializer.Initialize();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashBoard());
        }
    }
}
