using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// This is the event handler that allows the user to move onto the next form by a click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();

        }
        /// <summary>
        /// This is the even handler that allows for the user to switch back and forth between forms to select a new item with a click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            SetCorrectData();

        }

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
            WebCamResultLabel.Text = Program.computer.WebCam.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
         
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
