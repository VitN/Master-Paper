namespace Master_Paper
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.velocity = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Value1 = new System.Windows.Forms.Label();
            this.calcVeloc = new System.Windows.Forms.Button();
            this.VelocityCalculation = new System.Windows.Forms.Label();
            this.length_Value = new System.Windows.Forms.TextBox();
            this.x_Value = new System.Windows.Forms.TextBox();
            this.Z2 = new System.Windows.Forms.Label();
            this.tau_Value = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.Label();
            this.xStep1 = new System.Windows.Forms.Label();
            this.Z2_Value = new System.Windows.Forms.TextBox();
            this.timeStep1 = new System.Windows.Forms.Label();
            this.Z1_Value = new System.Windows.Forms.TextBox();
            this.Z1 = new System.Windows.Forms.Label();
            this.InitialData1 = new System.Windows.Forms.Label();
            this.concentration = new System.Windows.Forms.TabPage();
            this.yLength_Value = new System.Windows.Forms.TextBox();
            this.yLength = new System.Windows.Forms.Label();
            this.showConc = new System.Windows.Forms.Button();
            this.timeLayer_Value = new System.Windows.Forms.ComboBox();
            this.timeLayer = new System.Windows.Forms.Label();
            this.massTransfer_Value = new System.Windows.Forms.ComboBox();
            this.yStep_Value = new System.Windows.Forms.TextBox();
            this.yStep = new System.Windows.Forms.Label();
            this.massTransfer = new System.Windows.Forms.Label();
            this.diffusion_Value = new System.Windows.Forms.ComboBox();
            this.diffusion = new System.Windows.Forms.Label();
            this.boundaryII = new System.Windows.Forms.RadioButton();
            this.boundaryI = new System.Windows.Forms.RadioButton();
            this.Boundary = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Velocity_var = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.calcConc = new System.Windows.Forms.Button();
            this.xLength_Value = new System.Windows.Forms.TextBox();
            this.xStep2_Value = new System.Windows.Forms.TextBox();
            this.timeStep2_Value = new System.Windows.Forms.TextBox();
            this.xLength = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.timeStep2 = new System.Windows.Forms.Label();
            this.InitialData2 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.Label();
            this.ConcentrationCalculation = new System.Windows.Forms.Label();
            this.graph = new System.Windows.Forms.TabPage();
            this.diffGammaGraph = new System.Windows.Forms.Button();
            this.diffDGraph = new System.Windows.Forms.Button();
            this.velocGraph = new System.Windows.Forms.Button();
            this.concGraph = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.graph1 = new System.Windows.Forms.TabPage();
            this.graph2 = new System.Windows.Forms.TabPage();
            this.graph3 = new System.Windows.Forms.TabPage();
            this.graph4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.velocity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.concentration.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Velocity_var.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.graph.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.velocity);
            this.tabControl1.Controls.Add(this.concentration);
            this.tabControl1.Controls.Add(this.graph);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 443);
            this.tabControl1.TabIndex = 2;
            // 
            // velocity
            // 
            this.velocity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.velocity.Controls.Add(this.dataGridView4);
            this.velocity.Controls.Add(this.Value1);
            this.velocity.Controls.Add(this.calcVeloc);
            this.velocity.Controls.Add(this.VelocityCalculation);
            this.velocity.Controls.Add(this.length_Value);
            this.velocity.Controls.Add(this.x_Value);
            this.velocity.Controls.Add(this.Z2);
            this.velocity.Controls.Add(this.tau_Value);
            this.velocity.Controls.Add(this.length);
            this.velocity.Controls.Add(this.xStep1);
            this.velocity.Controls.Add(this.Z2_Value);
            this.velocity.Controls.Add(this.timeStep1);
            this.velocity.Controls.Add(this.Z1_Value);
            this.velocity.Controls.Add(this.Z1);
            this.velocity.Controls.Add(this.InitialData1);
            this.velocity.Location = new System.Drawing.Point(4, 22);
            this.velocity.Name = "velocity";
            this.velocity.Size = new System.Drawing.Size(958, 417);
            this.velocity.TabIndex = 2;
            this.velocity.Text = "Визначення швидкості руху рідини";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView4.Location = new System.Drawing.Point(425, 55);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 100;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView4.Size = new System.Drawing.Size(520, 349);
            this.dataGridView4.TabIndex = 41;
            // 
            // Value1
            // 
            this.Value1.AutoSize = true;
            this.Value1.Location = new System.Drawing.Point(422, 39);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(58, 13);
            this.Value1.TabIndex = 40;
            this.Value1.Text = "Значення:";
            // 
            // calcVeloc
            // 
            this.calcVeloc.Location = new System.Drawing.Point(305, 41);
            this.calcVeloc.Name = "calcVeloc";
            this.calcVeloc.Size = new System.Drawing.Size(101, 36);
            this.calcVeloc.TabIndex = 39;
            this.calcVeloc.Text = "Обчислити швидкість";
            this.calcVeloc.UseVisualStyleBackColor = true;
            this.calcVeloc.Click += new System.EventHandler(this.calcVeloc_Click);
            // 
            // VelocityCalculation
            // 
            this.VelocityCalculation.AutoSize = true;
            this.VelocityCalculation.Location = new System.Drawing.Point(323, 14);
            this.VelocityCalculation.Name = "VelocityCalculation";
            this.VelocityCalculation.Size = new System.Drawing.Size(121, 13);
            this.VelocityCalculation.TabIndex = 38;
            this.VelocityCalculation.Text = "Визначення швидкості";
            // 
            // length_Value
            // 
            this.length_Value.Location = new System.Drawing.Point(184, 185);
            this.length_Value.Name = "length_Value";
            this.length_Value.Size = new System.Drawing.Size(100, 20);
            this.length_Value.TabIndex = 37;
            // 
            // x_Value
            // 
            this.x_Value.Location = new System.Drawing.Point(184, 149);
            this.x_Value.Name = "x_Value";
            this.x_Value.Size = new System.Drawing.Size(100, 20);
            this.x_Value.TabIndex = 35;
            // 
            // Z2
            // 
            this.Z2.AutoSize = true;
            this.Z2.Location = new System.Drawing.Point(18, 81);
            this.Z2.Name = "Z2";
            this.Z2.Size = new System.Drawing.Size(62, 13);
            this.Z2.TabIndex = 34;
            this.Z2.Text = "Висота Z2:";
            // 
            // tau_Value
            // 
            this.tau_Value.Location = new System.Drawing.Point(184, 114);
            this.tau_Value.Name = "tau_Value";
            this.tau_Value.Size = new System.Drawing.Size(100, 20);
            this.tau_Value.TabIndex = 33;
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(18, 188);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(57, 13);
            this.length.TabIndex = 32;
            this.length.Text = "Довжина:";
            // 
            // xStep1
            // 
            this.xStep1.AutoSize = true;
            this.xStep1.Location = new System.Drawing.Point(18, 152);
            this.xStep1.Name = "xStep1";
            this.xStep1.Size = new System.Drawing.Size(98, 13);
            this.xStep1.TabIndex = 30;
            this.xStep1.Text = "Крок по x (метри):";
            // 
            // Z2_Value
            // 
            this.Z2_Value.Location = new System.Drawing.Point(184, 78);
            this.Z2_Value.Name = "Z2_Value";
            this.Z2_Value.Size = new System.Drawing.Size(100, 20);
            this.Z2_Value.TabIndex = 29;
            // 
            // timeStep1
            // 
            this.timeStep1.AutoSize = true;
            this.timeStep1.Location = new System.Drawing.Point(18, 117);
            this.timeStep1.Name = "timeStep1";
            this.timeStep1.Size = new System.Drawing.Size(108, 13);
            this.timeStep1.TabIndex = 28;
            this.timeStep1.Text = "Крок по часу (доба):";
            // 
            // Z1_Value
            // 
            this.Z1_Value.Location = new System.Drawing.Point(184, 41);
            this.Z1_Value.Name = "Z1_Value";
            this.Z1_Value.Size = new System.Drawing.Size(100, 20);
            this.Z1_Value.TabIndex = 27;
            // 
            // Z1
            // 
            this.Z1.AutoSize = true;
            this.Z1.Location = new System.Drawing.Point(18, 44);
            this.Z1.Name = "Z1";
            this.Z1.Size = new System.Drawing.Size(62, 13);
            this.Z1.TabIndex = 26;
            this.Z1.Text = "Висота Z1:";
            // 
            // InitialData1
            // 
            this.InitialData1.AutoSize = true;
            this.InitialData1.Location = new System.Drawing.Point(60, 14);
            this.InitialData1.Name = "InitialData1";
            this.InitialData1.Size = new System.Drawing.Size(151, 13);
            this.InitialData1.TabIndex = 25;
            this.InitialData1.Text = "Введення початкових даних:";
            // 
            // concentration
            // 
            this.concentration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.concentration.Controls.Add(this.yLength_Value);
            this.concentration.Controls.Add(this.yLength);
            this.concentration.Controls.Add(this.showConc);
            this.concentration.Controls.Add(this.timeLayer_Value);
            this.concentration.Controls.Add(this.timeLayer);
            this.concentration.Controls.Add(this.massTransfer_Value);
            this.concentration.Controls.Add(this.yStep_Value);
            this.concentration.Controls.Add(this.yStep);
            this.concentration.Controls.Add(this.massTransfer);
            this.concentration.Controls.Add(this.diffusion_Value);
            this.concentration.Controls.Add(this.diffusion);
            this.concentration.Controls.Add(this.boundaryII);
            this.concentration.Controls.Add(this.boundaryI);
            this.concentration.Controls.Add(this.Boundary);
            this.concentration.Controls.Add(this.tabControl2);
            this.concentration.Controls.Add(this.calcConc);
            this.concentration.Controls.Add(this.xLength_Value);
            this.concentration.Controls.Add(this.xStep2_Value);
            this.concentration.Controls.Add(this.timeStep2_Value);
            this.concentration.Controls.Add(this.xLength);
            this.concentration.Controls.Add(this.label25);
            this.concentration.Controls.Add(this.timeStep2);
            this.concentration.Controls.Add(this.InitialData2);
            this.concentration.Controls.Add(this.Value2);
            this.concentration.Controls.Add(this.ConcentrationCalculation);
            this.concentration.Location = new System.Drawing.Point(4, 22);
            this.concentration.Name = "concentration";
            this.concentration.Padding = new System.Windows.Forms.Padding(3);
            this.concentration.Size = new System.Drawing.Size(958, 417);
            this.concentration.TabIndex = 0;
            this.concentration.Text = "Визначення вмісту забруднень в рідині";
            // 
            // yLength_Value
            // 
            this.yLength_Value.Location = new System.Drawing.Point(126, 184);
            this.yLength_Value.Name = "yLength_Value";
            this.yLength_Value.Size = new System.Drawing.Size(100, 20);
            this.yLength_Value.TabIndex = 61;
            // 
            // yLength
            // 
            this.yLength.AutoSize = true;
            this.yLength.Location = new System.Drawing.Point(9, 187);
            this.yLength.Name = "yLength";
            this.yLength.Size = new System.Drawing.Size(83, 13);
            this.yLength.TabIndex = 60;
            this.yLength.Text = "Довжина по y: ";
            // 
            // showConc
            // 
            this.showConc.Location = new System.Drawing.Point(255, 233);
            this.showConc.Name = "showConc";
            this.showConc.Size = new System.Drawing.Size(125, 55);
            this.showConc.TabIndex = 59;
            this.showConc.Text = "Показати";
            this.showConc.UseVisualStyleBackColor = true;
            // 
            // timeLayer_Value
            // 
            this.timeLayer_Value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeLayer_Value.FormattingEnabled = true;
            this.timeLayer_Value.Location = new System.Drawing.Point(255, 184);
            this.timeLayer_Value.Name = "timeLayer_Value";
            this.timeLayer_Value.Size = new System.Drawing.Size(121, 21);
            this.timeLayer_Value.TabIndex = 58;
            // 
            // timeLayer
            // 
            this.timeLayer.AutoSize = true;
            this.timeLayer.Location = new System.Drawing.Point(252, 158);
            this.timeLayer.Name = "timeLayer";
            this.timeLayer.Size = new System.Drawing.Size(74, 13);
            this.timeLayer.TabIndex = 57;
            this.timeLayer.Text = "Часовий шар";
            // 
            // massTransfer_Value
            // 
            this.massTransfer_Value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.massTransfer_Value.FormattingEnabled = true;
            this.massTransfer_Value.Items.AddRange(new object[] {
            "gamma1",
            "gamma2",
            "gamma3"});
            this.massTransfer_Value.Location = new System.Drawing.Point(12, 380);
            this.massTransfer_Value.Name = "massTransfer_Value";
            this.massTransfer_Value.Size = new System.Drawing.Size(121, 21);
            this.massTransfer_Value.TabIndex = 56;
            // 
            // yStep_Value
            // 
            this.yStep_Value.Location = new System.Drawing.Point(126, 112);
            this.yStep_Value.Name = "yStep_Value";
            this.yStep_Value.Size = new System.Drawing.Size(100, 20);
            this.yStep_Value.TabIndex = 55;
            // 
            // yStep
            // 
            this.yStep.AutoSize = true;
            this.yStep.Location = new System.Drawing.Point(6, 115);
            this.yStep.Name = "yStep";
            this.yStep.Size = new System.Drawing.Size(98, 13);
            this.yStep.TabIndex = 54;
            this.yStep.Text = "Крок по y (метри):";
            // 
            // massTransfer
            // 
            this.massTransfer.AutoSize = true;
            this.massTransfer.Location = new System.Drawing.Point(9, 355);
            this.massTransfer.Name = "massTransfer";
            this.massTransfer.Size = new System.Drawing.Size(163, 13);
            this.massTransfer.TabIndex = 52;
            this.massTransfer.Text = "Коефіцієнт масообміну gamma:";
            // 
            // diffusion_Value
            // 
            this.diffusion_Value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diffusion_Value.FormattingEnabled = true;
            this.diffusion_Value.Items.AddRange(new object[] {
            "D1",
            "D2",
            "D3"});
            this.diffusion_Value.Location = new System.Drawing.Point(12, 320);
            this.diffusion_Value.Name = "diffusion_Value";
            this.diffusion_Value.Size = new System.Drawing.Size(121, 21);
            this.diffusion_Value.TabIndex = 51;
            // 
            // diffusion
            // 
            this.diffusion.AutoSize = true;
            this.diffusion.Location = new System.Drawing.Point(9, 291);
            this.diffusion.Name = "diffusion";
            this.diffusion.Size = new System.Drawing.Size(114, 13);
            this.diffusion.TabIndex = 50;
            this.diffusion.Text = "Коефіцієнт дифузії D:";
            // 
            // boundaryII
            // 
            this.boundaryII.AutoSize = true;
            this.boundaryII.Location = new System.Drawing.Point(9, 271);
            this.boundaryII.Name = "boundaryII";
            this.boundaryII.Size = new System.Drawing.Size(57, 17);
            this.boundaryII.TabIndex = 49;
            this.boundaryII.TabStop = true;
            this.boundaryII.Text = "ІІ роду";
            this.boundaryII.UseVisualStyleBackColor = true;
            // 
            // boundaryI
            // 
            this.boundaryI.AutoSize = true;
            this.boundaryI.Location = new System.Drawing.Point(9, 238);
            this.boundaryI.Name = "boundaryI";
            this.boundaryI.Size = new System.Drawing.Size(54, 17);
            this.boundaryI.TabIndex = 48;
            this.boundaryI.TabStop = true;
            this.boundaryI.Text = "І роду";
            this.boundaryI.UseVisualStyleBackColor = true;
            // 
            // Boundary
            // 
            this.Boundary.AutoSize = true;
            this.Boundary.Location = new System.Drawing.Point(6, 212);
            this.Boundary.Name = "Boundary";
            this.Boundary.Size = new System.Drawing.Size(91, 13);
            this.Boundary.TabIndex = 47;
            this.Boundary.Text = "Гранична умова:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Velocity_var);
            this.tabControl2.Location = new System.Drawing.Point(382, 63);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(570, 348);
            this.tabControl2.TabIndex = 45;
            // 
            // Velocity_var
            // 
            this.Velocity_var.Controls.Add(this.dataGridView5);
            this.Velocity_var.Location = new System.Drawing.Point(4, 22);
            this.Velocity_var.Name = "Velocity_var";
            this.Velocity_var.Padding = new System.Windows.Forms.Padding(3);
            this.Velocity_var.Size = new System.Drawing.Size(562, 322);
            this.Velocity_var.TabIndex = 1;
            this.Velocity_var.Text = "Концентрація";
            this.Velocity_var.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToResizeColumns = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView5.Location = new System.Drawing.Point(6, 5);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersWidth = 100;
            this.dataGridView5.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView5.Size = new System.Drawing.Size(550, 311);
            this.dataGridView5.TabIndex = 26;
            // 
            // calcConc
            // 
            this.calcConc.Location = new System.Drawing.Point(255, 90);
            this.calcConc.Name = "calcConc";
            this.calcConc.Size = new System.Drawing.Size(125, 55);
            this.calcConc.TabIndex = 44;
            this.calcConc.Text = "Обчислити концентрацію";
            this.calcConc.UseVisualStyleBackColor = true;
            // 
            // xLength_Value
            // 
            this.xLength_Value.Location = new System.Drawing.Point(126, 146);
            this.xLength_Value.Name = "xLength_Value";
            this.xLength_Value.Size = new System.Drawing.Size(100, 20);
            this.xLength_Value.TabIndex = 43;
            // 
            // xStep2_Value
            // 
            this.xStep2_Value.Location = new System.Drawing.Point(126, 77);
            this.xStep2_Value.Name = "xStep2_Value";
            this.xStep2_Value.Size = new System.Drawing.Size(100, 20);
            this.xStep2_Value.TabIndex = 42;
            // 
            // timeStep2_Value
            // 
            this.timeStep2_Value.Location = new System.Drawing.Point(126, 42);
            this.timeStep2_Value.Name = "timeStep2_Value";
            this.timeStep2_Value.Size = new System.Drawing.Size(100, 20);
            this.timeStep2_Value.TabIndex = 41;
            // 
            // xLength
            // 
            this.xLength.AutoSize = true;
            this.xLength.Location = new System.Drawing.Point(9, 149);
            this.xLength.Name = "xLength";
            this.xLength.Size = new System.Drawing.Size(83, 13);
            this.xLength.TabIndex = 40;
            this.xLength.Text = "Довжина по x: ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 80);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "Крок по x (метри):";
            // 
            // timeStep2
            // 
            this.timeStep2.AutoSize = true;
            this.timeStep2.Location = new System.Drawing.Point(6, 45);
            this.timeStep2.Name = "timeStep2";
            this.timeStep2.Size = new System.Drawing.Size(108, 13);
            this.timeStep2.TabIndex = 38;
            this.timeStep2.Text = "Крок по часу (доба):";
            // 
            // InitialData2
            // 
            this.InitialData2.AutoSize = true;
            this.InitialData2.Location = new System.Drawing.Point(30, 19);
            this.InitialData2.Name = "InitialData2";
            this.InitialData2.Size = new System.Drawing.Size(151, 13);
            this.InitialData2.TabIndex = 26;
            this.InitialData2.Text = "Введення початкових даних:";
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Location = new System.Drawing.Point(379, 38);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(58, 13);
            this.Value2.TabIndex = 11;
            this.Value2.Text = "Значення:";
            // 
            // ConcentrationCalculation
            // 
            this.ConcentrationCalculation.AutoSize = true;
            this.ConcentrationCalculation.Location = new System.Drawing.Point(287, 19);
            this.ConcentrationCalculation.Name = "ConcentrationCalculation";
            this.ConcentrationCalculation.Size = new System.Drawing.Size(137, 13);
            this.ConcentrationCalculation.TabIndex = 9;
            this.ConcentrationCalculation.Text = "Визначення концентрації:";
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.Color.WhiteSmoke;
            this.graph.Controls.Add(this.diffGammaGraph);
            this.graph.Controls.Add(this.diffDGraph);
            this.graph.Controls.Add(this.velocGraph);
            this.graph.Controls.Add(this.concGraph);
            this.graph.Controls.Add(this.tabControl3);
            this.graph.Location = new System.Drawing.Point(4, 22);
            this.graph.Name = "graph";
            this.graph.Padding = new System.Windows.Forms.Padding(3);
            this.graph.Size = new System.Drawing.Size(958, 417);
            this.graph.TabIndex = 1;
            this.graph.Text = "Побудова графіків";
            // 
            // diffGammaGraph
            // 
            this.diffGammaGraph.Location = new System.Drawing.Point(19, 347);
            this.diffGammaGraph.Name = "diffGammaGraph";
            this.diffGammaGraph.Size = new System.Drawing.Size(125, 64);
            this.diffGammaGraph.TabIndex = 7;
            this.diffGammaGraph.Text = "Побудувати графік концентрацій для різних коефіцієнтів дифузії";
            this.diffGammaGraph.UseVisualStyleBackColor = true;
            // 
            // diffDGraph
            // 
            this.diffDGraph.Location = new System.Drawing.Point(19, 242);
            this.diffDGraph.Name = "diffDGraph";
            this.diffDGraph.Size = new System.Drawing.Size(125, 65);
            this.diffDGraph.TabIndex = 6;
            this.diffDGraph.Text = "Побудувати графік концентрацій для різних коефіцієнтах  масообміну";
            this.diffDGraph.UseVisualStyleBackColor = true;
            // 
            // velocGraph
            // 
            this.velocGraph.Location = new System.Drawing.Point(19, 142);
            this.velocGraph.Name = "velocGraph";
            this.velocGraph.Size = new System.Drawing.Size(125, 58);
            this.velocGraph.TabIndex = 4;
            this.velocGraph.Text = "Побудувати графік швидкості";
            this.velocGraph.UseVisualStyleBackColor = true;
            // 
            // concGraph
            // 
            this.concGraph.Location = new System.Drawing.Point(19, 42);
            this.concGraph.Name = "concGraph";
            this.concGraph.Size = new System.Drawing.Size(125, 58);
            this.concGraph.TabIndex = 3;
            this.concGraph.Text = "Побудувати графік концентрації";
            this.concGraph.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.graph1);
            this.tabControl3.Controls.Add(this.graph2);
            this.tabControl3.Controls.Add(this.graph3);
            this.tabControl3.Controls.Add(this.graph4);
            this.tabControl3.Location = new System.Drawing.Point(167, 20);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(771, 391);
            this.tabControl3.TabIndex = 2;
            // 
            // graph1
            // 
            this.graph1.Location = new System.Drawing.Point(4, 22);
            this.graph1.Name = "graph1";
            this.graph1.Padding = new System.Windows.Forms.Padding(3);
            this.graph1.Size = new System.Drawing.Size(763, 365);
            this.graph1.TabIndex = 1;
            this.graph1.Text = "Графік концентрації";
            this.graph1.UseVisualStyleBackColor = true;
            // 
            // graph2
            // 
            this.graph2.Location = new System.Drawing.Point(4, 22);
            this.graph2.Name = "graph2";
            this.graph2.Size = new System.Drawing.Size(763, 365);
            this.graph2.TabIndex = 2;
            this.graph2.Text = "Графік швидкості";
            this.graph2.UseVisualStyleBackColor = true;
            // 
            // graph3
            // 
            this.graph3.Location = new System.Drawing.Point(4, 22);
            this.graph3.Name = "graph3";
            this.graph3.Size = new System.Drawing.Size(763, 365);
            this.graph3.TabIndex = 4;
            this.graph3.Text = "Графік концентрації для різних коефіцієнтів масообміну";
            this.graph3.UseVisualStyleBackColor = true;
            // 
            // graph4
            // 
            this.graph4.Location = new System.Drawing.Point(4, 22);
            this.graph4.Name = "graph4";
            this.graph4.Size = new System.Drawing.Size(763, 365);
            this.graph4.TabIndex = 5;
            this.graph4.Text = "Графік концентрації для різних коефіцієнтів дифузії";
            this.graph4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Master Paper";
            this.tabControl1.ResumeLayout(false);
            this.velocity.ResumeLayout(false);
            this.velocity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.concentration.ResumeLayout(false);
            this.concentration.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.Velocity_var.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.graph.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage velocity;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label Value1;
        private System.Windows.Forms.Button calcVeloc;
        private System.Windows.Forms.Label VelocityCalculation;
        private System.Windows.Forms.TextBox length_Value;
        private System.Windows.Forms.TextBox x_Value;
        private System.Windows.Forms.Label Z2;
        private System.Windows.Forms.TextBox tau_Value;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label xStep1;
        private System.Windows.Forms.TextBox Z2_Value;
        private System.Windows.Forms.Label timeStep1;
        private System.Windows.Forms.TextBox Z1_Value;
        private System.Windows.Forms.Label Z1;
        private System.Windows.Forms.Label InitialData1;
        private System.Windows.Forms.TabPage concentration;
        private System.Windows.Forms.ComboBox massTransfer_Value;
        private System.Windows.Forms.TextBox yStep_Value;
        private System.Windows.Forms.Label yStep;
        private System.Windows.Forms.Label massTransfer;
        private System.Windows.Forms.ComboBox diffusion_Value;
        private System.Windows.Forms.Label diffusion;
        private System.Windows.Forms.RadioButton boundaryII;
        private System.Windows.Forms.RadioButton boundaryI;
        private System.Windows.Forms.Label Boundary;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Velocity_var;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button calcConc;
        private System.Windows.Forms.TextBox xLength_Value;
        private System.Windows.Forms.TextBox xStep2_Value;
        private System.Windows.Forms.TextBox timeStep2_Value;
        private System.Windows.Forms.Label xLength;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label timeStep2;
        private System.Windows.Forms.Label InitialData2;
        private System.Windows.Forms.Label Value2;
        private System.Windows.Forms.Label ConcentrationCalculation;
        private System.Windows.Forms.TabPage graph;
        private System.Windows.Forms.Button diffGammaGraph;
        private System.Windows.Forms.Button diffDGraph;
        private System.Windows.Forms.Button velocGraph;
        private System.Windows.Forms.Button concGraph;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage graph1;
        private System.Windows.Forms.TabPage graph2;
        private System.Windows.Forms.TabPage graph3;
        private System.Windows.Forms.TabPage graph4;
        private System.Windows.Forms.Button showConc;
        private System.Windows.Forms.ComboBox timeLayer_Value;
        private System.Windows.Forms.Label timeLayer;
        private System.Windows.Forms.TextBox yLength_Value;
        private System.Windows.Forms.Label yLength;
    }
}

