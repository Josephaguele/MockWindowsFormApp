namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.ButtonFace;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(446, 201);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(259, 29);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ButtonFace;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(446, 139);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(259, 29);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(446, 250);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(259, 30);
            button1.TabIndex = 11;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 7F);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(446, 185);
            label3.Name = "label3";
            label3.Size = new Size(54, 13);
            label3.TabIndex = 10;
            label3.Text = "Password*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 7F);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(446, 123);
            label2.Name = "label2";
            label2.Size = new Size(39, 13);
            label2.TabIndex = 9;
            label2.Text = "Email*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(479, 71);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 8;
            label1.Text = "Log In";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 450);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}