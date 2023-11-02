namespace Space_Station
{
    partial class GameForm
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
            this.FuelButton = new System.Windows.Forms.Button();
            this.JumpButton = new System.Windows.Forms.Button();
            this.Ware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaresLV = new System.Windows.Forms.ListView();
            this.wareName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wareVolume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wareValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wareAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaresLVP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StationLabel = new System.Windows.Forms.Label();
            this.ShipLabel = new System.Windows.Forms.Label();
            this.FuelLevelBar = new System.Windows.Forms.ProgressBar();
            this.FuelLevel = new System.Windows.Forms.Label();
            this.VolumeLevel = new System.Windows.Forms.Label();
            this.VolumeLevelBar = new System.Windows.Forms.ProgressBar();
            this.PlayerMoneyCount = new System.Windows.Forms.Label();
            this.FuelCost = new System.Windows.Forms.TextBox();
            this.FuelAmount = new System.Windows.Forms.TextBox();
            this.FuelBox = new System.Windows.Forms.GroupBox();
            this.FuelBoxMax = new System.Windows.Forms.Button();
            this.FuelBoxConfirm = new System.Windows.Forms.Button();
            this.FuelBoxCost = new System.Windows.Forms.Label();
            this.FuelBoxTitle = new System.Windows.Forms.Label();
            this.FuelBoxAmount = new System.Windows.Forms.NumericUpDown();
            this.BuyBox = new System.Windows.Forms.GroupBox();
            this.BuyBoxMax = new System.Windows.Forms.Button();
            this.BuyBoxVolume = new System.Windows.Forms.Label();
            this.BuyBoxConfirm = new System.Windows.Forms.Button();
            this.BuyBoxCost = new System.Windows.Forms.Label();
            this.BuyBoxTitle = new System.Windows.Forms.Label();
            this.BuyBoxAmount = new System.Windows.Forms.NumericUpDown();
            this.SellBox = new System.Windows.Forms.GroupBox();
            this.SellBoxCargo = new System.Windows.Forms.Label();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.SellBoxMax = new System.Windows.Forms.Button();
            this.SellBoxConfirm = new System.Windows.Forms.Button();
            this.SellBoxCost = new System.Windows.Forms.Label();
            this.SellBoxTitle = new System.Windows.Forms.Label();
            this.SellBoxAmount = new System.Windows.Forms.NumericUpDown();
            this.pre0 = new System.Windows.Forms.Label();
            this.pre1 = new System.Windows.Forms.Label();
            this.pre3 = new System.Windows.Forms.Label();
            this.pre2 = new System.Windows.Forms.Label();
            this.pre7 = new System.Windows.Forms.Label();
            this.pre6 = new System.Windows.Forms.Label();
            this.pre5 = new System.Windows.Forms.Label();
            this.pre4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ShipBox = new System.Windows.Forms.GroupBox();
            this.ShipBoxTotalUpgrade = new System.Windows.Forms.Label();
            this.ShipBoxLevel = new System.Windows.Forms.Label();
            this.ShipBoxMax = new System.Windows.Forms.Button();
            this.ShipBoxItem = new System.Windows.Forms.Label();
            this.ShipBoxConfirm = new System.Windows.Forms.Button();
            this.ShipBoxCost = new System.Windows.Forms.Label();
            this.ShipBoxAmount = new System.Windows.Forms.NumericUpDown();
            this.EngineLevel = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.TotalJumps = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DealerBox = new System.Windows.Forms.GroupBox();
            this.DealerList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DealerConfirm = new System.Windows.Forms.Button();
            this.FuelBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuelBoxAmount)).BeginInit();
            this.BuyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyBoxAmount)).BeginInit();
            this.SellBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellBoxAmount)).BeginInit();
            this.ShipBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipBoxAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DealerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FuelButton
            // 
            this.FuelButton.Location = new System.Drawing.Point(297, 17);
            this.FuelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuelButton.Name = "FuelButton";
            this.FuelButton.Size = new System.Drawing.Size(68, 98);
            this.FuelButton.TabIndex = 3;
            this.FuelButton.Text = "Fuel";
            this.FuelButton.UseVisualStyleBackColor = true;
            // 
            // JumpButton
            // 
            this.JumpButton.Location = new System.Drawing.Point(374, 17);
            this.JumpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(142, 98);
            this.JumpButton.TabIndex = 4;
            this.JumpButton.Text = "Jump";
            this.JumpButton.UseVisualStyleBackColor = true;
            // 
            // Ware
            // 
            this.Ware.HeaderText = "Ware";
            this.Ware.MinimumWidth = 8;
            this.Ware.Name = "Ware";
            this.Ware.Width = 150;
            // 
            // Vol
            // 
            this.Vol.HeaderText = "Vol";
            this.Vol.MinimumWidth = 8;
            this.Vol.Name = "Vol";
            this.Vol.Width = 150;
            // 
            // WaresLV
            // 
            this.WaresLV.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.WaresLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.wareName,
            this.wareVolume,
            this.wareValue,
            this.wareAmount});
            this.WaresLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.WaresLV.HideSelection = false;
            this.WaresLV.Location = new System.Drawing.Point(18, 55);
            this.WaresLV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WaresLV.MultiSelect = false;
            this.WaresLV.Name = "WaresLV";
            this.WaresLV.Size = new System.Drawing.Size(522, 262);
            this.WaresLV.TabIndex = 8;
            this.WaresLV.UseCompatibleStateImageBehavior = false;
            // 
            // wareName
            // 
            this.wareName.Text = "Ware";
            this.wareName.Width = 150;
            // 
            // wareVolume
            // 
            this.wareVolume.Text = "Vol";
            this.wareVolume.Width = 40;
            // 
            // wareValue
            // 
            this.wareValue.Text = "Current Value";
            this.wareValue.Width = 80;
            // 
            // wareAmount
            // 
            this.wareAmount.Text = "Quantity";
            this.wareAmount.Width = 70;
            // 
            // WaresLVP
            // 
            this.WaresLVP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.WaresLVP.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.WaresLVP.HideSelection = false;
            this.WaresLVP.Location = new System.Drawing.Point(615, 55);
            this.WaresLVP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WaresLVP.MultiSelect = false;
            this.WaresLVP.Name = "WaresLVP";
            this.WaresLVP.Size = new System.Drawing.Size(522, 262);
            this.WaresLVP.TabIndex = 9;
            this.WaresLVP.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ware";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vol";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 90;
            // 
            // StationLabel
            // 
            this.StationLabel.AutoSize = true;
            this.StationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationLabel.Location = new System.Drawing.Point(30, 20);
            this.StationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StationLabel.Name = "StationLabel";
            this.StationLabel.Size = new System.Drawing.Size(94, 29);
            this.StationLabel.TabIndex = 10;
            this.StationLabel.Text = "Station";
            // 
            // ShipLabel
            // 
            this.ShipLabel.AutoSize = true;
            this.ShipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipLabel.Location = new System.Drawing.Point(632, 20);
            this.ShipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShipLabel.Name = "ShipLabel";
            this.ShipLabel.Size = new System.Drawing.Size(87, 29);
            this.ShipLabel.TabIndex = 11;
            this.ShipLabel.Text = "Player";
            // 
            // FuelLevelBar
            // 
            this.FuelLevelBar.Location = new System.Drawing.Point(9, 58);
            this.FuelLevelBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuelLevelBar.Name = "FuelLevelBar";
            this.FuelLevelBar.Size = new System.Drawing.Size(232, 15);
            this.FuelLevelBar.TabIndex = 13;
            // 
            // FuelLevel
            // 
            this.FuelLevel.AutoSize = true;
            this.FuelLevel.BackColor = System.Drawing.SystemColors.Control;
            this.FuelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelLevel.Location = new System.Drawing.Point(9, 75);
            this.FuelLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FuelLevel.Name = "FuelLevel";
            this.FuelLevel.Size = new System.Drawing.Size(40, 18);
            this.FuelLevel.TabIndex = 14;
            this.FuelLevel.Text = "Fuel";
            // 
            // VolumeLevel
            // 
            this.VolumeLevel.AutoSize = true;
            this.VolumeLevel.BackColor = System.Drawing.SystemColors.Control;
            this.VolumeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeLevel.Location = new System.Drawing.Point(9, 38);
            this.VolumeLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VolumeLevel.Name = "VolumeLevel";
            this.VolumeLevel.Size = new System.Drawing.Size(71, 20);
            this.VolumeLevel.TabIndex = 16;
            this.VolumeLevel.Text = "Volume";
            // 
            // VolumeLevelBar
            // 
            this.VolumeLevelBar.Location = new System.Drawing.Point(9, 20);
            this.VolumeLevelBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VolumeLevelBar.Name = "VolumeLevelBar";
            this.VolumeLevelBar.Size = new System.Drawing.Size(174, 15);
            this.VolumeLevelBar.TabIndex = 15;
            // 
            // PlayerMoneyCount
            // 
            this.PlayerMoneyCount.AutoSize = true;
            this.PlayerMoneyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMoneyCount.Location = new System.Drawing.Point(9, 75);
            this.PlayerMoneyCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerMoneyCount.Name = "PlayerMoneyCount";
            this.PlayerMoneyCount.Size = new System.Drawing.Size(63, 20);
            this.PlayerMoneyCount.TabIndex = 17;
            this.PlayerMoneyCount.Text = "Money";
            // 
            // FuelCost
            // 
            this.FuelCost.Location = new System.Drawing.Point(9, 18);
            this.FuelCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuelCost.Name = "FuelCost";
            this.FuelCost.Size = new System.Drawing.Size(151, 26);
            this.FuelCost.TabIndex = 18;
            // 
            // FuelAmount
            // 
            this.FuelAmount.Location = new System.Drawing.Point(171, 18);
            this.FuelAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuelAmount.Name = "FuelAmount";
            this.FuelAmount.Size = new System.Drawing.Size(68, 26);
            this.FuelAmount.TabIndex = 19;
            // 
            // FuelBox
            // 
            this.FuelBox.Controls.Add(this.FuelBoxMax);
            this.FuelBox.Controls.Add(this.FuelBoxConfirm);
            this.FuelBox.Controls.Add(this.FuelBoxCost);
            this.FuelBox.Controls.Add(this.FuelBoxTitle);
            this.FuelBox.Controls.Add(this.FuelBoxAmount);
            this.FuelBox.Location = new System.Drawing.Point(18, 445);
            this.FuelBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuelBox.Name = "FuelBox";
            this.FuelBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuelBox.Size = new System.Drawing.Size(524, 189);
            this.FuelBox.TabIndex = 20;
            this.FuelBox.TabStop = false;
            this.FuelBox.Text = "Fuel";
            // 
            // FuelBoxMax
            // 
            this.FuelBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelBoxMax.Location = new System.Drawing.Point(22, 74);
            this.FuelBoxMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuelBoxMax.Name = "FuelBoxMax";
            this.FuelBoxMax.Size = new System.Drawing.Size(57, 31);
            this.FuelBoxMax.TabIndex = 4;
            this.FuelBoxMax.Text = "Max";
            this.FuelBoxMax.UseVisualStyleBackColor = true;
            // 
            // FuelBoxConfirm
            // 
            this.FuelBoxConfirm.Location = new System.Drawing.Point(384, 134);
            this.FuelBoxConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuelBoxConfirm.Name = "FuelBoxConfirm";
            this.FuelBoxConfirm.Size = new System.Drawing.Size(112, 35);
            this.FuelBoxConfirm.TabIndex = 3;
            this.FuelBoxConfirm.Text = "Confirm";
            this.FuelBoxConfirm.UseVisualStyleBackColor = true;
            // 
            // FuelBoxCost
            // 
            this.FuelBoxCost.AutoSize = true;
            this.FuelBoxCost.Location = new System.Drawing.Point(20, 134);
            this.FuelBoxCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FuelBoxCost.Name = "FuelBoxCost";
            this.FuelBoxCost.Size = new System.Drawing.Size(51, 20);
            this.FuelBoxCost.TabIndex = 2;
            this.FuelBoxCost.Text = "label2";
            // 
            // FuelBoxTitle
            // 
            this.FuelBoxTitle.AutoSize = true;
            this.FuelBoxTitle.Location = new System.Drawing.Point(20, 35);
            this.FuelBoxTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FuelBoxTitle.Name = "FuelBoxTitle";
            this.FuelBoxTitle.Size = new System.Drawing.Size(271, 20);
            this.FuelBoxTitle.TabIndex = 1;
            this.FuelBoxTitle.Text = "How much fuel would you like to buy?";
            // 
            // FuelBoxAmount
            // 
            this.FuelBoxAmount.Location = new System.Drawing.Point(80, 74);
            this.FuelBoxAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuelBoxAmount.Name = "FuelBoxAmount";
            this.FuelBoxAmount.Size = new System.Drawing.Size(104, 26);
            this.FuelBoxAmount.TabIndex = 0;
            // 
            // BuyBox
            // 
            this.BuyBox.Controls.Add(this.BuyBoxMax);
            this.BuyBox.Controls.Add(this.BuyBoxVolume);
            this.BuyBox.Controls.Add(this.BuyBoxConfirm);
            this.BuyBox.Controls.Add(this.BuyBoxCost);
            this.BuyBox.Controls.Add(this.BuyBoxTitle);
            this.BuyBox.Controls.Add(this.BuyBoxAmount);
            this.BuyBox.Location = new System.Drawing.Point(615, 1029);
            this.BuyBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuyBox.Name = "BuyBox";
            this.BuyBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuyBox.Size = new System.Drawing.Size(524, 189);
            this.BuyBox.TabIndex = 21;
            this.BuyBox.TabStop = false;
            this.BuyBox.Text = "Buy";
            // 
            // BuyBoxMax
            // 
            this.BuyBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyBoxMax.Location = new System.Drawing.Point(22, 74);
            this.BuyBoxMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuyBoxMax.Name = "BuyBoxMax";
            this.BuyBoxMax.Size = new System.Drawing.Size(57, 31);
            this.BuyBoxMax.TabIndex = 5;
            this.BuyBoxMax.Text = "Max";
            this.BuyBoxMax.UseVisualStyleBackColor = true;
            // 
            // BuyBoxVolume
            // 
            this.BuyBoxVolume.AutoSize = true;
            this.BuyBoxVolume.Location = new System.Drawing.Point(177, 134);
            this.BuyBoxVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuyBoxVolume.Name = "BuyBoxVolume";
            this.BuyBoxVolume.Size = new System.Drawing.Size(51, 20);
            this.BuyBoxVolume.TabIndex = 4;
            this.BuyBoxVolume.Text = "label2";
            // 
            // BuyBoxConfirm
            // 
            this.BuyBoxConfirm.Location = new System.Drawing.Point(384, 134);
            this.BuyBoxConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuyBoxConfirm.Name = "BuyBoxConfirm";
            this.BuyBoxConfirm.Size = new System.Drawing.Size(112, 35);
            this.BuyBoxConfirm.TabIndex = 3;
            this.BuyBoxConfirm.Text = "Confirm";
            this.BuyBoxConfirm.UseVisualStyleBackColor = true;
            // 
            // BuyBoxCost
            // 
            this.BuyBoxCost.AutoSize = true;
            this.BuyBoxCost.Location = new System.Drawing.Point(20, 134);
            this.BuyBoxCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuyBoxCost.Name = "BuyBoxCost";
            this.BuyBoxCost.Size = new System.Drawing.Size(51, 20);
            this.BuyBoxCost.TabIndex = 2;
            this.BuyBoxCost.Text = "label2";
            // 
            // BuyBoxTitle
            // 
            this.BuyBoxTitle.AutoSize = true;
            this.BuyBoxTitle.Location = new System.Drawing.Point(20, 35);
            this.BuyBoxTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuyBoxTitle.Name = "BuyBoxTitle";
            this.BuyBoxTitle.Size = new System.Drawing.Size(240, 20);
            this.BuyBoxTitle.TabIndex = 1;
            this.BuyBoxTitle.Text = "How many would you like to buy?";
            // 
            // BuyBoxAmount
            // 
            this.BuyBoxAmount.Location = new System.Drawing.Point(80, 74);
            this.BuyBoxAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuyBoxAmount.Name = "BuyBoxAmount";
            this.BuyBoxAmount.Size = new System.Drawing.Size(104, 26);
            this.BuyBoxAmount.TabIndex = 0;
            // 
            // SellBox
            // 
            this.SellBox.Controls.Add(this.SellBoxCargo);
            this.SellBox.Controls.Add(this.DiscardButton);
            this.SellBox.Controls.Add(this.SellBoxMax);
            this.SellBox.Controls.Add(this.SellBoxConfirm);
            this.SellBox.Controls.Add(this.SellBoxCost);
            this.SellBox.Controls.Add(this.SellBoxTitle);
            this.SellBox.Controls.Add(this.SellBoxAmount);
            this.SellBox.Location = new System.Drawing.Point(18, 1029);
            this.SellBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellBox.Name = "SellBox";
            this.SellBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellBox.Size = new System.Drawing.Size(524, 189);
            this.SellBox.TabIndex = 22;
            this.SellBox.TabStop = false;
            this.SellBox.Text = "Sell";
            // 
            // SellBoxCargo
            // 
            this.SellBoxCargo.AutoSize = true;
            this.SellBoxCargo.Location = new System.Drawing.Point(352, 77);
            this.SellBoxCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SellBoxCargo.Name = "SellBoxCargo";
            this.SellBoxCargo.Size = new System.Drawing.Size(106, 20);
            this.SellBoxCargo.TabIndex = 8;
            this.SellBoxCargo.Text = "Cargo volume";
            // 
            // DiscardButton
            // 
            this.DiscardButton.Location = new System.Drawing.Point(357, 34);
            this.DiscardButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscardButton.Name = "DiscardButton";
            this.DiscardButton.Size = new System.Drawing.Size(140, 31);
            this.DiscardButton.TabIndex = 37;
            this.DiscardButton.Text = "Discard Wares";
            this.DiscardButton.UseVisualStyleBackColor = true;
            // 
            // SellBoxMax
            // 
            this.SellBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellBoxMax.Location = new System.Drawing.Point(22, 74);
            this.SellBoxMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellBoxMax.Name = "SellBoxMax";
            this.SellBoxMax.Size = new System.Drawing.Size(57, 31);
            this.SellBoxMax.TabIndex = 6;
            this.SellBoxMax.Text = "Max";
            this.SellBoxMax.UseVisualStyleBackColor = true;
            // 
            // SellBoxConfirm
            // 
            this.SellBoxConfirm.Location = new System.Drawing.Point(384, 134);
            this.SellBoxConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellBoxConfirm.Name = "SellBoxConfirm";
            this.SellBoxConfirm.Size = new System.Drawing.Size(112, 35);
            this.SellBoxConfirm.TabIndex = 3;
            this.SellBoxConfirm.Text = "Confirm";
            this.SellBoxConfirm.UseVisualStyleBackColor = true;
            // 
            // SellBoxCost
            // 
            this.SellBoxCost.AutoSize = true;
            this.SellBoxCost.Location = new System.Drawing.Point(20, 134);
            this.SellBoxCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SellBoxCost.Name = "SellBoxCost";
            this.SellBoxCost.Size = new System.Drawing.Size(51, 20);
            this.SellBoxCost.TabIndex = 2;
            this.SellBoxCost.Text = "label2";
            // 
            // SellBoxTitle
            // 
            this.SellBoxTitle.AutoSize = true;
            this.SellBoxTitle.Location = new System.Drawing.Point(20, 35);
            this.SellBoxTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SellBoxTitle.Name = "SellBoxTitle";
            this.SellBoxTitle.Size = new System.Drawing.Size(229, 20);
            this.SellBoxTitle.TabIndex = 1;
            this.SellBoxTitle.Text = "How may would you like to sell?";
            // 
            // SellBoxAmount
            // 
            this.SellBoxAmount.Location = new System.Drawing.Point(80, 74);
            this.SellBoxAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellBoxAmount.Name = "SellBoxAmount";
            this.SellBoxAmount.Size = new System.Drawing.Size(104, 26);
            this.SellBoxAmount.TabIndex = 0;
            // 
            // pre0
            // 
            this.pre0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre0.Location = new System.Drawing.Point(543, 97);
            this.pre0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pre0.Name = "pre0";
            this.pre0.Size = new System.Drawing.Size(72, 20);
            this.pre0.TabIndex = 23;
            this.pre0.Text = ">";
            this.pre0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pre1
            // 
            this.pre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre1.Location = new System.Drawing.Point(543, 123);
            this.pre1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pre1.Name = "pre1";
            this.pre1.Size = new System.Drawing.Size(72, 20);
            this.pre1.TabIndex = 24;
            this.pre1.Text = ">";
            this.pre1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pre3
            // 
            this.pre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre3.Location = new System.Drawing.Point(543, 175);
            this.pre3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pre3.Name = "pre3";
            this.pre3.Size = new System.Drawing.Size(72, 20);
            this.pre3.TabIndex = 26;
            this.pre3.Text = ">";
            this.pre3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pre2
            // 
            this.pre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre2.Location = new System.Drawing.Point(543, 149);
            this.pre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pre2.Name = "pre2";
            this.pre2.Size = new System.Drawing.Size(72, 20);
            this.pre2.TabIndex = 25;
            this.pre2.Text = ">";
            this.pre2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pre7
            // 
            this.pre7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre7.Location = new System.Drawing.Point(543, 280);
            this.pre7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pre7.Name = "pre7";
            this.pre7.Size = new System.Drawing.Size(72, 20);
            this.pre7.TabIndex = 30;
            this.pre7.Text = ">";
            this.pre7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pre6
            // 
            this.pre6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre6.Location = new System.Drawing.Point(543, 254);
            this.pre6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pre6.Name = "pre6";
            this.pre6.Size = new System.Drawing.Size(72, 20);
            this.pre6.TabIndex = 29;
            this.pre6.Text = ">";
            this.pre6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pre5
            // 
            this.pre5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre5.Location = new System.Drawing.Point(543, 228);
            this.pre5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pre5.Name = "pre5";
            this.pre5.Size = new System.Drawing.Size(72, 20);
            this.pre5.TabIndex = 28;
            this.pre5.Text = ">";
            this.pre5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pre4
            // 
            this.pre4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre4.Location = new System.Drawing.Point(543, 202);
            this.pre4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pre4.Name = "pre4";
            this.pre4.Size = new System.Drawing.Size(72, 20);
            this.pre4.TabIndex = 27;
            this.pre4.Text = ">";
            this.pre4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShipBox
            // 
            this.ShipBox.Controls.Add(this.ShipBoxTotalUpgrade);
            this.ShipBox.Controls.Add(this.ShipBoxLevel);
            this.ShipBox.Controls.Add(this.ShipBoxMax);
            this.ShipBox.Controls.Add(this.ShipBoxItem);
            this.ShipBox.Controls.Add(this.ShipBoxConfirm);
            this.ShipBox.Controls.Add(this.ShipBoxCost);
            this.ShipBox.Controls.Add(this.ShipBoxAmount);
            this.ShipBox.Location = new System.Drawing.Point(18, 831);
            this.ShipBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShipBox.Name = "ShipBox";
            this.ShipBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShipBox.Size = new System.Drawing.Size(1120, 189);
            this.ShipBox.TabIndex = 23;
            this.ShipBox.TabStop = false;
            this.ShipBox.Text = "Ship Enhancement";
            // 
            // ShipBoxTotalUpgrade
            // 
            this.ShipBoxTotalUpgrade.AutoSize = true;
            this.ShipBoxTotalUpgrade.Location = new System.Drawing.Point(621, 85);
            this.ShipBoxTotalUpgrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShipBoxTotalUpgrade.Name = "ShipBoxTotalUpgrade";
            this.ShipBoxTotalUpgrade.Size = new System.Drawing.Size(107, 20);
            this.ShipBoxTotalUpgrade.TabIndex = 7;
            this.ShipBoxTotalUpgrade.Text = "Total upgrade";
            // 
            // ShipBoxLevel
            // 
            this.ShipBoxLevel.AutoSize = true;
            this.ShipBoxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipBoxLevel.Location = new System.Drawing.Point(24, 85);
            this.ShipBoxLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShipBoxLevel.Name = "ShipBoxLevel";
            this.ShipBoxLevel.Size = new System.Drawing.Size(40, 25);
            this.ShipBoxLevel.TabIndex = 6;
            this.ShipBoxLevel.Text = "0/0";
            // 
            // ShipBoxMax
            // 
            this.ShipBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipBoxMax.Location = new System.Drawing.Point(618, 131);
            this.ShipBoxMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShipBoxMax.Name = "ShipBoxMax";
            this.ShipBoxMax.Size = new System.Drawing.Size(57, 31);
            this.ShipBoxMax.TabIndex = 5;
            this.ShipBoxMax.Text = "Max";
            this.ShipBoxMax.UseVisualStyleBackColor = true;
            // 
            // ShipBoxItem
            // 
            this.ShipBoxItem.AutoSize = true;
            this.ShipBoxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipBoxItem.Location = new System.Drawing.Point(24, 42);
            this.ShipBoxItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShipBoxItem.Name = "ShipBoxItem";
            this.ShipBoxItem.Size = new System.Drawing.Size(76, 26);
            this.ShipBoxItem.TabIndex = 4;
            this.ShipBoxItem.Text = "label2";
            // 
            // ShipBoxConfirm
            // 
            this.ShipBoxConfirm.Location = new System.Drawing.Point(981, 131);
            this.ShipBoxConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShipBoxConfirm.Name = "ShipBoxConfirm";
            this.ShipBoxConfirm.Size = new System.Drawing.Size(112, 35);
            this.ShipBoxConfirm.TabIndex = 3;
            this.ShipBoxConfirm.Text = "Confirm";
            this.ShipBoxConfirm.UseVisualStyleBackColor = true;
            // 
            // ShipBoxCost
            // 
            this.ShipBoxCost.AutoSize = true;
            this.ShipBoxCost.Location = new System.Drawing.Point(802, 135);
            this.ShipBoxCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShipBoxCost.Name = "ShipBoxCost";
            this.ShipBoxCost.Size = new System.Drawing.Size(51, 20);
            this.ShipBoxCost.TabIndex = 2;
            this.ShipBoxCost.Text = "label2";
            // 
            // ShipBoxAmount
            // 
            this.ShipBoxAmount.Location = new System.Drawing.Point(675, 131);
            this.ShipBoxAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShipBoxAmount.Name = "ShipBoxAmount";
            this.ShipBoxAmount.Size = new System.Drawing.Size(104, 26);
            this.ShipBoxAmount.TabIndex = 0;
            // 
            // EngineLevel
            // 
            this.EngineLevel.AutoSize = true;
            this.EngineLevel.BackColor = System.Drawing.SystemColors.Control;
            this.EngineLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineLevel.Location = new System.Drawing.Point(9, 95);
            this.EngineLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EngineLevel.Name = "EngineLevel";
            this.EngineLevel.Size = new System.Drawing.Size(174, 18);
            this.EngineLevel.TabIndex = 31;
            this.EngineLevel.Text = "Engine Comsumption:";
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Location = new System.Drawing.Point(267, 25);
            this.PlayerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(51, 20);
            this.PlayerScore.TabIndex = 32;
            this.PlayerScore.Text = "Score";
            // 
            // TotalJumps
            // 
            this.TotalJumps.AutoSize = true;
            this.TotalJumps.Location = new System.Drawing.Point(267, 65);
            this.TotalJumps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalJumps.Name = "TotalJumps";
            this.TotalJumps.Size = new System.Drawing.Size(56, 20);
            this.TotalJumps.TabIndex = 33;
            this.TotalJumps.Text = "Jumps";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VolumeLevelBar);
            this.groupBox1.Controls.Add(this.TotalJumps);
            this.groupBox1.Controls.Add(this.VolumeLevel);
            this.groupBox1.Controls.Add(this.PlayerScore);
            this.groupBox1.Controls.Add(this.PlayerMoneyCount);
            this.groupBox1.Location = new System.Drawing.Point(615, 323);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(524, 123);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FuelCost);
            this.groupBox2.Controls.Add(this.FuelButton);
            this.groupBox2.Controls.Add(this.EngineLevel);
            this.groupBox2.Controls.Add(this.JumpButton);
            this.groupBox2.Controls.Add(this.FuelLevelBar);
            this.groupBox2.Controls.Add(this.FuelLevel);
            this.groupBox2.Controls.Add(this.FuelAmount);
            this.groupBox2.Location = new System.Drawing.Point(18, 323);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(524, 123);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // DealerBox
            // 
            this.DealerBox.Controls.Add(this.DealerList);
            this.DealerBox.Controls.Add(this.DealerConfirm);
            this.DealerBox.Location = new System.Drawing.Point(18, 632);
            this.DealerBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DealerBox.Name = "DealerBox";
            this.DealerBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DealerBox.Size = new System.Drawing.Size(1120, 189);
            this.DealerBox.TabIndex = 36;
            this.DealerBox.TabStop = false;
            this.DealerBox.Text = "Ship Dealership";
            // 
            // DealerList
            // 
            this.DealerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.DealerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DealerList.HideSelection = false;
            this.DealerList.Location = new System.Drawing.Point(24, 29);
            this.DealerList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DealerList.MultiSelect = false;
            this.DealerList.Name = "DealerList";
            this.DealerList.Size = new System.Drawing.Size(702, 135);
            this.DealerList.TabIndex = 37;
            this.DealerList.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ship Name";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Max Fuel";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fuel Burn";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Max Cargo";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Crew";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Price";
            this.columnHeader9.Width = 80;
            // 
            // DealerConfirm
            // 
            this.DealerConfirm.Location = new System.Drawing.Point(981, 131);
            this.DealerConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DealerConfirm.Name = "DealerConfirm";
            this.DealerConfirm.Size = new System.Drawing.Size(112, 35);
            this.DealerConfirm.TabIndex = 6;
            this.DealerConfirm.Text = "Confirm";
            this.DealerConfirm.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1166, 1237);
            this.Controls.Add(this.DealerBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShipBox);
            this.Controls.Add(this.pre7);
            this.Controls.Add(this.pre6);
            this.Controls.Add(this.pre5);
            this.Controls.Add(this.pre4);
            this.Controls.Add(this.pre3);
            this.Controls.Add(this.pre2);
            this.Controls.Add(this.pre1);
            this.Controls.Add(this.pre0);
            this.Controls.Add(this.SellBox);
            this.Controls.Add(this.BuyBox);
            this.Controls.Add(this.FuelBox);
            this.Controls.Add(this.ShipLabel);
            this.Controls.Add(this.StationLabel);
            this.Controls.Add(this.WaresLVP);
            this.Controls.Add(this.WaresLV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Station";
            this.FuelBox.ResumeLayout(false);
            this.FuelBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuelBoxAmount)).EndInit();
            this.BuyBox.ResumeLayout(false);
            this.BuyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyBoxAmount)).EndInit();
            this.SellBox.ResumeLayout(false);
            this.SellBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellBoxAmount)).EndInit();
            this.ShipBox.ResumeLayout(false);
            this.ShipBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipBoxAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DealerBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FuelButton;
        private System.Windows.Forms.Button JumpButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ware;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vol;
        private System.Windows.Forms.ListView WaresLV;
        private System.Windows.Forms.ColumnHeader wareName;
        private System.Windows.Forms.ColumnHeader wareVolume;
        private System.Windows.Forms.ColumnHeader wareValue;
        private System.Windows.Forms.ListView WaresLVP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label StationLabel;
        private System.Windows.Forms.Label ShipLabel;
        private System.Windows.Forms.ProgressBar FuelLevelBar;
        private System.Windows.Forms.Label FuelLevel;
        private System.Windows.Forms.Label VolumeLevel;
        private System.Windows.Forms.ProgressBar VolumeLevelBar;
        private System.Windows.Forms.Label PlayerMoneyCount;
        private System.Windows.Forms.TextBox FuelCost;
        private System.Windows.Forms.ColumnHeader wareAmount;
        private System.Windows.Forms.TextBox FuelAmount;
        private System.Windows.Forms.GroupBox FuelBox;
        private System.Windows.Forms.Label FuelBoxTitle;
        private System.Windows.Forms.NumericUpDown FuelBoxAmount;
        private System.Windows.Forms.Button FuelBoxConfirm;
        private System.Windows.Forms.Label FuelBoxCost;
        private System.Windows.Forms.GroupBox BuyBox;
        private System.Windows.Forms.Button BuyBoxConfirm;
        private System.Windows.Forms.Label BuyBoxCost;
        private System.Windows.Forms.Label BuyBoxTitle;
        private System.Windows.Forms.NumericUpDown BuyBoxAmount;
        private System.Windows.Forms.Label BuyBoxVolume;
        private System.Windows.Forms.GroupBox SellBox;
        private System.Windows.Forms.Button SellBoxConfirm;
        private System.Windows.Forms.Label SellBoxCost;
        private System.Windows.Forms.Label SellBoxTitle;
        private System.Windows.Forms.NumericUpDown SellBoxAmount;
        private System.Windows.Forms.Label pre0;
        private System.Windows.Forms.Label pre1;
        private System.Windows.Forms.Label pre3;
        private System.Windows.Forms.Label pre2;
        private System.Windows.Forms.Label pre7;
        private System.Windows.Forms.Label pre6;
        private System.Windows.Forms.Label pre5;
        private System.Windows.Forms.Label pre4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox ShipBox;
        private System.Windows.Forms.Button ShipBoxConfirm;
        private System.Windows.Forms.Label ShipBoxCost;
        private System.Windows.Forms.NumericUpDown ShipBoxAmount;
        private System.Windows.Forms.Label ShipBoxItem;
        private System.Windows.Forms.Label EngineLevel;
        private System.Windows.Forms.Button FuelBoxMax;
        private System.Windows.Forms.Button BuyBoxMax;
        private System.Windows.Forms.Button SellBoxMax;
        private System.Windows.Forms.Button ShipBoxMax;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label TotalJumps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox DealerBox;
        private System.Windows.Forms.ListView DealerList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button DealerConfirm;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label ShipBoxLevel;
        private System.Windows.Forms.Label ShipBoxTotalUpgrade;
        private System.Windows.Forms.Button DiscardButton;
        private System.Windows.Forms.Label SellBoxCargo;
    }
}

