
namespace SimpleApp2
{
    partial class FormKonvertSuhu
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
            this.btnHapus = new System.Windows.Forms.Button();
            this.btn_proses = new System.Windows.Forms.Button();
            this.tboxNilai = new System.Windows.Forms.TextBox();
            this.rdbKtoC = new System.Windows.Forms.RadioButton();
            this.rdbCtoK = new System.Windows.Forms.RadioButton();
            this.rdbFtoC = new System.Windows.Forms.RadioButton();
            this.rdbCtoF = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.labelsuhu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(250, 226);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 15;
            this.btnHapus.Text = "clear";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btn_proses
            // 
            this.btn_proses.Location = new System.Drawing.Point(169, 226);
            this.btn_proses.Name = "btn_proses";
            this.btn_proses.Size = new System.Drawing.Size(75, 23);
            this.btn_proses.TabIndex = 16;
            this.btn_proses.Text = "Proses";
            this.btn_proses.UseVisualStyleBackColor = true;
            this.btn_proses.Click += new System.EventHandler(this.btn_proses_Click);
            // 
            // tboxNilai
            // 
            this.tboxNilai.Location = new System.Drawing.Point(56, 226);
            this.tboxNilai.Name = "tboxNilai";
            this.tboxNilai.Size = new System.Drawing.Size(107, 22);
            this.tboxNilai.TabIndex = 14;
            // 
            // rdbKtoC
            // 
            this.rdbKtoC.AutoSize = true;
            this.rdbKtoC.Location = new System.Drawing.Point(12, 149);
            this.rdbKtoC.Name = "rdbKtoC";
            this.rdbKtoC.Size = new System.Drawing.Size(137, 21);
            this.rdbKtoC.TabIndex = 10;
            this.rdbKtoC.TabStop = true;
            this.rdbKtoC.Text = "Kelvin Ke Celcius";
            this.rdbKtoC.UseVisualStyleBackColor = true;
            // 
            // rdbCtoK
            // 
            this.rdbCtoK.AutoSize = true;
            this.rdbCtoK.Location = new System.Drawing.Point(12, 122);
            this.rdbCtoK.Name = "rdbCtoK";
            this.rdbCtoK.Size = new System.Drawing.Size(137, 21);
            this.rdbCtoK.TabIndex = 11;
            this.rdbCtoK.TabStop = true;
            this.rdbCtoK.Text = "Celcius Ke Kelvin";
            this.rdbCtoK.UseVisualStyleBackColor = true;
            // 
            // rdbFtoC
            // 
            this.rdbFtoC.AutoSize = true;
            this.rdbFtoC.Location = new System.Drawing.Point(12, 95);
            this.rdbFtoC.Name = "rdbFtoC";
            this.rdbFtoC.Size = new System.Drawing.Size(167, 21);
            this.rdbFtoC.TabIndex = 12;
            this.rdbFtoC.TabStop = true;
            this.rdbFtoC.Text = "Fahrenheit Ke Celcius";
            this.rdbFtoC.UseVisualStyleBackColor = true;
            // 
            // rdbCtoF
            // 
            this.rdbCtoF.AutoSize = true;
            this.rdbCtoF.Location = new System.Drawing.Point(12, 68);
            this.rdbCtoF.Name = "rdbCtoF";
            this.rdbCtoF.Size = new System.Drawing.Size(167, 21);
            this.rdbCtoF.TabIndex = 13;
            this.rdbCtoF.TabStop = true;
            this.rdbCtoF.Text = "Celcius Ke Fahrenheit";
            this.rdbCtoF.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Derajat";
            // 
            // labelsuhu
            // 
            this.labelsuhu.AutoSize = true;
            this.labelsuhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsuhu.Location = new System.Drawing.Point(84, 266);
            this.labelsuhu.Name = "labelsuhu";
            this.labelsuhu.Size = new System.Drawing.Size(41, 17);
            this.labelsuhu.TabIndex = 5;
            this.labelsuhu.Text = "Suhu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Suhu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Konversi Suhu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Konversi Suhu";
            // 
            // FormKonvertSuhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btn_proses);
            this.Controls.Add(this.tboxNilai);
            this.Controls.Add(this.rdbKtoC);
            this.Controls.Add(this.rdbCtoK);
            this.Controls.Add(this.rdbFtoC);
            this.Controls.Add(this.rdbCtoF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelsuhu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKonvertSuhu";
            this.Text = "FormKonvertSuhu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btn_proses;
        private System.Windows.Forms.TextBox tboxNilai;
        private System.Windows.Forms.RadioButton rdbKtoC;
        private System.Windows.Forms.RadioButton rdbCtoK;
        private System.Windows.Forms.RadioButton rdbFtoC;
        private System.Windows.Forms.RadioButton rdbCtoF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelsuhu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}