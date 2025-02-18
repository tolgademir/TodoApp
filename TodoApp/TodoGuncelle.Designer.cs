namespace TodoApp
{
    partial class TodoGuncelle
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
            this.btnTodoGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTodoAdi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTodoKategori = new System.Windows.Forms.TextBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.radioButtonTamamlandı = new System.Windows.Forms.RadioButton();
            this.radioButtonDevamEdiyor = new System.Windows.Forms.RadioButton();
            this.radioButtonTamamlanmadı = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTodoGuncelle
            // 
            this.btnTodoGuncelle.Location = new System.Drawing.Point(12, 844);
            this.btnTodoGuncelle.Name = "btnTodoGuncelle";
            this.btnTodoGuncelle.Size = new System.Drawing.Size(129, 45);
            this.btnTodoGuncelle.TabIndex = 5;
            this.btnTodoGuncelle.Text = "Todo Güncelle";
            this.btnTodoGuncelle.UseVisualStyleBackColor = true;
            this.btnTodoGuncelle.Click += new System.EventHandler(this.btnTodoGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 482);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // txtTodoAdi
            // 
            this.txtTodoAdi.Location = new System.Drawing.Point(113, 516);
            this.txtTodoAdi.Name = "txtTodoAdi";
            this.txtTodoAdi.Size = new System.Drawing.Size(169, 20);
            this.txtTodoAdi.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 553);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(113, 673);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 165);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Todo Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Todo Açıklaması:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Todo Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Todo Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Todo Durumu:";
            // 
            // txtTodoKategori
            // 
            this.txtTodoKategori.Location = new System.Drawing.Point(113, 590);
            this.txtTodoKategori.Name = "txtTodoKategori";
            this.txtTodoKategori.Size = new System.Drawing.Size(169, 20);
            this.txtTodoKategori.TabIndex = 21;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(159, 844);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(111, 45);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // radioButtonTamamlandı
            // 
            this.radioButtonTamamlandı.AutoSize = true;
            this.radioButtonTamamlandı.Location = new System.Drawing.Point(113, 631);
            this.radioButtonTamamlandı.Name = "radioButtonTamamlandı";
            this.radioButtonTamamlandı.Size = new System.Drawing.Size(85, 17);
            this.radioButtonTamamlandı.TabIndex = 22;
            this.radioButtonTamamlandı.TabStop = true;
            this.radioButtonTamamlandı.Text = "Tamamlandı.";
            this.radioButtonTamamlandı.UseVisualStyleBackColor = true;
            // 
            // radioButtonDevamEdiyor
            // 
            this.radioButtonDevamEdiyor.AutoSize = true;
            this.radioButtonDevamEdiyor.Location = new System.Drawing.Point(204, 631);
            this.radioButtonDevamEdiyor.Name = "radioButtonDevamEdiyor";
            this.radioButtonDevamEdiyor.Size = new System.Drawing.Size(94, 17);
            this.radioButtonDevamEdiyor.TabIndex = 23;
            this.radioButtonDevamEdiyor.TabStop = true;
            this.radioButtonDevamEdiyor.Text = "Devam Ediyor.";
            this.radioButtonDevamEdiyor.UseVisualStyleBackColor = true;
            // 
            // radioButtonTamamlanmadı
            // 
            this.radioButtonTamamlanmadı.AutoSize = true;
            this.radioButtonTamamlanmadı.Location = new System.Drawing.Point(304, 631);
            this.radioButtonTamamlanmadı.Name = "radioButtonTamamlanmadı";
            this.radioButtonTamamlanmadı.Size = new System.Drawing.Size(99, 17);
            this.radioButtonTamamlanmadı.TabIndex = 24;
            this.radioButtonTamamlanmadı.TabStop = true;
            this.radioButtonTamamlanmadı.Text = "Tamamlanmadı.";
            this.radioButtonTamamlanmadı.UseVisualStyleBackColor = true;
            // 
            // TodoGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 897);
            this.Controls.Add(this.radioButtonTamamlanmadı);
            this.Controls.Add(this.radioButtonDevamEdiyor);
            this.Controls.Add(this.radioButtonTamamlandı);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.txtTodoKategori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTodoAdi);
            this.Controls.Add(this.btnTodoGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TodoGuncelle";
            this.Text = "Todo Güncelle";
            this.Load += new System.EventHandler(this.TodoGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTodoGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTodoAdi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTodoKategori;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.RadioButton radioButtonTamamlandı;
        private System.Windows.Forms.RadioButton radioButtonDevamEdiyor;
        private System.Windows.Forms.RadioButton radioButtonTamamlanmadı;
    }
}