
namespace TestMM
{
    partial class Main
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
            this.Board = new System.Windows.Forms.PictureBox();
            this.BoardWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BoardHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caGrainsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caNeighborhoodComboBox = new System.Windows.Forms.ComboBox();
            this.caAddRandomGrainsButton = new System.Windows.Forms.Button();
            this.caSimulateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.gridPeriodicCheckBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WidthLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ParametersGB = new System.Windows.Forms.GroupBox();
            this.ChoseMethodLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ParametersGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.White;
            this.Board.Location = new System.Drawing.Point(218, 12);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(380, 336);
            this.Board.TabIndex = 0;
            this.Board.TabStop = false;
            this.Board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            // 
            // BoardWidthNumericUpDown
            // 
            this.BoardWidthNumericUpDown.Location = new System.Drawing.Point(54, 27);
            this.BoardWidthNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BoardWidthNumericUpDown.Name = "BoardWidthNumericUpDown";
            this.BoardWidthNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.BoardWidthNumericUpDown.TabIndex = 1;
            this.BoardWidthNumericUpDown.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // BoardHeightNumericUpDown
            // 
            this.BoardHeightNumericUpDown.Location = new System.Drawing.Point(54, 54);
            this.BoardHeightNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BoardHeightNumericUpDown.Name = "BoardHeightNumericUpDown";
            this.BoardHeightNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.BoardHeightNumericUpDown.TabIndex = 2;
            this.BoardHeightNumericUpDown.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // caGrainsNumericUpDown
            // 
            this.caGrainsNumericUpDown.Location = new System.Drawing.Point(8, 19);
            this.caGrainsNumericUpDown.Name = "caGrainsNumericUpDown";
            this.caGrainsNumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.caGrainsNumericUpDown.TabIndex = 3;
            // 
            // caNeighborhoodComboBox
            // 
            this.caNeighborhoodComboBox.Items.AddRange(new object[] {
            "Moore",
            "Von Neumann"});
            this.caNeighborhoodComboBox.Location = new System.Drawing.Point(8, 45);
            this.caNeighborhoodComboBox.Name = "caNeighborhoodComboBox";
            this.caNeighborhoodComboBox.Size = new System.Drawing.Size(74, 21);
            this.caNeighborhoodComboBox.TabIndex = 24;
            this.caNeighborhoodComboBox.SelectedIndexChanged += new System.EventHandler(this.caNeighborhoodComboBox_SelectedIndexChanged);
            // 
            // caAddRandomGrainsButton
            // 
            this.caAddRandomGrainsButton.Location = new System.Drawing.Point(88, 16);
            this.caAddRandomGrainsButton.Name = "caAddRandomGrainsButton";
            this.caAddRandomGrainsButton.Size = new System.Drawing.Size(91, 23);
            this.caAddRandomGrainsButton.TabIndex = 6;
            this.caAddRandomGrainsButton.Text = "Add Grain";
            this.caAddRandomGrainsButton.UseVisualStyleBackColor = true;
            this.caAddRandomGrainsButton.Click += new System.EventHandler(this.caAddRandomGrainsButton_Click);
            // 
            // caSimulateButton
            // 
            this.caSimulateButton.Location = new System.Drawing.Point(21, 281);
            this.caSimulateButton.Name = "caSimulateButton";
            this.caSimulateButton.Size = new System.Drawing.Size(90, 23);
            this.caSimulateButton.TabIndex = 7;
            this.caSimulateButton.Text = "Start";
            this.caSimulateButton.UseVisualStyleBackColor = true;
            this.caSimulateButton.Click += new System.EventHandler(this.caSimulateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(122, 281);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(90, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // gridPeriodicCheckBox
            // 
            this.gridPeriodicCheckBox.AutoSize = true;
            this.gridPeriodicCheckBox.Location = new System.Drawing.Point(9, 92);
            this.gridPeriodicCheckBox.Name = "gridPeriodicCheckBox";
            this.gridPeriodicCheckBox.Size = new System.Drawing.Size(98, 17);
            this.gridPeriodicCheckBox.TabIndex = 25;
            this.gridPeriodicCheckBox.Text = "Periodic Check";
            this.gridPeriodicCheckBox.UseVisualStyleBackColor = true;
            this.gridPeriodicCheckBox.CheckedChanged += new System.EventHandler(this.gridPeriodicCheckBox_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WidthLbl.Location = new System.Drawing.Point(6, 27);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(42, 16);
            this.WidthLbl.TabIndex = 26;
            this.WidthLbl.Text = "Width";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightLbl.Location = new System.Drawing.Point(6, 54);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(47, 16);
            this.HeightLbl.TabIndex = 27;
            this.HeightLbl.Text = "Height";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WidthLbl);
            this.groupBox1.Controls.Add(this.HeightLbl);
            this.groupBox1.Controls.Add(this.BoardWidthNumericUpDown);
            this.groupBox1.Controls.Add(this.BoardHeightNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 80);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Board Size";
            // 
            // ParametersGB
            // 
            this.ParametersGB.Controls.Add(this.ChoseMethodLbl);
            this.ParametersGB.Controls.Add(this.gridPeriodicCheckBox);
            this.ParametersGB.Controls.Add(this.caGrainsNumericUpDown);
            this.ParametersGB.Controls.Add(this.caAddRandomGrainsButton);
            this.ParametersGB.Controls.Add(this.caNeighborhoodComboBox);
            this.ParametersGB.Location = new System.Drawing.Point(12, 12);
            this.ParametersGB.Name = "ParametersGB";
            this.ParametersGB.Size = new System.Drawing.Size(200, 115);
            this.ParametersGB.TabIndex = 29;
            this.ParametersGB.TabStop = false;
            this.ParametersGB.Text = "Parameters";
            // 
            // ChoseMethodLbl
            // 
            this.ChoseMethodLbl.AutoSize = true;
            this.ChoseMethodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChoseMethodLbl.Location = new System.Drawing.Point(88, 50);
            this.ChoseMethodLbl.Name = "ChoseMethodLbl";
            this.ChoseMethodLbl.Size = new System.Drawing.Size(95, 16);
            this.ChoseMethodLbl.TabIndex = 30;
            this.ChoseMethodLbl.Text = "Chose Method";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 379);
            this.Controls.Add(this.ParametersGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.caSimulateButton);
            this.Controls.Add(this.Board);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ParametersGB.ResumeLayout(false);
            this.ParametersGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Board;
        private System.Windows.Forms.NumericUpDown BoardWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown BoardHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown caGrainsNumericUpDown;
        private System.Windows.Forms.ComboBox caNeighborhoodComboBox;
        private System.Windows.Forms.Button caAddRandomGrainsButton;
        private System.Windows.Forms.Button caSimulateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.CheckBox gridPeriodicCheckBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ParametersGB;
        private System.Windows.Forms.Label ChoseMethodLbl;
    }
}

