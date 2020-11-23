namespace WindowsFormsApp2
{
    partial class LoginOrNot
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ДоСтарата = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.MoveToLogin = new System.Windows.Forms.Button();
            this.NewMember = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.ДоСтарата);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 43);
            this.panel2.TabIndex = 11;
            // 
            // ДоСтарата
            // 
            this.ДоСтарата.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ДоСтарата.AutoSize = true;
            this.ДоСтарата.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ДоСтарата.ForeColor = System.Drawing.SystemColors.Window;
            this.ДоСтарата.Location = new System.Drawing.Point(37, 6);
            this.ДоСтарата.Name = "ДоСтарата";
            this.ДоСтарата.Size = new System.Drawing.Size(711, 31);
            this.ДоСтарата.TabIndex = 4;
            this.ДоСтарата.Text = "{0} дней {1} часов и {2} минут, до старта марафона!";
            this.ДоСтарата.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 40);
            this.panel1.TabIndex = 12;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(5, 5);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(62, 30);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(199, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "MARATHON SKILLS 2020";
            // 
            // button_login
            // 
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_login.Location = new System.Drawing.Point(649, 351);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(123, 41);
            this.button_login.TabIndex = 13;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button4_Click);
            // 
            // MoveToLogin
            // 
            this.MoveToLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MoveToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveToLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveToLogin.Location = new System.Drawing.Point(250, 120);
            this.MoveToLogin.Name = "MoveToLogin";
            this.MoveToLogin.Size = new System.Drawing.Size(300, 65);
            this.MoveToLogin.TabIndex = 14;
            this.MoveToLogin.Text = "Я участвовал ранее";
            this.MoveToLogin.UseVisualStyleBackColor = false;
            this.MoveToLogin.Click += new System.EventHandler(this.MoveToLogin_Click);
            // 
            // NewMember
            // 
            this.NewMember.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewMember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMember.Location = new System.Drawing.Point(250, 200);
            this.NewMember.Name = "NewMember";
            this.NewMember.Size = new System.Drawing.Size(300, 65);
            this.NewMember.TabIndex = 15;
            this.NewMember.Text = "Я новый участник";
            this.NewMember.UseVisualStyleBackColor = false;
            this.NewMember.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginOrNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.NewMember);
            this.Controls.Add(this.MoveToLogin);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "LoginOrNot";
            this.Text = "АвторизацияУчаствовалЛиУже";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label ДоСтарата;
        private System.Windows.Forms.Button MoveToLogin;
        private System.Windows.Forms.Button NewMember;
        private System.Windows.Forms.Timer timer1;
    }
}