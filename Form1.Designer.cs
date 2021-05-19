
namespace ViginereCipher
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.btnDecipher = new System.Windows.Forms.Button();
            this.cbxCipherWithSpace = new System.Windows.Forms.CheckBox();
            this.tbxCipherText = new System.Windows.Forms.TextBox();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.tbxSecretKey = new System.Windows.Forms.TextBox();
            this.btnCipher = new System.Windows.Forms.Button();
            this.tbxPlainText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chrDividers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrDistance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtgwAnalyzeKasiski = new System.Windows.Forms.DataGridView();
            this.btnAnalyzeKasiski = new System.Windows.Forms.Button();
            this.tbxKasiskiCipherText = new System.Windows.Forms.TextBox();
            this.tabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrDividers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwAnalyzeKasiski)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Location = new System.Drawing.Point(0, 0);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(913, 765);
            this.tabGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnDrawGraph);
            this.tabPage1.Controls.Add(this.btnDecipher);
            this.tabPage1.Controls.Add(this.cbxCipherWithSpace);
            this.tabPage1.Controls.Add(this.tbxCipherText);
            this.tabPage1.Controls.Add(this.lblSecretKey);
            this.tabPage1.Controls.Add(this.tbxSecretKey);
            this.tabPage1.Controls.Add(this.btnCipher);
            this.tabPage1.Controls.Add(this.tbxPlainText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 739);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Viginere Cipher";
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Location = new System.Drawing.Point(742, 24);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(98, 50);
            this.btnDrawGraph.TabIndex = 7;
            this.btnDrawGraph.Text = "Draw Graph";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            // 
            // btnDecipher
            // 
            this.btnDecipher.Location = new System.Drawing.Point(452, 24);
            this.btnDecipher.Name = "btnDecipher";
            this.btnDecipher.Size = new System.Drawing.Size(98, 50);
            this.btnDecipher.TabIndex = 6;
            this.btnDecipher.Text = "Decipher";
            this.btnDecipher.UseVisualStyleBackColor = true;
            this.btnDecipher.Click += new System.EventHandler(this.btnDecipher_Click);
            // 
            // cbxCipherWithSpace
            // 
            this.cbxCipherWithSpace.AutoSize = true;
            this.cbxCipherWithSpace.Location = new System.Drawing.Point(173, 23);
            this.cbxCipherWithSpace.Name = "cbxCipherWithSpace";
            this.cbxCipherWithSpace.Size = new System.Drawing.Size(110, 17);
            this.cbxCipherWithSpace.TabIndex = 5;
            this.cbxCipherWithSpace.Text = "Cipher with space";
            this.cbxCipherWithSpace.UseVisualStyleBackColor = true;
            // 
            // tbxCipherText
            // 
            this.tbxCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCipherText.Location = new System.Drawing.Point(452, 89);
            this.tbxCipherText.MaxLength = 100000;
            this.tbxCipherText.Multiline = true;
            this.tbxCipherText.Name = "tbxCipherText";
            this.tbxCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxCipherText.Size = new System.Drawing.Size(398, 312);
            this.tbxCipherText.TabIndex = 4;
            // 
            // lblSecretKey
            // 
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Location = new System.Drawing.Point(170, 57);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(59, 13);
            this.lblSecretKey.TabIndex = 3;
            this.lblSecretKey.Text = "Secret Key";
            // 
            // tbxSecretKey
            // 
            this.tbxSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSecretKey.Location = new System.Drawing.Point(245, 54);
            this.tbxSecretKey.Name = "tbxSecretKey";
            this.tbxSecretKey.Size = new System.Drawing.Size(170, 26);
            this.tbxSecretKey.TabIndex = 2;
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(17, 23);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(97, 51);
            this.btnCipher.TabIndex = 1;
            this.btnCipher.Text = "Cipher";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // tbxPlainText
            // 
            this.tbxPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPlainText.Location = new System.Drawing.Point(17, 89);
            this.tbxPlainText.MaxLength = 100000;
            this.tbxPlainText.Multiline = true;
            this.tbxPlainText.Name = "tbxPlainText";
            this.tbxPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxPlainText.Size = new System.Drawing.Size(398, 313);
            this.tbxPlainText.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.chrDividers);
            this.tabPage2.Controls.Add(this.chrDistance);
            this.tabPage2.Controls.Add(this.dtgwAnalyzeKasiski);
            this.tabPage2.Controls.Add(this.btnAnalyzeKasiski);
            this.tabPage2.Controls.Add(this.tbxKasiskiCipherText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 739);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kasiski Analyze";
            // 
            // chrDividers
            // 
            chartArea1.Name = "ChartArea1";
            this.chrDividers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrDividers.Legends.Add(legend1);
            this.chrDividers.Location = new System.Drawing.Point(8, 504);
            this.chrDividers.Name = "chrDividers";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Possible Key Lenght";
            this.chrDividers.Series.Add(series1);
            this.chrDividers.Size = new System.Drawing.Size(877, 203);
            this.chrDividers.TabIndex = 4;
            this.chrDividers.Text = "chart1";
            // 
            // chrDistance
            // 
            chartArea2.Name = "ChartArea1";
            this.chrDistance.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrDistance.Legends.Add(legend2);
            this.chrDistance.Location = new System.Drawing.Point(8, 295);
            this.chrDistance.Name = "chrDistance";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Distance Between Offsets";
            this.chrDistance.Series.Add(series2);
            this.chrDistance.Size = new System.Drawing.Size(877, 203);
            this.chrDistance.TabIndex = 3;
            this.chrDistance.Text = "chart1";
            // 
            // dtgwAnalyzeKasiski
            // 
            this.dtgwAnalyzeKasiski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwAnalyzeKasiski.Location = new System.Drawing.Point(408, 45);
            this.dtgwAnalyzeKasiski.Name = "dtgwAnalyzeKasiski";
            this.dtgwAnalyzeKasiski.Size = new System.Drawing.Size(477, 244);
            this.dtgwAnalyzeKasiski.TabIndex = 2;
            // 
            // btnAnalyzeKasiski
            // 
            this.btnAnalyzeKasiski.Location = new System.Drawing.Point(8, 6);
            this.btnAnalyzeKasiski.Name = "btnAnalyzeKasiski";
            this.btnAnalyzeKasiski.Size = new System.Drawing.Size(117, 35);
            this.btnAnalyzeKasiski.TabIndex = 1;
            this.btnAnalyzeKasiski.Text = "Analyze Cipher Text";
            this.btnAnalyzeKasiski.UseVisualStyleBackColor = true;
            this.btnAnalyzeKasiski.Click += new System.EventHandler(this.btnAnalyzeKasiski_Click);
            // 
            // tbxKasiskiCipherText
            // 
            this.tbxKasiskiCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKasiskiCipherText.Location = new System.Drawing.Point(8, 45);
            this.tbxKasiskiCipherText.Multiline = true;
            this.tbxKasiskiCipherText.Name = "tbxKasiskiCipherText";
            this.tbxKasiskiCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxKasiskiCipherText.Size = new System.Drawing.Size(394, 244);
            this.tbxKasiskiCipherText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 761);
            this.Controls.Add(this.tabGeneral);
            this.Name = "Form1";
            this.Text = "Viginere Cipher&Kasiski Analyzer (Turkish Language)";
            this.tabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrDividers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwAnalyzeKasiski)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.TextBox tbxPlainText;
        private System.Windows.Forms.CheckBox cbxCipherWithSpace;
        private System.Windows.Forms.TextBox tbxCipherText;
        private System.Windows.Forms.Label lblSecretKey;
        private System.Windows.Forms.TextBox tbxSecretKey;
        private System.Windows.Forms.DataGridView dtgwAnalyzeKasiski;
        private System.Windows.Forms.Button btnAnalyzeKasiski;
        private System.Windows.Forms.TextBox tbxKasiskiCipherText;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.Button btnDecipher;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrDistance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrDividers;
    }
}

