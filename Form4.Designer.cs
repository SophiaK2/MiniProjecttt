namespace MiniProjecttt
{
    partial class Form4
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
            people = new ComboBox();
            things = new ComboBox();
            quantity = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // people
            // 
            people.FormattingEnabled = true;
            people.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            people.Location = new Point(38, 89);
            people.Name = "people";
            people.Size = new Size(182, 33);
            people.TabIndex = 1;
            // 
            // things
            // 
            things.FormattingEnabled = true;
            things.Items.AddRange(new object[] { "tvs", "hats", "children", "creative", "textbooks", "mugs", "homey'", "clothes", "robots", "pattiserie", "food", "workshops", "dances", "karaoke", "machines" });
            things.Location = new Point(38, 187);
            things.Name = "things";
            things.Size = new Size(182, 33);
            things.TabIndex = 2;
            // 
            // quantity
            // 
            quantity.FormattingEnabled = true;
            quantity.Items.AddRange(new object[] { "45", "10", "50", "60", "65", "200", "100" });
            quantity.Location = new Point(267, 142);
            quantity.Name = "quantity";
            quantity.Size = new Size(182, 33);
            quantity.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Teal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(411, 104);
            dataGridView1.TabIndex = 4;
            dataGridView1.Validating += dataGridView1_Validating;
            // 
            // button1
            // 
            button1.Location = new Point(187, 226);
            button1.Name = "button1";
            button1.Size = new Size(260, 34);
            button1.TabIndex = 5;
            button1.Text = "Check whether possible";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tomato;
            label1.Font = new Font("Pristina", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 24);
            label1.TabIndex = 6;
            label1.Text = "Choose what matches your idea the most";
            // 
            // button2
            // 
            button2.Location = new Point(187, 397);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(473, 471);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(quantity);
            Controls.Add(things);
            Controls.Add(people);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox people;
        private ComboBox things;
        private ComboBox quantity;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}