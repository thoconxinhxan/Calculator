
namespace Calculator
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
            this.btCong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.BtTru = new System.Windows.Forms.Button();
            this.BtNhan = new System.Windows.Forms.Button();
            this.BtChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(140, 367);
            this.btCong.Margin = new System.Windows.Forms.Padding(2);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(82, 53);
            this.btCong.TabIndex = 0;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tính Toán";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(261, 147);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(244, 30);
            this.txtA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số A :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số B :";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(261, 224);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(244, 30);
            this.txtB.TabIndex = 5;
            // 
            // txtkq
            // 
            this.txtkq.AutoSize = true;
            this.txtkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkq.Location = new System.Drawing.Point(140, 295);
            this.txtkq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(119, 29);
            this.txtkq.TabIndex = 6;
            this.txtkq.Text = "Kết Quả :";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetqua.Location = new System.Drawing.Point(261, 295);
            this.txtKetqua.Margin = new System.Windows.Forms.Padding(2);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(244, 30);
            this.txtKetqua.TabIndex = 7;
            // 
            // BtTru
            // 
            this.BtTru.Location = new System.Drawing.Point(261, 367);
            this.BtTru.Margin = new System.Windows.Forms.Padding(2);
            this.BtTru.Name = "BtTru";
            this.BtTru.Size = new System.Drawing.Size(82, 53);
            this.BtTru.TabIndex = 8;
            this.BtTru.Text = "-";
            this.BtTru.UseVisualStyleBackColor = true;
            // 
            // BtNhan
            // 
            this.BtNhan.Location = new System.Drawing.Point(382, 367);
            this.BtNhan.Margin = new System.Windows.Forms.Padding(2);
            this.BtNhan.Name = "BtNhan";
            this.BtNhan.Size = new System.Drawing.Size(82, 53);
            this.BtNhan.TabIndex = 9;
            this.BtNhan.Text = "*";
            this.BtNhan.UseVisualStyleBackColor = true;
            // 
            // BtChia
            // 
            this.BtChia.Location = new System.Drawing.Point(501, 367);
            this.BtChia.Margin = new System.Windows.Forms.Padding(2);
            this.BtChia.Name = "BtChia";
            this.BtChia.Size = new System.Drawing.Size(82, 53);
            this.BtChia.TabIndex = 10;
            this.BtChia.Text = "/";
            this.BtChia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.BtChia);
            this.Controls.Add(this.BtNhan);
            this.Controls.Add(this.BtTru);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "TinhToan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label txtkq;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button BtTru;
        private System.Windows.Forms.Button BtNhan;
        private System.Windows.Forms.Button BtChia;
    }
}

