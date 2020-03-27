namespace Tugas1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelms = new System.Windows.Forms.Label();
            this.lblAmplitudo = new System.Windows.Forms.Label();
            this.gbTinterval = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbSinyal1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblfrekuensi = new System.Windows.Forms.Label();
            this.gbSinyal2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.lblfrekuensi2 = new System.Windows.Forms.Label();
            this.lblAmplitudo2 = new System.Windows.Forms.Label();
            this.gbSinyal3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.lblfrekuensi3 = new System.Windows.Forms.Label();
            this.lblAmplitudo3 = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gbTinterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbSinyal1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.gbSinyal2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.gbSinyal3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(236, 37);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(970, 380);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(203, 44);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelms
            // 
            this.labelms.AutoSize = true;
            this.labelms.Location = new System.Drawing.Point(132, 26);
            this.labelms.Name = "labelms";
            this.labelms.Size = new System.Drawing.Size(20, 13);
            this.labelms.TabIndex = 3;
            this.labelms.Text = "ms";
            this.labelms.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblAmplitudo
            // 
            this.lblAmplitudo.AutoSize = true;
            this.lblAmplitudo.Location = new System.Drawing.Point(12, 26);
            this.lblAmplitudo.Name = "lblAmplitudo";
            this.lblAmplitudo.Size = new System.Drawing.Size(53, 13);
            this.lblAmplitudo.TabIndex = 4;
            this.lblAmplitudo.Text = "Amplitudo";
            // 
            // gbTinterval
            // 
            this.gbTinterval.Controls.Add(this.numericUpDown1);
            this.gbTinterval.Controls.Add(this.labelms);
            this.gbTinterval.Location = new System.Drawing.Point(8, 87);
            this.gbTinterval.Name = "gbTinterval";
            this.gbTinterval.Size = new System.Drawing.Size(203, 51);
            this.gbTinterval.TabIndex = 5;
            this.gbTinterval.TabStop = false;
            this.gbTinterval.Text = "Time Interval";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // gbSinyal1
            // 
            this.gbSinyal1.Controls.Add(this.numericUpDown3);
            this.gbSinyal1.Controls.Add(this.numericUpDown2);
            this.gbSinyal1.Controls.Add(this.lblfrekuensi);
            this.gbSinyal1.Controls.Add(this.lblAmplitudo);
            this.gbSinyal1.Location = new System.Drawing.Point(8, 144);
            this.gbSinyal1.Name = "gbSinyal1";
            this.gbSinyal1.Size = new System.Drawing.Size(203, 87);
            this.gbSinyal1.TabIndex = 6;
            this.gbSinyal1.TabStop = false;
            this.gbSinyal1.Text = "Sinyal 1";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(71, 49);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(71, 19);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblfrekuensi
            // 
            this.lblfrekuensi.AutoSize = true;
            this.lblfrekuensi.Location = new System.Drawing.Point(12, 56);
            this.lblfrekuensi.Name = "lblfrekuensi";
            this.lblfrekuensi.Size = new System.Drawing.Size(53, 13);
            this.lblfrekuensi.TabIndex = 3;
            this.lblfrekuensi.Text = "Frekuensi";
            // 
            // gbSinyal2
            // 
            this.gbSinyal2.Controls.Add(this.numericUpDown5);
            this.gbSinyal2.Controls.Add(this.numericUpDown4);
            this.gbSinyal2.Controls.Add(this.lblfrekuensi2);
            this.gbSinyal2.Controls.Add(this.lblAmplitudo2);
            this.gbSinyal2.Location = new System.Drawing.Point(8, 237);
            this.gbSinyal2.Name = "gbSinyal2";
            this.gbSinyal2.Size = new System.Drawing.Size(203, 87);
            this.gbSinyal2.TabIndex = 7;
            this.gbSinyal2.TabStop = false;
            this.gbSinyal2.Text = "Sinyal 2";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(71, 49);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown5.TabIndex = 8;
            this.numericUpDown5.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(71, 19);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 7;
            this.numericUpDown4.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // lblfrekuensi2
            // 
            this.lblfrekuensi2.AutoSize = true;
            this.lblfrekuensi2.Location = new System.Drawing.Point(12, 56);
            this.lblfrekuensi2.Name = "lblfrekuensi2";
            this.lblfrekuensi2.Size = new System.Drawing.Size(53, 13);
            this.lblfrekuensi2.TabIndex = 3;
            this.lblfrekuensi2.Text = "Frekuensi";
            // 
            // lblAmplitudo2
            // 
            this.lblAmplitudo2.AutoSize = true;
            this.lblAmplitudo2.Location = new System.Drawing.Point(12, 26);
            this.lblAmplitudo2.Name = "lblAmplitudo2";
            this.lblAmplitudo2.Size = new System.Drawing.Size(53, 13);
            this.lblAmplitudo2.TabIndex = 4;
            this.lblAmplitudo2.Text = "Amplitudo";
            // 
            // gbSinyal3
            // 
            this.gbSinyal3.Controls.Add(this.numericUpDown7);
            this.gbSinyal3.Controls.Add(this.numericUpDown6);
            this.gbSinyal3.Controls.Add(this.lblfrekuensi3);
            this.gbSinyal3.Controls.Add(this.lblAmplitudo3);
            this.gbSinyal3.Location = new System.Drawing.Point(8, 330);
            this.gbSinyal3.Name = "gbSinyal3";
            this.gbSinyal3.Size = new System.Drawing.Size(203, 87);
            this.gbSinyal3.TabIndex = 8;
            this.gbSinyal3.TabStop = false;
            this.gbSinyal3.Text = "Sinyal 3";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(71, 49);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown7.TabIndex = 10;
            this.numericUpDown7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(71, 19);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown6.TabIndex = 9;
            this.numericUpDown6.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lblfrekuensi3
            // 
            this.lblfrekuensi3.AutoSize = true;
            this.lblfrekuensi3.Location = new System.Drawing.Point(12, 56);
            this.lblfrekuensi3.Name = "lblfrekuensi3";
            this.lblfrekuensi3.Size = new System.Drawing.Size(53, 13);
            this.lblfrekuensi3.TabIndex = 3;
            this.lblfrekuensi3.Text = "Frekuensi";
            // 
            // lblAmplitudo3
            // 
            this.lblAmplitudo3.AutoSize = true;
            this.lblAmplitudo3.Location = new System.Drawing.Point(12, 26);
            this.lblAmplitudo3.Name = "lblAmplitudo3";
            this.lblAmplitudo3.Size = new System.Drawing.Size(53, 13);
            this.lblAmplitudo3.TabIndex = 4;
            this.lblAmplitudo3.Text = "Amplitudo";
            // 
            // txtbox
            // 
            this.txtbox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtbox.Location = new System.Drawing.Point(236, 8);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(970, 20);
            this.txtbox.TabIndex = 9;
            this.txtbox.Text = "PLOTTER";
            this.txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 427);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.gbSinyal3);
            this.Controls.Add(this.gbSinyal2);
            this.Controls.Add(this.gbSinyal1);
            this.Controls.Add(this.gbTinterval);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1/1103181018";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gbTinterval.ResumeLayout(false);
            this.gbTinterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbSinyal1.ResumeLayout(false);
            this.gbSinyal1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.gbSinyal2.ResumeLayout(false);
            this.gbSinyal2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.gbSinyal3.ResumeLayout(false);
            this.gbSinyal3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelms;
        private System.Windows.Forms.Label lblAmplitudo;
        private System.Windows.Forms.GroupBox gbTinterval;
        private System.Windows.Forms.GroupBox gbSinyal1;
        private System.Windows.Forms.Label lblfrekuensi;
        private System.Windows.Forms.GroupBox gbSinyal2;
        private System.Windows.Forms.Label lblfrekuensi2;
        private System.Windows.Forms.Label lblAmplitudo2;
        private System.Windows.Forms.GroupBox gbSinyal3;
        private System.Windows.Forms.Label lblfrekuensi3;
        private System.Windows.Forms.Label lblAmplitudo3;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
    }
}

