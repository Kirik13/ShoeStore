namespace ShoeStore
{
    partial class Products
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
            this.back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tena = new System.Windows.Forms.TextBox();
            this.NameTv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KolNaSkald = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Trebuchet MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.back.Location = new System.Drawing.Point(11, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(51, 58);
            this.back.TabIndex = 75;
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
            this.Add.Location = new System.Drawing.Point(511, 618);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(217, 71);
            this.Add.TabIndex = 74;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(305, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 66);
            this.label4.TabIndex = 73;
            this.label4.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(415, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 66);
            this.label3.TabIndex = 72;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 66);
            this.label2.TabIndex = 71;
            this.label2.Text = "Наименование товара";
            // 
            // Tena
            // 
            this.Tena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tena.Location = new System.Drawing.Point(638, 401);
            this.Tena.Multiline = true;
            this.Tena.Name = "Tena";
            this.Tena.Size = new System.Drawing.Size(426, 66);
            this.Tena.TabIndex = 70;
            this.Tena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tena_KeyPress);
            // 
            // NameTv
            // 
            this.NameTv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTv.Location = new System.Drawing.Point(638, 159);
            this.NameTv.Multiline = true;
            this.NameTv.Name = "NameTv";
            this.NameTv.Size = new System.Drawing.Size(426, 66);
            this.NameTv.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(512, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 66);
            this.label1.TabIndex = 67;
            this.label1.Text = "Товары:";
            // 
            // KolNaSkald
            // 
            this.KolNaSkald.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KolNaSkald.Location = new System.Drawing.Point(638, 507);
            this.KolNaSkald.Multiline = true;
            this.KolNaSkald.Name = "KolNaSkald";
            this.KolNaSkald.Size = new System.Drawing.Size(426, 66);
            this.KolNaSkald.TabIndex = 76;
            this.KolNaSkald.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KolNaSkald_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(17, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 66);
            this.label5.TabIndex = 77;
            this.label5.Text = "Количество на складе";
            // 
            // Cat
            // 
            this.Cat.FormattingEnabled = true;
            this.Cat.Location = new System.Drawing.Point(638, 299);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(426, 33);
            this.Cat.TabIndex = 78;
            this.Cat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1252, 762);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KolNaSkald);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tena);
            this.Controls.Add(this.NameTv);
            this.Controls.Add(this.label1);
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tena;
        private System.Windows.Forms.TextBox NameTv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KolNaSkald;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cat;
    }
}