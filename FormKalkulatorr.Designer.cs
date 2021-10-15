
namespace SimpleApp2
{
    partial class FormKalkulatorr
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
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tboxHasil = new System.Windows.Forms.TextBox();
            this.tboxNilai2 = new System.Windows.Forms.TextBox();
            this.tboxNilai1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(376, 126);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(49, 27);
            this.btnBagi.TabIndex = 11;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(376, 85);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(49, 27);
            this.btnKali.TabIndex = 12;
            this.btnKali.Text = "*";
            this.btnKali.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(321, 170);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(104, 27);
            this.btnHapus.TabIndex = 13;
            this.btnHapus.Text = "C";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(321, 126);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(49, 27);
            this.btnKurang.TabIndex = 14;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(321, 85);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(49, 27);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tboxHasil
            // 
            this.tboxHasil.Location = new System.Drawing.Point(110, 175);
            this.tboxHasil.Name = "tboxHasil";
            this.tboxHasil.Size = new System.Drawing.Size(100, 22);
            this.tboxHasil.TabIndex = 8;
            // 
            // tboxNilai2
            // 
            this.tboxNilai2.Location = new System.Drawing.Point(110, 125);
            this.tboxNilai2.Name = "tboxNilai2";
            this.tboxNilai2.Size = new System.Drawing.Size(100, 22);
            this.tboxNilai2.TabIndex = 9;
            // 
            // tboxNilai1
            // 
            this.tboxNilai1.Location = new System.Drawing.Point(110, 85);
            this.tboxNilai1.Name = "tboxNilai1";
            this.tboxNilai1.Size = new System.Drawing.Size(100, 22);
            this.tboxNilai1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hasil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nilai 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nilai 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "KALKULATOR SEDERHANA";
            // 
            // FormKalkulatorr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tboxHasil);
            this.Controls.Add(this.tboxNilai2);
            this.Controls.Add(this.tboxNilai1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKalkulatorr";
            this.Text = "FormKalkulatorr";
            this.Load += new System.EventHandler(this.FormKalkulatorr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox tboxHasil;
        private System.Windows.Forms.TextBox tboxNilai2;
        private System.Windows.Forms.TextBox tboxNilai1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}