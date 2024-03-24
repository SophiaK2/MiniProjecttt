namespace MiniProjecttt
{
    partial class Form2
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
            label1 = new Label();
            username = new TextBox();
            phone = new TextBox();
            passwordd = new TextBox();
            email = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Rage Italic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(198, 42);
            label1.Name = "label1";
            label1.Size = new Size(335, 30);
            label1.TabIndex = 0;
            label1.Text = "Thank you for choosing to participate";
            // 
            // username
            // 
            username.Location = new Point(269, 110);
            username.Name = "username";
            username.PlaceholderText = "name";
            username.Size = new Size(150, 31);
            username.TabIndex = 1;
            username.Validating += username_Validating;
            // 
            // phone
            // 
            phone.Location = new Point(269, 258);
            phone.Name = "phone";
            phone.PlaceholderText = "phone number";
            phone.Size = new Size(150, 31);
            phone.TabIndex = 2;
            phone.Validating += phone_Validating;
            // 
            // passwordd
            // 
            passwordd.Location = new Point(269, 210);
            passwordd.Name = "passwordd";
            passwordd.PasswordChar = '*';
            passwordd.PlaceholderText = "password";
            passwordd.Size = new Size(150, 31);
            passwordd.TabIndex = 3;
            passwordd.Validating += passwordd_Validating;
            // 
            // email
            // 
            email.Location = new Point(269, 159);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(150, 31);
            email.TabIndex = 4;
            email.Validating += email_Validating;
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.Location = new Point(243, 335);
            button1.Name = "button1";
            button1.Size = new Size(219, 34);
            button1.TabIndex = 5;
            button1.Text = "Officially a contributor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.abf70c52f5ba21744f14d41a8421cb8f;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 424);
            Controls.Add(button1);
            Controls.Add(email);
            Controls.Add(passwordd);
            Controls.Add(phone);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox username;
        private TextBox phone;
        private TextBox passwordd;
        private TextBox email;
        private Button button1;
    }
}