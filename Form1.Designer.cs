namespace ITI_EF_WorkShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Usertext = new TextBox();
            Passwordtext = new TextBox();
            Loginbuttom = new Button();
            Userlabel = new Label();
            Passlabel = new Label();
            registerbuttom = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Usertext
            // 
            Usertext.Location = new Point(158, 102);
            Usertext.Name = "Usertext";
            Usertext.Size = new Size(171, 23);
            Usertext.TabIndex = 0;
            // 
            // Passwordtext
            // 
            Passwordtext.Location = new Point(158, 155);
            Passwordtext.Name = "Passwordtext";
            Passwordtext.Size = new Size(171, 23);
            Passwordtext.TabIndex = 1;
            // 
            // Loginbuttom
            // 
            Loginbuttom.BackColor = Color.FromArgb(0, 64, 64);
            Loginbuttom.BackgroundImageLayout = ImageLayout.Center;
            Loginbuttom.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbuttom.ForeColor = SystemColors.ControlLightLight;
            Loginbuttom.Location = new Point(197, 202);
            Loginbuttom.Name = "Loginbuttom";
            Loginbuttom.Size = new Size(75, 27);
            Loginbuttom.TabIndex = 2;
            Loginbuttom.Text = "Log in";
            Loginbuttom.UseVisualStyleBackColor = false;
            Loginbuttom.Click += Loginbuttom_Click;
            // 
            // Userlabel
            // 
            Userlabel.AutoSize = true;
            Userlabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Userlabel.ForeColor = SystemColors.ControlLightLight;
            Userlabel.Location = new Point(65, 102);
            Userlabel.Name = "Userlabel";
            Userlabel.Size = new Size(75, 17);
            Userlabel.TabIndex = 4;
            Userlabel.Text = "User Name";
            // 
            // Passlabel
            // 
            Passlabel.AutoSize = true;
            Passlabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passlabel.ForeColor = SystemColors.ControlLightLight;
            Passlabel.Location = new Point(65, 155);
            Passlabel.Name = "Passlabel";
            Passlabel.Size = new Size(66, 17);
            Passlabel.TabIndex = 5;
            Passlabel.Text = "Password";
            // 
            // registerbuttom
            // 
            registerbuttom.BackColor = Color.Teal;
            registerbuttom.BackgroundImageLayout = ImageLayout.Center;
            registerbuttom.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerbuttom.ForeColor = SystemColors.ControlLightLight;
            registerbuttom.Location = new Point(158, 245);
            registerbuttom.Name = "registerbuttom";
            registerbuttom.Size = new Size(171, 27);
            registerbuttom.TabIndex = 7;
            registerbuttom.Text = "Create New Account";
            registerbuttom.UseVisualStyleBackColor = false;
            registerbuttom.Click += registerbuttom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 42);
            label1.TabIndex = 8;
            label1.Text = "FinTrack";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Traditional Arabic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(158, 38);
            label2.Name = "label2";
            label2.Size = new Size(188, 26);
            label2.TabIndex = 9;
            label2.Text = "Your Money, Your Control.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(114, 245);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(343, 155);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(24, 23);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(502, 339);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registerbuttom);
            Controls.Add(Passlabel);
            Controls.Add(Userlabel);
            Controls.Add(Loginbuttom);
            Controls.Add(Passwordtext);
            Controls.Add(Usertext);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usertext;
        private TextBox Passwordtext;
        private Button Loginbuttom;
        private Label Userlabel;
        private Label Passlabel;
        private Button registerbuttom;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
    }
}
