namespace COMP123_S2019_Assignment5B_301007701.Views
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dollarComputersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dollarComputersDataSet = new COMP123_S2019_Assignment5B_301007701.DollarComputersDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new COMP123_S2019_Assignment5B_301007701.DollarComputersDataSetTableAdapters.productsTableAdapter();
            this.ComputerSelectionLabel = new System.Windows.Forms.Label();
            this.CustomerPickLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.AllowUserToResizeColumns = false;
            this.ProductDataGridView.AllowUserToResizeRows = false;
            this.ProductDataGridView.AutoGenerateColumns = false;
            this.ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ProductDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.DataSource = this.dollarComputersDataSetBindingSource;
            this.ProductDataGridView.Location = new System.Drawing.Point(12, 59);
            this.ProductDataGridView.MultiSelect = false;
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowTemplate.Height = 24;
            this.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGridView.Size = new System.Drawing.Size(776, 335);
            this.ProductDataGridView.TabIndex = 0;
            // 
            // dollarComputersDataSetBindingSource
            // 
            this.dollarComputersDataSetBindingSource.DataSource = this.dollarComputersDataSet;
            this.dollarComputersDataSetBindingSource.Position = 0;
            // 
            // dollarComputersDataSet
            // 
            this.dollarComputersDataSet.DataSetName = "DollarComputersDataSet";
            this.dollarComputersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.dollarComputersDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // ComputerSelectionLabel
            // 
            this.ComputerSelectionLabel.AutoEllipsis = true;
            this.ComputerSelectionLabel.AutoSize = true;
            this.ComputerSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerSelectionLabel.Location = new System.Drawing.Point(12, 12);
            this.ComputerSelectionLabel.Name = "ComputerSelectionLabel";
            this.ComputerSelectionLabel.Size = new System.Drawing.Size(269, 29);
            this.ComputerSelectionLabel.TabIndex = 1;
            this.ComputerSelectionLabel.Text = "Computer Selection List";
            // 
            // CustomerPickLabel
            // 
            this.CustomerPickLabel.AutoSize = true;
            this.CustomerPickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPickLabel.Location = new System.Drawing.Point(19, 424);
            this.CustomerPickLabel.Name = "CustomerPickLabel";
            this.CustomerPickLabel.Size = new System.Drawing.Size(140, 29);
            this.CustomerPickLabel.TabIndex = 2;
            this.CustomerPickLabel.Text = "You picked:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(165, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 34);
            this.textBox1.TabIndex = 3;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(671, 485);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(117, 43);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(528, 485);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(126, 43);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomerPickLabel);
            this.Controls.Add(this.ComputerSelectionLabel);
            this.Controls.Add(this.ProductDataGridView);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDataGridView;
        private DollarComputersDataSet dollarComputersDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DollarComputersDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource dollarComputersDataSetBindingSource;
        private System.Windows.Forms.Label ComputerSelectionLabel;
        private System.Windows.Forms.Label CustomerPickLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

