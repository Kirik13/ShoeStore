namespace ShoeStore
{
    partial class Sales
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
            this.label5 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Skidka = new System.Windows.Forms.TextBox();
            this.Kol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NamTV = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(437, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 66);
            this.label5.TabIndex = 88;
            this.label5.Text = "Дата";
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data.Location = new System.Drawing.Point(639, 507);
            this.Data.Multiline = true;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(426, 66);
            this.Data.TabIndex = 87;
            this.Data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Data_KeyPress);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Trebuchet MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(51, 58);
            this.back.TabIndex = 86;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Trebuchet MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Add.Location = new System.Drawing.Point(512, 618);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(217, 71);
            this.Add.TabIndex = 85;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(260, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 66);
            this.label4.TabIndex = 84;
            this.label4.Text = "Количество ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(378, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 66);
            this.label3.TabIndex = 83;
            this.label3.Text = "Скидка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 66);
            this.label2.TabIndex = 82;
            this.label2.Text = "Наименование товара";
            // 
            // Skidka
            // 
            this.Skidka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Skidka.Location = new System.Drawing.Point(639, 401);
            this.Skidka.Multiline = true;
            this.Skidka.Name = "Skidka";
            this.Skidka.Size = new System.Drawing.Size(426, 66);
            this.Skidka.TabIndex = 81;
            this.Skidka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Skidka_KeyPress);
            // 
            // Kol
            // 
            this.Kol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kol.Location = new System.Drawing.Point(639, 276);
            this.Kol.Multiline = true;
            this.Kol.Name = "Kol";
            this.Kol.Size = new System.Drawing.Size(426, 66);
            this.Kol.TabIndex = 80;
            this.Kol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kol_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(501, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 66);
            this.label1.TabIndex = 78;
            this.label1.Text = "Продажи:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NamTV
            // 
            this.NamTV.FormattingEnabled = true;
            this.NamTV.Location = new System.Drawing.Point(639, 191);
            this.NamTV.Name = "NamTV";
            this.NamTV.Size = new System.Drawing.Size(426, 33);
            this.NamTV.TabIndex = 89;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1252, 762);
            this.Controls.Add(this.NamTV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Skidka);
            this.Controls.Add(this.Kol);
            this.Controls.Add(this.label1);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Skidka;
        private System.Windows.Forms.TextBox Kol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NamTV;
    }
}