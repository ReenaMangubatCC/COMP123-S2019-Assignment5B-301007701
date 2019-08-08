using COMP123_S2019_Assignment5B_301007701.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5B_301007701.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
            
            
            
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }
        /// <summary>
        /// This is the event handler that will terminate the program when it is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler to move from one form to another when the buttone is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event handler to select a full row of data from the datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //creating local scope aliases
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            string selectionString = string.Empty;

            //outputting the data into a label
            selectionString = cells[2].Value.ToString() + " " + cells[3].Value.ToString() + " "+ "Priced at: $" + cells[1].Value.ToString();
            SelectionLabel.Text = selectionString;

            //display the information
            Program.computer.Manufacturer = cells[(int)ComputerField.MANUFACTURER].Value.ToString();
            Program.computer.Model = cells[(int)ComputerField.MODEL].Value.ToString();
            Program.computer.Cost = decimal.Parse(cells[(int)ComputerField.COST].Value.ToString());

            Program.computer.ProductID = int.Parse(cells[(int)ComputerField.PRODUCT_ID].Value.ToString());
            Program.computer.Condition = cells[(int)ComputerField.CONDITION].Value.ToString();
            Program.computer.Platform = cells[(int)ComputerField.PLATFORM].Value.ToString();
            Program.computer.OS = cells[(int)ComputerField.OS].Value.ToString();

            //Specs
            Program.computer.Memory = cells[(int)ComputerField.RAM_SIZE].Value.ToString();
            Program.computer.CPUBrand = cells[(int)ComputerField.CPU_BRAND].Value.ToString();
            Program.computer.CPUType = cells[(int)ComputerField.CPU_TYPE].Value.ToString();
            Program.computer.LCDType = cells[(int)ComputerField.LCD_TYPE].Value.ToString();
            Program.computer.CPUNumber = cells[(int)ComputerField.CPU_NUMBER].Value.ToString();
            Program.computer.CPUSpeed = cells[(int)ComputerField.CPU_SPEED].Value.ToString();
            Program.computer.HDDSize = cells[(int)ComputerField.HDD_SIZE].Value.ToString();
            Program.computer.GPUType = cells[(int)ComputerField.GPU_TYPE].Value.ToString();
            Program.computer.WebCam = cells[(int)ComputerField.WEBCAM].Value.ToString();


        }

    }
}
