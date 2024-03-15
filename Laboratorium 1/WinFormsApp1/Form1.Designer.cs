namespace WinFormsApp1
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
            NumberOfItems = new TextBox();
            random = new TextBox();
            volume = new TextBox();
            button1 = new Button();
            number_of_items = new Label();
            seed = new Label();
            capacity = new Label();
            ResultsTextBox = new TextBox();
            result_label = new Label();
            InstanceTextBox = new TextBox();
            InstanceLabel = new Label();
            SuspendLayout();
            // 
            // NumberOfItems
            // 
            NumberOfItems.Location = new Point(36, 38);
            NumberOfItems.Name = "NumberOfItems";
            NumberOfItems.Size = new Size(100, 23);
            NumberOfItems.TabIndex = 0;
            NumberOfItems.TextChanged += NumberOfItems_TextChanged;
            // 
            // random
            // 
            random.Location = new Point(36, 102);
            random.Name = "random";
            random.Size = new Size(100, 23);
            random.TabIndex = 1;
            // 
            // volume
            // 
            volume.Location = new Point(36, 176);
            volume.Name = "volume";
            volume.Size = new Size(100, 23);
            volume.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(36, 221);
            button1.Name = "button1";
            button1.Size = new Size(100, 47);
            button1.TabIndex = 3;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // number_of_items
            // 
            number_of_items.AutoSize = true;
            number_of_items.Location = new Point(36, 20);
            number_of_items.Name = "number_of_items";
            number_of_items.Size = new Size(99, 15);
            number_of_items.TabIndex = 4;
            number_of_items.Text = "Number Of Items";
            number_of_items.Click += label1_Click;
            // 
            // seed
            // 
            seed.AutoSize = true;
            seed.Location = new Point(36, 84);
            seed.Name = "seed";
            seed.Size = new Size(32, 15);
            seed.TabIndex = 5;
            seed.Text = "Seed";
            // 
            // capacity
            // 
            capacity.AutoSize = true;
            capacity.Location = new Point(36, 158);
            capacity.Name = "capacity";
            capacity.Size = new Size(53, 15);
            capacity.TabIndex = 6;
            capacity.Text = "Capacity";
            // 
            // ResultsTextBox
            // 
            ResultsTextBox.Location = new Point(494, 60);
            ResultsTextBox.Multiline = true;
            ResultsTextBox.Name = "ResultsTextBox";
            ResultsTextBox.ReadOnly = true;
            ResultsTextBox.ScrollBars = ScrollBars.Vertical;
            ResultsTextBox.Size = new Size(271, 378);
            ResultsTextBox.TabIndex = 7;
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.Location = new Point(494, 42);
            result_label.Name = "result_label";
            result_label.Size = new Size(44, 15);
            result_label.TabIndex = 8;
            result_label.Text = "Results";
            result_label.Click += label1_Click_1;
            // 
            // InstanceTextBox
            // 
            InstanceTextBox.Location = new Point(172, 60);
            InstanceTextBox.Multiline = true;
            InstanceTextBox.Name = "InstanceTextBox";
            InstanceTextBox.ReadOnly = true;
            InstanceTextBox.ScrollBars = ScrollBars.Vertical;
            InstanceTextBox.Size = new Size(271, 378);
            InstanceTextBox.TabIndex = 9;
            InstanceTextBox.TextChanged += InstanceTextBox_TextChanged;
            // 
            // InstanceLabel
            // 
            InstanceLabel.AutoSize = true;
            InstanceLabel.Location = new Point(172, 41);
            InstanceLabel.Name = "InstanceLabel";
            InstanceLabel.Size = new Size(51, 15);
            InstanceLabel.TabIndex = 10;
            InstanceLabel.Text = "Instance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InstanceLabel);
            Controls.Add(InstanceTextBox);
            Controls.Add(result_label);
            Controls.Add(ResultsTextBox);
            Controls.Add(capacity);
            Controls.Add(seed);
            Controls.Add(number_of_items);
            Controls.Add(button1);
            Controls.Add(volume);
            Controls.Add(random);
            Controls.Add(NumberOfItems);
            Name = "Form1";
            Text = "Backpack";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumberOfItems;
        private TextBox random;
        private TextBox volume;
        private Button button1;
        private Label number_of_items;
        private Label seed;
        private Label capacity;
        private TextBox ResultsTextBox;
        private Label result_label;
        private TextBox InstanceTextBox;
        private Label InstanceLabel;
    }
}
