using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5B_301007701.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selection is printing...", "Printing complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            //open file stream and read it
            using (StreamReader inputStream = new StreamReader(
                File.Open("Product.txt", FileMode.Open)))
            { 
                //read things from the file
                Program.computer.ProductID = int.Parse(inputStream.ReadLine());
                Program.computer.Cost = decimal.Parse(inputStream.ReadLine());
                Program.computer.Manufacturer = inputStream.ReadLine();
                Program.computer.Model = inputStream.ReadLine();
                Program.computer.Memory = inputStream.ReadLine();
                Program.computer.LCDType = inputStream.ReadLine();
                Program.computer.CPUBrand = inputStream.ReadLine();
                Program.computer.CPUType = inputStream.ReadLine();
                Program.computer.CPUSpeed = inputStream.ReadLine();
                Program.computer.CPUNumber = inputStream.ReadLine();
                Program.computer.Condition = inputStream.ReadLine();
                Program.computer.OS = inputStream.ReadLine();
                Program.computer.Platform = inputStream.ReadLine();
                Program.computer.HDDSize = inputStream.ReadLine();
                Program.computer.GPUType = inputStream.ReadLine();
                Program.computer.AudioType = inputStream.ReadLine();

                //cleanup
                inputStream.Close();
                inputStream.Dispose();

                PriceDataLabel.Text = Program.computer.Cost.ToString();
                ManufacturerDataLabel.Text = Program.computer.Manufacturer.ToString();
                ModelDataLabel.Text = Program.computer.Model.ToString();
                MemoryDataLabel.Text = Program.computer.Memory.ToString();
                LCDDataLabel.Text = Program.computer.LCDType.ToString();
                CPUBrandDataLabel.Text = Program.computer.CPUBrand.ToString();
                CPUTypeDataLabel.Text = Program.computer.CPUType.ToString();
                CPUSpeedDataLabel.Text = Program.computer.CPUSpeed.ToString();
                CPUNumberDataLabel.Text = Program.computer.CPUNumber.ToString();
                ConditionDataLabel.Text = Program.computer.Condition.ToString();
                OSDataLabel.Text = Program.computer.OS.ToString();
                PlatformDataLabel.Text = Program.computer.Platform.ToString();
                HDDDataLabel.Text = Program.computer.HDDSize.ToString();
                GPUTypeDataLabel.Text = Program.computer.GPUType.ToString();
                AudioTypeDataLabel.Text = Program.computer.AudioType.ToString();

            }
        }
    }
}
;
                