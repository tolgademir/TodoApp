namespace TodoApp
{
    partial class TodoEkle
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTodoAdi = new System.Windows.Forms.TextBox();
            this.richTextBoxTodoAciklamasi = new System.Windows.Forms.RichTextBox();
            this.dateTimeTodoTarih = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTodoKategori = new System.Windows.Forms.ComboBox();
            this.radioButtonTamamlandı = new System.Windows.Forms.RadioButton();
            this.radioButtonDevamEdiyor = new System.Windows.Forms.RadioButton();
            this.radioButtonTamamlanmadı = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKategoriEkle = new System.Windows.Forms.TextBox();
            this.btnTodoKategoriEkle = new System.Windows.Forms.Button();
            this.btnTodoEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todo Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Todo Açıklaması:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Todo Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Todo Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Todo Durumu:";
            // 
            // txtTodoAdi
            // 
            this.txtTodoAdi.Location = new System.Drawing.Point(118, 20);
            this.txtTodoAdi.Name = "txtTodoAdi";
            this.txtTodoAdi.Size = new System.Drawing.Size(228, 20);
            this.txtTodoAdi.TabIndex = 5;
            // 
            // richTextBoxTodoAciklamasi
            // 
            this.richTextBoxTodoAciklamasi.Location = new System.Drawing.Point(118, 172);
            this.richTextBoxTodoAciklamasi.Name = "richTextBoxTodoAciklamasi";
            this.richTextBoxTodoAciklamasi.Size = new System.Drawing.Size(617, 235);
            this.richTextBoxTodoAciklamasi.TabIndex = 6;
            this.richTextBoxTodoAciklamasi.Text = "";
            // 
            // dateTimeTodoTarih
            // 
            this.dateTimeTodoTarih.Location = new System.Drawing.Point(118, 64);
            this.dateTimeTodoTarih.Name = "dateTimeTodoTarih";
            this.dateTimeTodoTarih.Size = new System.Drawing.Size(228, 20);
            this.dateTimeTodoTarih.TabIndex = 7;
            // 
            // comboBoxTodoKategori
            // 
            this.comboBoxTodoKategori.FormattingEnabled = true;
            this.comboBoxTodoKategori.Location = new System.Drawing.Point(118, 99);
            this.comboBoxTodoKategori.Name = "comboBoxTodoKategori";
            this.comboBoxTodoKategori.Size = new System.Drawing.Size(228, 21);
            this.comboBoxTodoKategori.TabIndex = 8;
            // 
            // radioButtonTamamlandı
            // 
            this.radioButtonTamamlandı.AutoSize = true;
            this.radioButtonTamamlandı.Location = new System.Drawing.Point(118, 134);
            this.radioButtonTamamlandı.Name = "radioButtonTamamlandı";
            this.radioButtonTamamlandı.Size = new System.Drawing.Size(85, 17);
            this.radioButtonTamamlandı.TabIndex = 9;
            this.radioButtonTamamlandı.TabStop = true;
            this.radioButtonTamamlandı.Text = "Tamamlandı.";
            this.radioButtonTamamlandı.UseVisualStyleBackColor = true;
            // 
            // radioButtonDevamEdiyor
            // 
            this.radioButtonDevamEdiyor.AutoSize = true;
            this.radioButtonDevamEdiyor.Location = new System.Drawing.Point(209, 134);
            this.radioButtonDevamEdiyor.Name = "radioButtonDevamEdiyor";
            this.radioButtonDevamEdiyor.Size = new System.Drawing.Size(94, 17);
            this.radioButtonDevamEdiyor.TabIndex = 10;
            this.radioButtonDevamEdiyor.TabStop = true;
            this.radioButtonDevamEdiyor.Text = "Devam Ediyor.";
            this.radioButtonDevamEdiyor.UseVisualStyleBackColor = true;
            // 
            // radioButtonTamamlanmadı
            // 
            this.radioButtonTamamlanmadı.AutoSize = true;
            this.radioButtonTamamlanmadı.Location = new System.Drawing.Point(309, 134);
            this.radioButtonTamamlanmadı.Name = "radioButtonTamamlanmadı";
            this.radioButtonTamamlanmadı.Size = new System.Drawing.Size(99, 17);
            this.radioButtonTamamlanmadı.TabIndex = 11;
            this.radioButtonTamamlanmadı.TabStop = true;
            this.radioButtonTamamlanmadı.Text = "Tamamlanmadı.";
            this.radioButtonTamamlanmadı.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kategori Ekle:";
            // 
            // txtKategoriEkle
            // 
            this.txtKategoriEkle.Location = new System.Drawing.Point(456, 101);
            this.txtKategoriEkle.Name = "txtKategoriEkle";
            this.txtKategoriEkle.Size = new System.Drawing.Size(153, 20);
            this.txtKategoriEkle.TabIndex = 15;
            // 
            // btnTodoKategoriEkle
            // 
            this.btnTodoKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTodoKategoriEkle.Location = new System.Drawing.Point(629, 99);
            this.btnTodoKategoriEkle.Name = "btnTodoKategoriEkle";
            this.btnTodoKategoriEkle.Size = new System.Drawing.Size(97, 24);
            this.btnTodoKategoriEkle.TabIndex = 16;
            this.btnTodoKategoriEkle.Text = "Kategori Ekle";
            this.btnTodoKategoriEkle.UseVisualStyleBackColor = true;
            this.btnTodoKategoriEkle.Click += new System.EventHandler(this.btnTodoKategoriEkle_Click);
            // 
            // btnTodoEkle
            // 
            this.btnTodoEkle.Location = new System.Drawing.Point(118, 413);
            this.btnTodoEkle.Name = "btnTodoEkle";
            this.btnTodoEkle.Size = new System.Drawing.Size(617, 47);
            this.btnTodoEkle.TabIndex = 17;
            this.btnTodoEkle.Text = "Todo Ekle";
            this.btnTodoEkle.UseVisualStyleBackColor = true;
            this.btnTodoEkle.Click += new System.EventHandler(this.btnTodoEkle_Click);
            // 
            // TodoEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 472);
            this.Controls.Add(this.btnTodoEkle);
            this.Controls.Add(this.btnTodoKategoriEkle);
            this.Controls.Add(this.txtKategoriEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonTamamlanmadı);
            this.Controls.Add(this.radioButtonDevamEdiyor);
            this.Controls.Add(this.radioButtonTamamlandı);
            this.Controls.Add(this.comboBoxTodoKategori);
            this.Controls.Add(this.dateTimeTodoTarih);
            this.Controls.Add(this.richTextBoxTodoAciklamasi);
            this.Controls.Add(this.txtTodoAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TodoEkle";
            this.Text = "Todo Ekle";
            this.Load += new System.EventHandler(this.TodoEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTodoAdi;
        private System.Windows.Forms.RichTextBox richTextBoxTodoAciklamasi;
        private System.Windows.Forms.DateTimePicker dateTimeTodoTarih;
        private System.Windows.Forms.ComboBox comboBoxTodoKategori;
        private System.Windows.Forms.RadioButton radioButtonTamamlandı;
        private System.Windows.Forms.RadioButton radioButtonDevamEdiyor;
        private System.Windows.Forms.RadioButton radioButtonTamamlanmadı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKategoriEkle;
        private System.Windows.Forms.Button btnTodoKategoriEkle;
        private System.Windows.Forms.Button btnTodoEkle;
    }
}