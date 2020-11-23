namespace WindowsFormsApp2
{
    partial class MenuRunner
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ДоСтарата = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RegistrationForMarathon = new System.Windows.Forms.Button();
            this.MyResult = new System.Windows.Forms.Button();
            this.EditProfile = new System.Windows.Forms.Button();
            this.MySponsor = new System.Windows.Forms.Button();
            this.Contacts = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 40);
            this.panel1.TabIndex = 0;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogOut.Location = new System.Drawing.Point(717, 5);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(62, 30);
            this.LogOut.TabIndex = 2;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
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
            this.label1.TabIndex = 15;
            this.label1.Text = "MARATHON SKILLS 2020";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(5, 5);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(62, 30);
            this.Back.TabIndex = 16;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.ДоСтарата);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 40);
            this.panel2.TabIndex = 1;
            // 
            // ДоСтарата
            // 
            this.ДоСтарата.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ДоСтарата.AutoSize = true;
            this.ДоСтарата.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ДоСтарата.ForeColor = System.Drawing.SystemColors.Window;
            this.ДоСтарата.Location = new System.Drawing.Point(37, 5);
            this.ДоСтарата.Name = "ДоСтарата";
            this.ДоСтарата.Size = new System.Drawing.Size(711, 31);
            this.ДоСтарата.TabIndex = 5;
            this.ДоСтарата.Text = "{0} дней {1} часов и {2} минут, до старта марафона!";
            this.ДоСтарата.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(337, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Меню бегуна";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // RegistrationForMarathon
            // 
            this.RegistrationForMarathon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RegistrationForMarathon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationForMarathon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationForMarathon.Location = new System.Drawing.Point(75, 110);
            this.RegistrationForMarathon.Name = "RegistrationForMarathon";
            this.RegistrationForMarathon.Size = new System.Drawing.Size(300, 65);
            this.RegistrationForMarathon.TabIndex = 3;
            this.RegistrationForMarathon.Text = "Регистрация на марафон";
            this.RegistrationForMarathon.UseVisualStyleBackColor = false;
            // 
            // MyResult
            // 
            this.MyResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MyResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyResult.Location = new System.Drawing.Point(415, 110);
            this.MyResult.Name = "MyResult";
            this.MyResult.Size = new System.Drawing.Size(300, 65);
            this.MyResult.TabIndex = 4;
            this.MyResult.Text = "Мой результат";
            this.MyResult.UseVisualStyleBackColor = false;
            // 
            // EditProfile
            // 
            this.EditProfile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProfile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditProfile.Location = new System.Drawing.Point(75, 200);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Size = new System.Drawing.Size(300, 65);
            this.EditProfile.TabIndex = 5;
            this.EditProfile.Text = "Редактирование профиля";
            this.EditProfile.UseVisualStyleBackColor = false;
            this.EditProfile.Click += new System.EventHandler(this.EditProfile_Click);
            // 
            // MySponsor
            // 
            this.MySponsor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MySponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MySponsor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MySponsor.Location = new System.Drawing.Point(415, 200);
            this.MySponsor.Name = "MySponsor";
            this.MySponsor.Size = new System.Drawing.Size(300, 65);
            this.MySponsor.TabIndex = 6;
            this.MySponsor.Text = "Мой спонсор";
            this.MySponsor.UseVisualStyleBackColor = false;
            // 
            // Contacts
            // 
            this.Contacts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contacts.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contacts.Location = new System.Drawing.Point(75, 290);
            this.Contacts.Name = "Contacts";
            this.Contacts.Size = new System.Drawing.Size(300, 65);
            this.Contacts.TabIndex = 7;
            this.Contacts.Text = "Контакты";
            this.Contacts.UseVisualStyleBackColor = false;
            // 
            // MenuRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.Contacts);
            this.Controls.Add(this.MySponsor);
            this.Controls.Add(this.EditProfile);
            this.Controls.Add(this.MyResult);
            this.Controls.Add(this.RegistrationForMarathon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuRunner";
            this.Text = "MenuRunner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ДоСтарата;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button RegistrationForMarathon;
        private System.Windows.Forms.Button MyResult;
        private System.Windows.Forms.Button EditProfile;
        private System.Windows.Forms.Button MySponsor;
        private System.Windows.Forms.Button Contacts;
    }
}