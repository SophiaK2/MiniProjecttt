namespace MiniProjecttt
{
    partial class Form3
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
            username = new TextBox();
            email = new TextBox();
            passwordd = new TextBox();
            phone = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(254, 87);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(150, 31);
            username.TabIndex = 0;
            username.Validating += username_Validating;
            // 
            // email
            // 
            email.Location = new Point(254, 145);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(150, 31);
            email.TabIndex = 1;
            email.Validating += email_Validating;
            // 
            // passwordd
            // 
            passwordd.Location = new Point(254, 201);
            passwordd.Name = "passwordd";
            passwordd.PasswordChar = '$';
            passwordd.PlaceholderText = "password";
            passwordd.Size = new Size(150, 31);
            passwordd.TabIndex = 2;
            passwordd.Validating += passwordd_Validating;
            // 
            // phone
            // 
            phone.Location = new Point(254, 247);
            phone.Name = "phone";
            phone.PlaceholderText = "phone number";
            phone.Size = new Size(150, 31);
            phone.TabIndex = 3;
            phone.Validating += phone_Validating;
            // 
            // button1
            // 
            button1.Location = new Point(276, 299);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Reserve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Script MT Bold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(198, 43);
            label1.Name = "label1";
            label1.Size = new Size(276, 24);
            label1.TabIndex = 5;
            label1.Text = "Make an account. Reserve a spot!";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1234;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(662, 417);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(phone);
            Controls.Add(passwordd);
            Controls.Add(email);
            Controls.Add(username);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox email;
        private TextBox passwordd;
        private TextBox phone;
        private Button button1;
        private Label label1;
    }
}