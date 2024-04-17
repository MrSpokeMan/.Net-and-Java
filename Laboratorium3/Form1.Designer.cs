namespace Laboratorium3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMatrixRow1 = new TextBox();
            textBoxMatrixColumn1 = new TextBox();
            textBoxMatrixRow2 = new TextBox();
            textBoxMatrixColumn2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxMatrix1 = new TextBox();
            textBoxMatrix2 = new TextBox();
            textBoxMatrixResult = new TextBox();
            buttonCalculate = new Button();
            buttonMatrixGenerate = new Button();
            textBoxThreads = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxMatrixRow1
            // 
            textBoxMatrixRow1.Location = new Point(12, 40);
            textBoxMatrixRow1.Name = "textBoxMatrixRow1";
            textBoxMatrixRow1.Size = new Size(100, 23);
            textBoxMatrixRow1.TabIndex = 0;
            textBoxMatrixRow1.Text = "Rząd";
            // 
            // textBoxMatrixColumn1
            // 
            textBoxMatrixColumn1.Location = new Point(12, 78);
            textBoxMatrixColumn1.Name = "textBoxMatrixColumn1";
            textBoxMatrixColumn1.Size = new Size(100, 23);
            textBoxMatrixColumn1.TabIndex = 1;
            textBoxMatrixColumn1.Text = "Kolumna";
            // 
            // textBoxMatrixRow2
            // 
            textBoxMatrixRow2.Location = new Point(12, 148);
            textBoxMatrixRow2.Name = "textBoxMatrixRow2";
            textBoxMatrixRow2.Size = new Size(100, 23);
            textBoxMatrixRow2.TabIndex = 2;
            textBoxMatrixRow2.Text = "Rząd";
            // 
            // textBoxMatrixColumn2
            // 
            textBoxMatrixColumn2.Location = new Point(12, 188);
            textBoxMatrixColumn2.Name = "textBoxMatrixColumn2";
            textBoxMatrixColumn2.Size = new Size(100, 23);
            textBoxMatrixColumn2.TabIndex = 3;
            textBoxMatrixColumn2.Text = "Kolumna";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 4;
            label1.Text = "Rozmiar macierzy 1 ( n x m)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 5;
            label2.Text = "Rozmiar macierzy 2 ( n x m)";
            // 
            // textBoxMatrix1
            // 
            textBoxMatrix1.Location = new Point(213, 22);
            textBoxMatrix1.Multiline = true;
            textBoxMatrix1.Name = "textBoxMatrix1";
            textBoxMatrix1.ReadOnly = true;
            textBoxMatrix1.ScrollBars = ScrollBars.Both;
            textBoxMatrix1.Size = new Size(269, 189);
            textBoxMatrix1.TabIndex = 6;
            // 
            // textBoxMatrix2
            // 
            textBoxMatrix2.Location = new Point(527, 22);
            textBoxMatrix2.Multiline = true;
            textBoxMatrix2.Name = "textBoxMatrix2";
            textBoxMatrix2.ReadOnly = true;
            textBoxMatrix2.ScrollBars = ScrollBars.Both;
            textBoxMatrix2.Size = new Size(261, 189);
            textBoxMatrix2.TabIndex = 7;
            // 
            // textBoxMatrixResult
            // 
            textBoxMatrixResult.Location = new Point(213, 217);
            textBoxMatrixResult.Multiline = true;
            textBoxMatrixResult.Name = "textBoxMatrixResult";
            textBoxMatrixResult.ReadOnly = true;
            textBoxMatrixResult.ScrollBars = ScrollBars.Both;
            textBoxMatrixResult.Size = new Size(269, 199);
            textBoxMatrixResult.TabIndex = 8;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(12, 358);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 9;
            buttonCalculate.Text = "Licz";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonMatrixGenerate
            // 
            buttonMatrixGenerate.Location = new Point(12, 317);
            buttonMatrixGenerate.Name = "buttonMatrixGenerate";
            buttonMatrixGenerate.Size = new Size(75, 23);
            buttonMatrixGenerate.TabIndex = 10;
            buttonMatrixGenerate.Text = "Generuj";
            buttonMatrixGenerate.UseVisualStyleBackColor = true;
            buttonMatrixGenerate.Click += buttonMatrixGenerate_Click;
            // 
            // textBoxThreads
            // 
            textBoxThreads.Location = new Point(12, 258);
            textBoxThreads.Name = "textBoxThreads";
            textBoxThreads.Size = new Size(100, 23);
            textBoxThreads.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 240);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 12;
            label3.Text = "Ilość wątków";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBoxThreads);
            Controls.Add(buttonMatrixGenerate);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxMatrixResult);
            Controls.Add(textBoxMatrix2);
            Controls.Add(textBoxMatrix1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxMatrixColumn2);
            Controls.Add(textBoxMatrixRow2);
            Controls.Add(textBoxMatrixColumn1);
            Controls.Add(textBoxMatrixRow1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMatrixRow1;
        private TextBox textBoxMatrixColumn1;
        private TextBox textBoxMatrixRow2;
        private TextBox textBoxMatrixColumn2;
        private Label label1;
        private Label label2;
        private TextBox textBoxMatrix1;
        private TextBox textBoxMatrix2;
        private TextBox textBoxMatrixResult;
        private Button buttonCalculate;
        private Button buttonMatrixGenerate;
        private TextBox textBoxThreads;
        private Label label3;
    }
}
