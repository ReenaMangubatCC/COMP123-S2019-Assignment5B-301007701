﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
 * DESCRIPTION: This is the Start Form and it allows the user to create a new order or load a previous one made.
 **/
namespace COMP123_S2019_Assignment5B_301007701.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the Exit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for the NewOrder button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }
        
        /// <summary>
        /// This is the event handler for the LoadOrderButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadOrderButton_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            LoadComputerOpenFileDialog.FileName = "Product.txt";
            LoadComputerOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            LoadComputerOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the save file dialog
            var result = LoadComputerOpenFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                try
                {
                    //open file stream and read it
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(LoadComputerOpenFileDialog.FileName, FileMode.Open)))
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

                    }
                    Program.productInfoForm.Show();
                    this.Hide();
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR" + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}

