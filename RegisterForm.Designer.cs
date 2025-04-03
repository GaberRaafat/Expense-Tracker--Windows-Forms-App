namespace ITI_EF_WorkShop
{
    partial class Register_Form
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            newusernametext = new TextBox();
            newincometext = new TextBox();
            passwordtext = new TextBox();
            Signupbuttom = new Button();
            label1 = new Label();
            button1 = new Button();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(39, 110);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter User Name ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(39, 172);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(39, 240);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Enter Income ";
            // 
            // newusernametext
            // 
            newusernametext.Location = new Point(181, 107);
            newusernametext.Name = "newusernametext";
            newusernametext.Size = new Size(100, 23);
            newusernametext.TabIndex = 4;
            newusernametext.TextChanged += newusernametext_TextChanged;
            // 
            // newincometext
            // 
            newincometext.Location = new Point(181, 232);
            newincometext.Name = "newincometext";
            newincometext.Size = new Size(100, 23);
            newincometext.TabIndex = 5;
            newincometext.TextChanged += newincometext_TextChanged;
            // 
            // passwordtext
            // 
            passwordtext.Location = new Point(181, 169);
            passwordtext.Name = "passwordtext";
            passwordtext.Size = new Size(100, 23);
            passwordtext.TabIndex = 6;
            passwordtext.TextChanged += passwordtext_TextChanged;
            // 
            // Signupbuttom
            // 
            Signupbuttom.Location = new Point(123, 288);
            Signupbuttom.Name = "Signupbuttom";
            Signupbuttom.Size = new Size(75, 23);
            Signupbuttom.TabIndex = 7;
            Signupbuttom.Text = "Sign Up";
            Signupbuttom.UseVisualStyleBackColor = true;
            Signupbuttom.Click += Signupbuttom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(289, 19);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 8;
            label1.Text = "Create Your Account ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(607, 298);
            button1.Name = "button1";
            button1.Size = new Size(130, 32);
            button1.TabIndex = 9;
            button1.Text = "Back To Main";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(298, 107);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 12;
            label8.Text = "*";
            label8.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(298, 169);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 13;
            label6.Text = "*";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(298, 232);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 14;
            label7.Text = "*";
            label7.Visible = false;
            // 
            // Register_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 370);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Signupbuttom);
            Controls.Add(passwordtext);
            Controls.Add(newincometext);
            Controls.Add(newusernametext);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Register_Form";
            Text = "Register_Form";
            Load += Register_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox newusernametext;
        private Label label5;
        private TextBox newincometext;
        private TextBox passwordtext;
        private Button Signupbuttom;
        private Label label1;
        private Button button1;
        private Label label8;
        private Label label6;
        private Label label7;
    }
}