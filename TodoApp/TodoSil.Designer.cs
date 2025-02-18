namespace TodoApp
{
    partial class TodoSil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTodoSil = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 482);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnTodoSil
            // 
            this.btnTodoSil.Location = new System.Drawing.Point(1037, 12);
            this.btnTodoSil.Name = "btnTodoSil";
            this.btnTodoSil.Size = new System.Drawing.Size(129, 45);
            this.btnTodoSil.TabIndex = 4;
            this.btnTodoSil.Text = "Todo Sil";
            this.btnTodoSil.UseVisualStyleBackColor = true;
            this.btnTodoSil.Click += new System.EventHandler(this.btnTodoSil_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(1037, 63);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(129, 45);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // TodoSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 506);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnTodoSil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TodoSil";
            this.Text = "Todo Sil";
            this.Load += new System.EventHandler(this.TodoSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTodoSil;
        private System.Windows.Forms.Button btnYenile;
    }
}