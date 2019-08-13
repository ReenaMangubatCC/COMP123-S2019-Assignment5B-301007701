namespace COMP123_S2019_Assignment5B_301007701.Views
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FinishButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.OSDataLabel = new System.Windows.Forms.Label();
            this.CPUBrandDataLabel = new System.Windows.Forms.Label();
            this.AudioTypeDataLabel = new System.Windows.Forms.Label();
            this.GPUTypeDataLabel = new System.Windows.Forms.Label();
            this.MemoryDataLabel = new System.Windows.Forms.Label();
            this.HDDDataLabel = new System.Windows.Forms.Label();
            this.LCDDataLabel = new System.Windows.Forms.Label();
            this.CPUSpeedDataLabel = new System.Windows.Forms.Label();
            this.ModelDataLabel = new System.Windows.Forms.Label();
            this.CPUNumberDataLabel = new System.Windows.Forms.Label();
            this.PlatformDataLabel = new System.Windows.Forms.Label();
            this.CPUTypeDataLabel = new System.Windows.Forms.Label();
            this.ManufacturerDataLabel = new System.Windows.Forms.Label();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.AudioTypeLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDTypeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.PriceSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalDataLabel = new System.Windows.Forms.Label();
            this.SalesTaxDataLabel = new System.Windows.Forms.Label();
            this.PriceDataLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.PriceSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.OrderFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(1006, 29);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(109, 6);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.backToolStripMenuItem.Text = "B&ack";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(887, 525);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(107, 41);
            this.FinishButton.TabIndex = 1;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(640, 525);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(102, 41);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.OSDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.AudioTypeDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.AudioTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(21, 49);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(652, 422);
            this.SystemComponentsGroupBox.TabIndex = 3;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // OSDataLabel
            // 
            this.OSDataLabel.BackColor = System.Drawing.Color.White;
            this.OSDataLabel.ForeColor = System.Drawing.Color.Black;
            this.OSDataLabel.Location = new System.Drawing.Point(453, 342);
            this.OSDataLabel.Name = "OSDataLabel";
            this.OSDataLabel.Size = new System.Drawing.Size(174, 24);
            this.OSDataLabel.TabIndex = 17;
            // 
            // CPUBrandDataLabel
            // 
            this.CPUBrandDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandDataLabel.ForeColor = System.Drawing.Color.Black;
            this.CPUBrandDataLabel.Location = new System.Drawing.Point(145, 336);
            this.CPUBrandDataLabel.Name = "CPUBrandDataLabel";
            this.CPUBrandDataLabel.Size = new System.Drawing.Size(174, 24);
            this.CPUBrandDataLabel.TabIndex = 17;
            // 
            // AudioTypeDataLabel
            // 
            this.AudioTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.AudioTypeDataLabel.ForeColor = System.Drawing.Color.Black;
            this.AudioTypeDataLabel.Location = new System.Drawing.Point(453, 287);
            this.AudioTypeDataLabel.Name = "AudioTypeDataLabel";
            this.AudioTypeDataLabel.Size = new System.Drawing.Size(174, 24);
            this.AudioTypeDataLabel.TabIndex = 17;
            // 
            // GPUTypeDataLabel
            // 
            this.GPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeDataLabel.ForeColor = System.Drawing.Color.Black;
            this.GPUTypeDataLabel.Location = new System.Drawing.Point(455, 236);
            this.GPUTypeDataLabel.Name = "GPUTypeDataLabel";
            this.GPUTypeDataLabel.Size = new System.Drawing.Size(174, 24);
            this.GPUTypeDataLabel.TabIndex = 17;
            // 
            // MemoryDataLabel
            // 
            this.MemoryDataLabel.BackColor = System.Drawing.Color.White;
            this.MemoryDataLabel.ForeColor = System.Drawing.Color.Black;
            this.MemoryDataLabel.Location = new System.Drawing.Point(145, 281);
            this.MemoryDataLabel.Name = "MemoryDataLabel";
            this.MemoryDataLabel.Size = new System.Drawing.Size(174, 24);
            this.MemoryDataLabel.TabIndex = 17;
            // 
            // HDDDataLabel
            // 
            this.HDDDataLabel.BackColor = System.Drawing.Color.White;
            this.HDDDataLabel.ForeColor = System.Drawing.Color.Black;
            this.HDDDataLabel.Location = new System.Drawing.Point(455, 190);
            this.HDDDataLabel.Name = "HDDDataLabel";
            this.HDDDataLabel.Size = new System.Drawing.Size(174, 24);
            this.HDDDataLabel.TabIndex = 17;
            // 
            // LCDDataLabel
            // 
            this.LCDDataLabel.BackColor = System.Drawing.Color.White;
            this.LCDDataLabel.ForeColor = System.Drawing.Color.Black;
            this.LCDDataLabel.Location = new System.Drawing.Point(147, 230);
            this.LCDDataLabel.Name = "LCDDataLabel";
            this.LCDDataLabel.Size = new System.Drawing.Size(174, 24);
            this.LCDDataLabel.TabIndex = 17;
            // 
            // CPUSpeedDataLabel
            // 
            this.CPUSpeedDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedDataLabel.ForeColor = System.Drawing.Color.Black;
            this.CPUSpeedDataLabel.Location = new System.Drawing.Point(456, 147);
            this.CPUSpeedDataLabel.Name = "CPUSpeedDataLabel";
            this.CPUSpeedDataLabel.Size = new System.Drawing.Size(174, 24);
            this.CPUSpeedDataLabel.TabIndex = 17;
            // 
            // ModelDataLabel
            // 
            this.ModelDataLabel.BackColor = System.Drawing.Color.White;
            this.ModelDataLabel.ForeColor = System.Drawing.Color.Black;
            this.ModelDataLabel.Location = new System.Drawing.Point(147, 184);
            this.ModelDataLabel.Name = "ModelDataLabel";
            this.ModelDataLabel.Size = new System.Drawing.Size(174, 24);
            this.ModelDataLabel.TabIndex = 17;
            // 
            // CPUNumberDataLabel
            // 
            this.CPUNumberDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumberDataLabel.ForeColor = System.Drawing.Color.Black;
            this.CPUNumberDataLabel.Location = new System.Drawing.Point(455, 105);
            this.CPUNumberDataLabel.Name = "CPUNumberDataLabel";
            this.CPUNumberDataLabel.Size = new System.Drawing.Size(174, 24);
            this.CPUNumberDataLabel.TabIndex = 17;
            // 
            // PlatformDataLabel
            // 
            this.PlatformDataLabel.BackColor = System.Drawing.Color.White;
            this.PlatformDataLabel.ForeColor = System.Drawing.Color.Black;
            this.PlatformDataLabel.Location = new System.Drawing.Point(148, 141);
            this.PlatformDataLabel.Name = "PlatformDataLabel";
            this.PlatformDataLabel.Size = new System.Drawing.Size(174, 24);
            this.PlatformDataLabel.TabIndex = 17;
            // 
            // CPUTypeDataLabel
            // 
            this.CPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeDataLabel.ForeColor = System.Drawing.Color.Black;
            this.CPUTypeDataLabel.Location = new System.Drawing.Point(455, 53);
            this.CPUTypeDataLabel.Name = "CPUTypeDataLabel";
            this.CPUTypeDataLabel.Size = new System.Drawing.Size(174, 24);
            this.CPUTypeDataLabel.TabIndex = 16;
            // 
            // ManufacturerDataLabel
            // 
            this.ManufacturerDataLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerDataLabel.ForeColor = System.Drawing.Color.Black;
            this.ManufacturerDataLabel.Location = new System.Drawing.Point(147, 99);
            this.ManufacturerDataLabel.Name = "ManufacturerDataLabel";
            this.ManufacturerDataLabel.Size = new System.Drawing.Size(174, 24);
            this.ManufacturerDataLabel.TabIndex = 17;
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.BackColor = System.Drawing.Color.White;
            this.ConditionDataLabel.ForeColor = System.Drawing.Color.Black;
            this.ConditionDataLabel.Location = new System.Drawing.Point(147, 47);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(174, 24);
            this.ConditionDataLabel.TabIndex = 16;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(391, 335);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(48, 25);
            this.OSLabel.TabIndex = 15;
            this.OSLabel.Text = "OS:";
            // 
            // AudioTypeLabel
            // 
            this.AudioTypeLabel.AutoSize = true;
            this.AudioTypeLabel.Location = new System.Drawing.Point(328, 286);
            this.AudioTypeLabel.Name = "AudioTypeLabel";
            this.AudioTypeLabel.Size = new System.Drawing.Size(119, 25);
            this.AudioTypeLabel.TabIndex = 14;
            this.AudioTypeLabel.Text = "Audio Type:";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(338, 229);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(110, 25);
            this.GPUTypeLabel.TabIndex = 13;
            this.GPUTypeLabel.Text = "GPU Type:";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(376, 183);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(60, 25);
            this.HDDLabel.TabIndex = 11;
            this.HDDLabel.Text = "HDD:";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(328, 140);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(123, 25);
            this.CPUSpeedLabel.TabIndex = 10;
            this.CPUSpeedLabel.Text = "CPU Speed:";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(324, 99);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(134, 25);
            this.CPUNumberLabel.TabIndex = 9;
            this.CPUNumberLabel.Text = "CPU Number:";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(347, 52);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(110, 25);
            this.CPUTypeLabel.TabIndex = 8;
            this.CPUTypeLabel.Text = "CPU Type:";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(25, 335);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(117, 25);
            this.CPUBrandLabel.TabIndex = 7;
            this.CPUBrandLabel.Text = "CPU Brand:";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(50, 281);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(89, 25);
            this.MemoryLabel.TabIndex = 6;
            this.MemoryLabel.Text = "Memory:";
            // 
            // LCDTypeLabel
            // 
            this.LCDTypeLabel.AutoSize = true;
            this.LCDTypeLabel.Location = new System.Drawing.Point(37, 229);
            this.LCDTypeLabel.Name = "LCDTypeLabel";
            this.LCDTypeLabel.Size = new System.Drawing.Size(108, 25);
            this.LCDTypeLabel.TabIndex = 5;
            this.LCDTypeLabel.Text = "LCD Type:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(65, 183);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(72, 25);
            this.ModelLabel.TabIndex = 4;
            this.ModelLabel.Text = "Model:";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(50, 140);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(89, 25);
            this.PlatformLabel.TabIndex = 2;
            this.PlatformLabel.Text = "Platform:";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(11, 99);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(133, 25);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "Manufacturer:";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ConditionLabel.Location = new System.Drawing.Point(40, 47);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(101, 25);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition:";
            // 
            // PriceSummaryGroupBox
            // 
            this.PriceSummaryGroupBox.Controls.Add(this.TotalDataLabel);
            this.PriceSummaryGroupBox.Controls.Add(this.SalesTaxDataLabel);
            this.PriceSummaryGroupBox.Controls.Add(this.PriceDataLabel);
            this.PriceSummaryGroupBox.Controls.Add(this.TotalLabel);
            this.PriceSummaryGroupBox.Controls.Add(this.SalesTaxLabel);
            this.PriceSummaryGroupBox.Controls.Add(this.PriceLabel);
            this.PriceSummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceSummaryGroupBox.Location = new System.Drawing.Point(679, 148);
            this.PriceSummaryGroupBox.Name = "PriceSummaryGroupBox";
            this.PriceSummaryGroupBox.Size = new System.Drawing.Size(301, 245);
            this.PriceSummaryGroupBox.TabIndex = 4;
            this.PriceSummaryGroupBox.TabStop = false;
            this.PriceSummaryGroupBox.Text = "Price Summary";
            // 
            // TotalDataLabel
            // 
            this.TotalDataLabel.BackColor = System.Drawing.Color.White;
            this.TotalDataLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalDataLabel.Location = new System.Drawing.Point(135, 187);
            this.TotalDataLabel.Name = "TotalDataLabel";
            this.TotalDataLabel.Size = new System.Drawing.Size(151, 25);
            this.TotalDataLabel.TabIndex = 5;
            // 
            // SalesTaxDataLabel
            // 
            this.SalesTaxDataLabel.BackColor = System.Drawing.Color.White;
            this.SalesTaxDataLabel.ForeColor = System.Drawing.Color.Black;
            this.SalesTaxDataLabel.Location = new System.Drawing.Point(135, 104);
            this.SalesTaxDataLabel.Name = "SalesTaxDataLabel";
            this.SalesTaxDataLabel.Size = new System.Drawing.Size(151, 25);
            this.SalesTaxDataLabel.TabIndex = 4;
            // 
            // PriceDataLabel
            // 
            this.PriceDataLabel.BackColor = System.Drawing.Color.White;
            this.PriceDataLabel.ForeColor = System.Drawing.Color.Black;
            this.PriceDataLabel.Location = new System.Drawing.Point(135, 52);
            this.PriceDataLabel.Name = "PriceDataLabel";
            this.PriceDataLabel.Size = new System.Drawing.Size(151, 25);
            this.PriceDataLabel.TabIndex = 3;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(60, 187);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(62, 25);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total:";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(22, 104);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(107, 25);
            this.SalesTaxLabel.TabIndex = 1;
            this.SalesTaxLabel.Text = "Sales Tax:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(60, 52);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(62, 25);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price:";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(778, 525);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(103, 41);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 578);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PriceSummaryGroupBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.PriceSummaryGroupBox.ResumeLayout(false);
            this.PriceSummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label AudioTypeLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDTypeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.GroupBox PriceSummaryGroupBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TotalDataLabel;
        private System.Windows.Forms.Label SalesTaxDataLabel;
        private System.Windows.Forms.Label PriceDataLabel;
        private System.Windows.Forms.Label OSDataLabel;
        private System.Windows.Forms.Label CPUBrandDataLabel;
        private System.Windows.Forms.Label AudioTypeDataLabel;
        private System.Windows.Forms.Label GPUTypeDataLabel;
        private System.Windows.Forms.Label MemoryDataLabel;
        private System.Windows.Forms.Label HDDDataLabel;
        private System.Windows.Forms.Label LCDDataLabel;
        private System.Windows.Forms.Label CPUSpeedDataLabel;
        private System.Windows.Forms.Label ModelDataLabel;
        private System.Windows.Forms.Label CPUNumberDataLabel;
        private System.Windows.Forms.Label PlatformDataLabel;
        private System.Windows.Forms.Label CPUTypeDataLabel;
        private System.Windows.Forms.Label ManufacturerDataLabel;
        private System.Windows.Forms.Label ConditionDataLabel;
    }
}