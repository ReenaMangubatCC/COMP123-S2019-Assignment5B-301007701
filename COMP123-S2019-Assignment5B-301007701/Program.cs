using COMP123_S2019_Assignment5B_301007701.Data;
using COMP123_S2019_Assignment5B_301007701.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5B_301007701
{
    public static class Program
    {
        public static product product;
        public static SelectForm selectForm;
        public static OrderForm orderForm;
        public static StartForm startForm;
        public static ProductInfoForm productInforForm;
        public static SplashForm splashForm;
        public static AboutForm aboutForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            selectForm = new SelectForm();
            product = new product();
            orderForm = new OrderForm();
            startForm = new StartForm();
            productInforForm = new ProductInfoForm();
            splashForm = new SplashForm();
            aboutForm = new AboutForm();


            Application.Run(new SelectForm());
        }
    }
}
