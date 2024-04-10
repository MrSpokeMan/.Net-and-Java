namespace WinFormsApp2
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
            TextBoxDisplayData = new TextBox();
            DownloadButton = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // TextBoxDisplayData
            // 
            TextBoxDisplayData.AcceptsReturn = true;
            TextBoxDisplayData.Location = new Point(190, 339);
            TextBoxDisplayData.Multiline = true;
            TextBoxDisplayData.Name = "TextBoxDisplayData";
            TextBoxDisplayData.ReadOnly = true;
            TextBoxDisplayData.ScrollBars = ScrollBars.Vertical;
            TextBoxDisplayData.Size = new Size(232, 99);
            TextBoxDisplayData.TabIndex = 0;
            // 
            // DownloadButton
            // 
            DownloadButton.Location = new Point(12, 12);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(103, 54);
            DownloadButton.TabIndex = 1;
            DownloadButton.Text = "Download";
            DownloadButton.UseVisualStyleBackColor = true;
            DownloadButton.Click += DownloadButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 37);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(450, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(450, 96);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 96);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(232, 40);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 6;
            label1.Text = "WALUTA DO PRZELICZENIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 78);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 7;
            label2.Text = "WALUTA PRZELICZANA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 309);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 8;
            label3.Text = "WYNIK";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(446, 279);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(125, 75);
            calculateButton.TabIndex = 9;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculateButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(DownloadButton);
            Controls.Add(TextBoxDisplayData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxDisplayData;
        private Button DownloadButton;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button calculateButton;
    }
}
