namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kolomNama1 = new System.Windows.Forms.TextBox();
            this.kolomNama2 = new System.Windows.Forms.TextBox();
            this.kolomNomor = new System.Windows.Forms.TextBox();
            this.btnTambahNo = new System.Windows.Forms.Button();
            this.listNomor = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Awal ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Akhir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nomor HP : ";
            // 
            // kolomNama1
            // 
            this.kolomNama1.Location = new System.Drawing.Point(144, 24);
            this.kolomNama1.Name = "kolomNama1";
            this.kolomNama1.Size = new System.Drawing.Size(100, 20);
            this.kolomNama1.TabIndex = 3;
            // 
            // kolomNama2
            // 
            this.kolomNama2.Location = new System.Drawing.Point(144, 63);
            this.kolomNama2.Name = "kolomNama2";
            this.kolomNama2.Size = new System.Drawing.Size(100, 20);
            this.kolomNama2.TabIndex = 4;
            // 
            // kolomNomor
            // 
            this.kolomNomor.Location = new System.Drawing.Point(144, 108);
            this.kolomNomor.Name = "kolomNomor";
            this.kolomNomor.Size = new System.Drawing.Size(100, 20);
            this.kolomNomor.TabIndex = 5;
            // 
            // btnTambahNo
            // 
            this.btnTambahNo.Location = new System.Drawing.Point(45, 144);
            this.btnTambahNo.Name = "btnTambahNo";
            this.btnTambahNo.Size = new System.Drawing.Size(75, 41);
            this.btnTambahNo.TabIndex = 6;
            this.btnTambahNo.Text = "Tambahkan Nomor";
            this.btnTambahNo.UseVisualStyleBackColor = true;
            this.btnTambahNo.Click += new System.EventHandler(this.BtnTambahNo_Click);
            // 
            // listNomor
            // 
            this.listNomor.FormattingEnabled = true;
            this.listNomor.Location = new System.Drawing.Point(327, 24);
            this.listNomor.Name = "listNomor";
            this.listNomor.Size = new System.Drawing.Size(166, 186);
            this.listNomor.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(171, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 41);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 271);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.listNomor);
            this.Controls.Add(this.btnTambahNo);
            this.Controls.Add(this.kolomNomor);
            this.Controls.Add(this.kolomNama2);
            this.Controls.Add(this.kolomNama1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kolomNama1;
        private System.Windows.Forms.TextBox kolomNama2;
        private System.Windows.Forms.TextBox kolomNomor;
        private System.Windows.Forms.Button btnTambahNo;
        private System.Windows.Forms.ListBox listNomor;
        private System.Windows.Forms.Button btnReset;
    }
}

