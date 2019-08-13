using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * APP NAME: Dollar Computers
 * AUTHOR NAME: Reena Mangubat
 * STUDENT ID: 301007701
 * APP CREATION DATE: July 31, 2019
 * DESCRIPTION: This is the ProductInfo Form which shows the user the details of their computer selection.
 **/
namespace COMP123_S2019_Assignment5B_301007701.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }


        private void SelectAnotherItemButton_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This is the event handler for the Next button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();

        }
        /// <summary>
        /// This is the event handler for the selectAnotherProduct menu item click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();


        }

        /// <summary>
        /// This method will take the data from the row that was selected and put them in the appropriate places
        /// </summary>
        private void SetCorrectData()
        {

            ProductIDResultLabel.Text = Program.computer.ProductID.ToString();
            ConditionResultLabel.Text = Program.computer.Condition.ToString();
            CostResultLabel.Text = Program.computer.Cost.ToString();

            //Product Details
            PlatformResultLabel.Text = Program.computer.Platform.ToString();
            ManufacturedResultLabel.Text = Program.computer.Manufacturer.ToString();
            OSResultLabel.Text = Program.computer.OS.ToString();
            ModelResultLabel.Text = Program.computer.Model.ToString();

            //Specs
            MemoryResultLabel.Text = Program.computer.Memory.ToString();
            CPUBrandResultLabel.Text = Program.computer.CPUBrand.ToString();
            CPUTypeResultLabel.Text = Program.computer.CPUType.ToString();
            LCDTypeResultLabel.Text = Program.computer.LCDType.ToString();
            CPUNumberResultLabel.Text = Program.computer.CPUNumber.ToString();
            CPUSpeedResultLabel.Text = Program.computer.CPUSpeed.ToString();
            HDDResultLabel.Text = Program.computer.HDDSize.ToString();
            GPUTypeResultLabel.Text = Program.computer.GPUType.ToString();
            WebCamResultLabel.Text = Program.computer.AudioType.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
         
        }

        /// <summary>
        /// This is the event handler for the exitToolStrip menu item click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for the saveToolStrip menu item click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open a stream to write to
            using (StreamWriter outputString = new StreamWriter(
                File.Open("Product.txt", FileMode.Create)))
            {
                //writing to the file
                outputString.WriteLine(Program.computer.ProductID);
                outputString.WriteLine(Program.computer.Cost);
                outputString.WriteLine(Program.computer.Manufacturer);
                outputString.WriteLine(Program.computer.Model);
                outputString.WriteLine(Program.computer.Memory);
                outputString.WriteLine(Program.computer.LCDType);
                outputString.WriteLine(Program.computer.CPUBrand);
                outputString.WriteLine(Program.computer.CPUType);
                outputString.WriteLine(Program.computer.CPUSpeed);
                outputString.WriteLine(Program.computer.CPUNumber);
                outputString.WriteLine(Program.computer.Condition);
                outputString.WriteLine(Program.computer.OS);
                outputString.WriteLine(Program.computer.Platform);
                outputString.WriteLine(Program.computer.HDDSize);
                outputString.WriteLine(Program.computer.GPUType);
                outputString.WriteLine(Program.computer.AudioType);

                //cleanup
                outputString.Close();
                outputString.Dispose();

            }

        }

        /// <summary>
        /// This is the event handler for the ProductInfoForm activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            SetCorrectData();

        }
    }
}
