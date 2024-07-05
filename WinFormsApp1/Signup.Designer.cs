namespace WinFormsApp1
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            signUpButton = new Button();
            emailTextBox = new RichTextBox();
            passwordTextBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            label4 = new Label();
            navigateToLoginPageButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(496, 67);
            label1.Name = "label1";
            label1.Size = new Size(185, 23);
            label1.TabIndex = 0;
            label1.Text = "Create an account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 7F);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(463, 119);
            label2.Name = "label2";
            label2.Size = new Size(39, 13);
            label2.TabIndex = 1;
            label2.Text = "Email*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 7F);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(463, 181);
            label3.Name = "label3";
            label3.Size = new Size(54, 13);
            label3.TabIndex = 3;
            label3.Text = "Password*";
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.DeepSkyBlue;
            signUpButton.BackgroundImageLayout = ImageLayout.None;
            signUpButton.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            signUpButton.FlatAppearance.MouseOverBackColor = Color.Blue;
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpButton.ForeColor = SystemColors.ControlLightLight;
            signUpButton.Location = new Point(463, 246);
            signUpButton.Margin = new Padding(0);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(259, 30);
            signUpButton.TabIndex = 5;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.ButtonFace;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Location = new Point(463, 135);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(259, 29);
            emailTextBox.TabIndex = 6;
            emailTextBox.Text = "";

            
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.ButtonFace;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Location = new Point(463, 197);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(259, 29);
            passwordTextBox.TabIndex = 7;
            passwordTextBox.Text = "";
            
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 451);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.Location = new Point(476, 290);
            label4.Name = "label4";
            label4.Size = new Size(165, 14);
            label4.TabIndex = 9;
            label4.Text = "Already got an account?";
            // 
            // navigateToLoginPageButton
            // 
            navigateToLoginPageButton.BackColor = Color.Ivory;
            navigateToLoginPageButton.FlatAppearance.BorderColor = Color.White;
            navigateToLoginPageButton.FlatAppearance.BorderSize = 0;
            navigateToLoginPageButton.FlatStyle = FlatStyle.Flat;
            navigateToLoginPageButton.Font = new Font("Verdana", 9F, FontStyle.Bold);
            navigateToLoginPageButton.ForeColor = Color.DeepSkyBlue;
            navigateToLoginPageButton.Location = new Point(647, 286);
            navigateToLoginPageButton.Name = "navigateToLoginPageButton";
            navigateToLoginPageButton.Size = new Size(75, 23);
            navigateToLoginPageButton.TabIndex = 10;
            navigateToLoginPageButton.Text = "Log in";
            navigateToLoginPageButton.UseVisualStyleBackColor = false;
            navigateToLoginPageButton.Click += navigateToLoginPageButton_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(navigateToLoginPageButton);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(signUpButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button signUpButton;
        private RichTextBox emailTextBox;
        private RichTextBox passwordTextBox;
        private PictureBox pictureBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label4;
        private Button navigateToLoginPageButton;
    }
}
