namespace COMP123_S2019_Assignment5B_301007701.Views
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.LoadOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.Location = new System.Drawing.Point(230, 324);
            this.NewOrderButton.Margin = new System.Windows.Forms.Padding(7);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(360, 55);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "Start a new order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // LoadOrderButton
            // 
            this.LoadOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadOrderButton.Location = new System.Drawing.Point(230, 404);
            this.LoadOrderButton.Margin = new System.Windows.Forms.Padding(7);
            this.LoadOrderButton.Name = "LoadOrderButton";
            this.LoadOrderButton.Size = new System.Drawing.Size(360, 55);
            this.LoadOrderButton.TabIndex = 1;
            this.LoadOrderButton.Text = "Load a Saved Order";
            this.LoadOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(354, 482);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(7);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 55);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(145, 21);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(564, 39);
            this.OrderLabel.TabIndex = 4;
            this.OrderLabel.Text = "Order your Computer with us Today!";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button LoadOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label OrderLabel;
    }
}