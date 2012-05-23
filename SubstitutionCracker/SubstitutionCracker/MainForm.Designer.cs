namespace SubstitutionCracker
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudNumberOfGenerations = new System.Windows.Forms.NumericUpDown();
            this.nudPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.nudTournamentSize = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfCrossoverPoints = new System.Windows.Forms.NumericUpDown();
            this.tbxTournamentWinnerProbability = new System.Windows.Forms.TextBox();
            this.tbxProbabilityOfCrossover = new System.Windows.Forms.TextBox();
            this.tbxProbabilityOfMutation = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadTrainingFile = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.nudPercentageOfElitism = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.plainText = new System.Windows.Forms.RichTextBox();
            this.btnLoadPlainText = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cipherText = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.decryptedText = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRunAlgorithm = new System.Windows.Forms.Button();
            this.lblGeneration = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTournamentSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfCrossoverPoints)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentageOfElitism)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbOptions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.tableLayoutPanel2);
            this.gbOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOptions.Location = new System.Drawing.Point(3, 3);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(786, 149);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudNumberOfGenerations, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudPopulationSize, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudTournamentSize, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.nudNumberOfCrossoverPoints, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbxTournamentWinnerProbability, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbxProbabilityOfCrossover, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbxProbabilityOfMutation, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.nudPercentageOfElitism, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 130);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(393, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Percentage of Elitism:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(393, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Probability of Mutation:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(393, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Probability of Crossover:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Generations:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Population Size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tournament Size:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tournament Winner Probability:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Training File:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(393, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Number of Crossover Points:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudNumberOfGenerations
            // 
            this.nudNumberOfGenerations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNumberOfGenerations.Location = new System.Drawing.Point(183, 3);
            this.nudNumberOfGenerations.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNumberOfGenerations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfGenerations.Name = "nudNumberOfGenerations";
            this.nudNumberOfGenerations.Size = new System.Drawing.Size(204, 20);
            this.nudNumberOfGenerations.TabIndex = 14;
            this.nudNumberOfGenerations.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudPopulationSize
            // 
            this.nudPopulationSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPopulationSize.Location = new System.Drawing.Point(183, 28);
            this.nudPopulationSize.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudPopulationSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPopulationSize.Name = "nudPopulationSize";
            this.nudPopulationSize.Size = new System.Drawing.Size(204, 20);
            this.nudPopulationSize.TabIndex = 15;
            this.nudPopulationSize.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nudTournamentSize
            // 
            this.nudTournamentSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTournamentSize.Location = new System.Drawing.Point(183, 53);
            this.nudTournamentSize.Name = "nudTournamentSize";
            this.nudTournamentSize.Size = new System.Drawing.Size(204, 20);
            this.nudTournamentSize.TabIndex = 16;
            this.nudTournamentSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudNumberOfCrossoverPoints
            // 
            this.nudNumberOfCrossoverPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNumberOfCrossoverPoints.Location = new System.Drawing.Point(573, 28);
            this.nudNumberOfCrossoverPoints.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.nudNumberOfCrossoverPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfCrossoverPoints.Name = "nudNumberOfCrossoverPoints";
            this.nudNumberOfCrossoverPoints.Size = new System.Drawing.Size(204, 20);
            this.nudNumberOfCrossoverPoints.TabIndex = 17;
            this.nudNumberOfCrossoverPoints.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tbxTournamentWinnerProbability
            // 
            this.tbxTournamentWinnerProbability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTournamentWinnerProbability.Location = new System.Drawing.Point(183, 78);
            this.tbxTournamentWinnerProbability.Name = "tbxTournamentWinnerProbability";
            this.tbxTournamentWinnerProbability.Size = new System.Drawing.Size(204, 20);
            this.tbxTournamentWinnerProbability.TabIndex = 18;
            this.tbxTournamentWinnerProbability.Text = "0.75";
            // 
            // tbxProbabilityOfCrossover
            // 
            this.tbxProbabilityOfCrossover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxProbabilityOfCrossover.Location = new System.Drawing.Point(573, 3);
            this.tbxProbabilityOfCrossover.Name = "tbxProbabilityOfCrossover";
            this.tbxProbabilityOfCrossover.Size = new System.Drawing.Size(204, 20);
            this.tbxProbabilityOfCrossover.TabIndex = 20;
            this.tbxProbabilityOfCrossover.Text = "0.65";
            // 
            // tbxProbabilityOfMutation
            // 
            this.tbxProbabilityOfMutation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxProbabilityOfMutation.Location = new System.Drawing.Point(573, 53);
            this.tbxProbabilityOfMutation.Name = "tbxProbabilityOfMutation";
            this.tbxProbabilityOfMutation.Size = new System.Drawing.Size(204, 20);
            this.tbxProbabilityOfMutation.TabIndex = 21;
            this.tbxProbabilityOfMutation.Text = "0.20";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel5, 3);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.Controls.Add(this.btnLoadTrainingFile, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblFilename, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(180, 100);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(600, 30);
            this.tableLayoutPanel5.TabIndex = 23;
            // 
            // btnLoadTrainingFile
            // 
            this.btnLoadTrainingFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadTrainingFile.Location = new System.Drawing.Point(483, 3);
            this.btnLoadTrainingFile.Name = "btnLoadTrainingFile";
            this.btnLoadTrainingFile.Size = new System.Drawing.Size(114, 24);
            this.btnLoadTrainingFile.TabIndex = 0;
            this.btnLoadTrainingFile.Text = "Load Training File";
            this.btnLoadTrainingFile.UseVisualStyleBackColor = true;
            this.btnLoadTrainingFile.Click += new System.EventHandler(this.btnLoadTrainingFile_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilename.Location = new System.Drawing.Point(3, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(474, 30);
            this.lblFilename.TabIndex = 1;
            this.lblFilename.Text = "No File Selected";
            this.lblFilename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudPercentageOfElitism
            // 
            this.nudPercentageOfElitism.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPercentageOfElitism.Location = new System.Drawing.Point(573, 78);
            this.nudPercentageOfElitism.Name = "nudPercentageOfElitism";
            this.nudPercentageOfElitism.Size = new System.Drawing.Size(204, 20);
            this.nudPercentageOfElitism.TabIndex = 24;
            this.nudPercentageOfElitism.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 155);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 228);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 222);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plain Text";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.plainText, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnLoadPlainText, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(252, 203);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // plainText
            // 
            this.plainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plainText.Location = new System.Drawing.Point(3, 3);
            this.plainText.Name = "plainText";
            this.plainText.ReadOnly = true;
            this.plainText.Size = new System.Drawing.Size(246, 167);
            this.plainText.TabIndex = 2;
            this.plainText.Text = "";
            // 
            // btnLoadPlainText
            // 
            this.btnLoadPlainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadPlainText.Location = new System.Drawing.Point(3, 176);
            this.btnLoadPlainText.Name = "btnLoadPlainText";
            this.btnLoadPlainText.Size = new System.Drawing.Size(246, 24);
            this.btnLoadPlainText.TabIndex = 1;
            this.btnLoadPlainText.Text = "Load Plain Text and Encrypt with Random Key";
            this.btnLoadPlainText.UseVisualStyleBackColor = true;
            this.btnLoadPlainText.Click += new System.EventHandler(this.btnLoadPlainText_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cipherText);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(267, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 222);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cipher Text";
            // 
            // cipherText
            // 
            this.cipherText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cipherText.Location = new System.Drawing.Point(3, 16);
            this.cipherText.Name = "cipherText";
            this.cipherText.ReadOnly = true;
            this.cipherText.Size = new System.Drawing.Size(252, 203);
            this.cipherText.TabIndex = 0;
            this.cipherText.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.decryptedText);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(531, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 222);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current Decryption Result";
            // 
            // decryptedText
            // 
            this.decryptedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptedText.Location = new System.Drawing.Point(3, 16);
            this.decryptedText.Name = "decryptedText";
            this.decryptedText.ReadOnly = true;
            this.decryptedText.Size = new System.Drawing.Size(252, 203);
            this.decryptedText.TabIndex = 0;
            this.decryptedText.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // outputText
            // 
            this.outputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputText.Location = new System.Drawing.Point(3, 16);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(780, 127);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.Controls.Add(this.btnRunAlgorithm, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblGeneration, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 535);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(792, 31);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // btnRunAlgorithm
            // 
            this.btnRunAlgorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRunAlgorithm.Enabled = false;
            this.btnRunAlgorithm.Location = new System.Drawing.Point(555, 3);
            this.btnRunAlgorithm.Name = "btnRunAlgorithm";
            this.btnRunAlgorithm.Size = new System.Drawing.Size(114, 25);
            this.btnRunAlgorithm.TabIndex = 1;
            this.btnRunAlgorithm.Text = "Run Algorithm";
            this.btnRunAlgorithm.UseVisualStyleBackColor = true;
            this.btnRunAlgorithm.Click += new System.EventHandler(this.btnRunAlgorithm_Click);
            // 
            // lblGeneration
            // 
            this.lblGeneration.AutoSize = true;
            this.lblGeneration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneration.Location = new System.Drawing.Point(3, 0);
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(546, 31);
            this.lblGeneration.TabIndex = 2;
            this.lblGeneration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(675, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Substitution Cipher Cracker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTournamentSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfCrossoverPoints)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentageOfElitism)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox cipherText;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox decryptedText;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnLoadPlainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudNumberOfGenerations;
        private System.Windows.Forms.NumericUpDown nudPopulationSize;
        private System.Windows.Forms.NumericUpDown nudTournamentSize;
        private System.Windows.Forms.NumericUpDown nudNumberOfCrossoverPoints;
        private System.Windows.Forms.TextBox tbxTournamentWinnerProbability;
        private System.Windows.Forms.TextBox tbxProbabilityOfCrossover;
        private System.Windows.Forms.TextBox tbxProbabilityOfMutation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnLoadTrainingFile;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnRunAlgorithm;
        private System.Windows.Forms.NumericUpDown nudPercentageOfElitism;
        private System.Windows.Forms.RichTextBox plainText;
        private System.Windows.Forms.Label lblGeneration;
        private System.Windows.Forms.Button btnCancel;
    }
}

