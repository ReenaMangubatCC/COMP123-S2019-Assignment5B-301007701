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
        public static SplashForm splashForm;
        public static SelectForm selectForm;
        public static ConditionLabel orderForm;
        public static StartForm startForm;
        public static ProductInfoForm productInfoForm;

        public static Computer computer;
 
        


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            product = new product();
            productInfoForm = new ProductInfoForm();
            orderForm = new ConditionLabel();

            computer = new Computer();
            



            Application.Run(splashForm);
        }
    }
}
