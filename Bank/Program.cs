using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using NLog.Config; 

namespace Bank
{
    static class Program
    {
        
        //log
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* Logger logger = LogManager.GetCurrentClassLogger();
            logger.Trace("Привет{0}", "!"); 
            logger.DebugException("Произошла ошибка", new ArgumentNullException());
            logger.Fatal("Пока");*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            logger.Trace("logger.Trace");
            logger.Debug("logger.Debug");
            logger.Info("logger.Info");
            logger.Warn("logger.Warn");
            logger.Error("logger.Error");
            logger.Fatal("logger.Fatal");
        }
    }
}
