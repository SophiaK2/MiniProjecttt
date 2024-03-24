namespace MiniProjecttt
{
    partial class Form5
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
            button1 = new Button();
            available = new ComboBox();
            locationn = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            locationID = new ComboBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(249, 194);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // available
            // 
            available.FormattingEnabled = true;
            available.Items.AddRange(new object[] { "available", "occupied" });
            available.Location = new Point(375, 101);
            available.Name = "available";
            available.Size = new Size(182, 33);
            available.TabIndex = 1;
            // 
            // locationn
            // 
            locationn.FormattingEnabled = true;
            locationn.Items.AddRange(new object[] { "right to the fountain", "near Ostrander", "behind Ostrander", "Reception", "left of Sanders", "right to Sanders", "Greenfield", "Near the dorms", "7th Building", "Abbot'", "Djerassi'", "5th building" });
            locationn.Location = new Point(207, 101);
            locationn.Name = "locationn";
            locationn.Size = new Size(166, 33);
            locationn.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 155);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 3;
            label1.Text = "See whether it is available";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(533, 121);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LemonChiffon;
            label2.Location = new Point(219, 42);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 5;
            label2.Text = "Choose your spot";
            // 
            // button2
            // 
            button2.Location = new Point(249, 375);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Reserve";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(249, 462);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "Finalize";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // locationID
            // 
            locationID.FormattingEnabled = true;
            locationID.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" });
            locationID.Location = new Point(24, 101);
            locationID.Name = "locationID";
            locationID.Size = new Size(182, 33);
            locationID.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(249, 415);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 9;
            button4.Text = "Check";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.s423806983783101156_p238_i1_w1125;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(599, 523);
            Controls.Add(button4);
            Controls.Add(locationID);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(locationn);
            Controls.Add(available);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox available;
        private ComboBox locationn;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button2;
        private Button button3;
        private ComboBox locationID;
        private Button button4;
    }
}