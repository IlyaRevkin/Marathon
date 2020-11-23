namespace WindowsFormsApp2
{
    partial class MenuAdmin
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Items = new System.Windows.Forms.Button();
            this.Chairty = new System.Windows.Forms.Button();
            this.Volunteers = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
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
            this.LogOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogOut.Location = new System.Drawing.Point(717, 5);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(62, 30);
            this.LogOut.TabIndex = 20;
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
            this.label1.TabIndex = 21;
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
            this.Back.TabIndex = 22;
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
            this.ДоСтарата.TabIndex = 7;
            this.ДоСтарата.Text = "{0} дней {1} часов и {2} минут, до старта марафона!";
            this.ДоСтарата.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(305, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Меню администратора";
            // 
            // Items
            // 
            this.Items.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Items.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Items.Location = new System.Drawing.Point(415, 200);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(300, 65);
            this.Items.TabIndex = 13;
            this.Items.Text = "Инвентарь";
            this.Items.UseVisualStyleBackColor = false;
            // 
            // Chairty
            // 
            this.Chairty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Chairty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chairty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chairty.Location = new System.Drawing.Point(75, 200);
            this.Chairty.Name = "Chairty";
            this.Chairty.Size = new System.Drawing.Size(300, 65);
            this.Chairty.TabIndex = 12;
            this.Chairty.Text = "Благотворительные \r\nорганизации";
            this.Chairty.UseVisualStyleBackColor = false;
            // 
            // Volunteers
            // 
            this.Volunteers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Volunteers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volunteers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Volunteers.Location = new System.Drawing.Point(415, 110);
            this.Volunteers.Name = "Volunteers";
            this.Volunteers.Size = new System.Drawing.Size(300, 65);
            this.Volunteers.TabIndex = 11;
            this.Volunteers.Text = "Волонтёры";
            this.Volunteers.UseVisualStyleBackColor = false;
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Users.Location = new System.Drawing.Point(75, 110);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(300, 65);
            this.Users.TabIndex = 10;
            this.Users.Text = "Пользователи";
            this.Users.UseVisualStyleBackColor = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.Chairty);
            this.Controls.Add(this.Volunteers);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuAdmin";
            this.Text = "AdminMenu";
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
        private System.Windows.Forms.Label ДоСтарата;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Items;
        private System.Windows.Forms.Button Chairty;
        private System.Windows.Forms.Button Volunteers;
        private System.Windows.Forms.Button Users;
    }
}