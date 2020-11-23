namespace WindowsFormsApp2
{
    partial class ГлавноеМеню
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BecomeARunner = new System.Windows.Forms.Button();
            this.BecomeASponsor = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.ДоСтарата = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ДатаСейчас = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BecomeARunner
            // 
            this.BecomeARunner.AutoSize = true;
            this.BecomeARunner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BecomeARunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BecomeARunner.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BecomeARunner.Location = new System.Drawing.Point(250, 120);
            this.BecomeARunner.Name = "BecomeARunner";
            this.BecomeARunner.Size = new System.Drawing.Size(300, 65);
            this.BecomeARunner.TabIndex = 0;
            this.BecomeARunner.Text = "Я хочу стать бегуном";
            this.BecomeARunner.UseVisualStyleBackColor = false;
            this.BecomeARunner.Click += new System.EventHandler(this.BecomeARunner_Click);
            // 
            // BecomeASponsor
            // 
            this.BecomeASponsor.AutoSize = true;
            this.BecomeASponsor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BecomeASponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BecomeASponsor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BecomeASponsor.Location = new System.Drawing.Point(250, 200);
            this.BecomeASponsor.Name = "BecomeASponsor";
            this.BecomeASponsor.Size = new System.Drawing.Size(300, 65);
            this.BecomeASponsor.TabIndex = 1;
            this.BecomeASponsor.Text = "Я хочу стать спонсором бегуна";
            this.BecomeASponsor.UseVisualStyleBackColor = false;
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.BackColor = System.Drawing.SystemColors.ControlLight;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About.Location = new System.Drawing.Point(250, 280);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(300, 65);
            this.About.TabIndex = 2;
            this.About.Text = "Я хочу узнать больше о событии";
            this.About.UseVisualStyleBackColor = false;
            // 
            // ДоСтарата
            // 
            this.ДоСтарата.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ДоСтарата.AutoSize = true;
            this.ДоСтарата.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ДоСтарата.ForeColor = System.Drawing.SystemColors.Window;
            this.ДоСтарата.Location = new System.Drawing.Point(44, 0);
            this.ДоСтарата.Name = "ДоСтарата";
            this.ДоСтарата.Size = new System.Drawing.Size(711, 31);
            this.ДоСтарата.TabIndex = 3;
            this.ДоСтарата.Text = "{0} дней {1} часов и {2} минут, до старта марафона!";
            this.ДоСтарата.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ДатаСейчас
            // 
            this.ДатаСейчас.AutoSize = true;
            this.ДатаСейчас.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ДатаСейчас.ForeColor = System.Drawing.SystemColors.Window;
            this.ДатаСейчас.Location = new System.Drawing.Point(312, 72);
            this.ДатаСейчас.Name = "ДатаСейчас";
            this.ДатаСейчас.Size = new System.Drawing.Size(175, 19);
            this.ДатаСейчас.TabIndex = 4;
            this.ДатаСейчас.Text = "день недели дд мм гггг";
            this.ДатаСейчас.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ДатаСейчас);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 99);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(338, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Москва, Россия";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(199, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "MARATHON SKILLS 2020";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.ДоСтарата);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 41);
            this.panel2.TabIndex = 6;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(649, 353);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(123, 41);
            this.Login.TabIndex = 7;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // ГлавноеМеню
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.About);
            this.Controls.Add(this.BecomeASponsor);
            this.Controls.Add(this.BecomeARunner);
            this.Name = "ГлавноеМеню";
            this.Text = "Marathon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BecomeARunner;
        private System.Windows.Forms.Button BecomeASponsor;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Label ДоСтарата;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ДатаСейчас;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Login;
    }
}

