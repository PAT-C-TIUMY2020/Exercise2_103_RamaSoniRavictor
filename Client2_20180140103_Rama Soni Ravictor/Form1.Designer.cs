namespace Client2_20180140103_Rama_Soni_Ravictor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxAngkatan = new System.Windows.Forms.TextBox();
            this.textBoxProdi = new System.Windows.Forms.TextBox();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelAngkatan = new System.Windows.Forms.Label();
            this.labelProdi = new System.Windows.Forms.Label();
            this.labelNIM = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonJumlah = new System.Windows.Forms.Button();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.buttonSync = new System.Windows.Forms.Button();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.labelKeterangan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 423);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(704, 235);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxAngkatan
            // 
            this.textBoxAngkatan.Location = new System.Drawing.Point(280, 234);
            this.textBoxAngkatan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAngkatan.Name = "textBoxAngkatan";
            this.textBoxAngkatan.Size = new System.Drawing.Size(217, 22);
            this.textBoxAngkatan.TabIndex = 17;
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.Location = new System.Drawing.Point(280, 187);
            this.textBoxProdi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(217, 22);
            this.textBoxProdi.TabIndex = 16;
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(280, 142);
            this.textBoxNIM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(217, 22);
            this.textBoxNIM.TabIndex = 15;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(280, 100);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(217, 22);
            this.textBoxNama.TabIndex = 14;
            // 
            // labelAngkatan
            // 
            this.labelAngkatan.AutoSize = true;
            this.labelAngkatan.Location = new System.Drawing.Point(119, 234);
            this.labelAngkatan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAngkatan.Name = "labelAngkatan";
            this.labelAngkatan.Size = new System.Drawing.Size(68, 17);
            this.labelAngkatan.TabIndex = 13;
            this.labelAngkatan.Text = "Angkatan";
            // 
            // labelProdi
            // 
            this.labelProdi.AutoSize = true;
            this.labelProdi.Location = new System.Drawing.Point(123, 187);
            this.labelProdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProdi.Name = "labelProdi";
            this.labelProdi.Size = new System.Drawing.Size(41, 17);
            this.labelProdi.TabIndex = 12;
            this.labelProdi.Text = "Prodi";
            // 
            // labelNIM
            // 
            this.labelNIM.AutoSize = true;
            this.labelNIM.Location = new System.Drawing.Point(119, 142);
            this.labelNIM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNIM.Name = "labelNIM";
            this.labelNIM.Size = new System.Drawing.Size(32, 17);
            this.labelNIM.TabIndex = 11;
            this.labelNIM.Text = "NIM";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(119, 100);
            this.labelNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(45, 17);
            this.labelNama.TabIndex = 10;
            this.labelNama.Text = "Nama";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(612, 136);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(179, 28);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(280, 356);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(179, 28);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonJumlah
            // 
            this.buttonJumlah.Location = new System.Drawing.Point(280, 299);
            this.buttonJumlah.Margin = new System.Windows.Forms.Padding(4);
            this.buttonJumlah.Name = "buttonJumlah";
            this.buttonJumlah.Size = new System.Drawing.Size(179, 28);
            this.buttonJumlah.TabIndex = 21;
            this.buttonJumlah.Text = "Jumlah";
            this.buttonJumlah.UseVisualStyleBackColor = true;
            this.buttonJumlah.Click += new System.EventHandler(this.buttonJumlah_Click);
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Location = new System.Drawing.Point(526, 305);
            this.labelJumlah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(88, 17);
            this.labelJumlah.TabIndex = 22;
            this.labelJumlah.Text = "Hasil Jumlah";
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(612, 187);
            this.buttonSync.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(179, 28);
            this.buttonSync.TabIndex = 23;
            this.buttonSync.Text = "Show Data";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(491, 359);
            this.textBoxDelete.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(251, 22);
            this.textBoxDelete.TabIndex = 24;
            this.textBoxDelete.Text = "Masukan NIM untuk delete";
            // 
            // labelKeterangan
            // 
            this.labelKeterangan.AutoSize = true;
            this.labelKeterangan.Location = new System.Drawing.Point(346, 49);
            this.labelKeterangan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeterangan.Name = "labelKeterangan";
            this.labelKeterangan.Size = new System.Drawing.Size(82, 17);
            this.labelKeterangan.TabIndex = 25;
            this.labelKeterangan.Text = "Keterangan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 656);
            this.Controls.Add(this.labelKeterangan);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.buttonJumlah);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxAngkatan);
            this.Controls.Add(this.textBoxProdi);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelAngkatan);
            this.Controls.Add(this.labelProdi);
            this.Controls.Add(this.labelNIM);
            this.Controls.Add(this.labelNama);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxAngkatan;
        private System.Windows.Forms.TextBox textBoxProdi;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelAngkatan;
        private System.Windows.Forms.Label labelProdi;
        private System.Windows.Forms.Label labelNIM;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonJumlah;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Button buttonSync;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Label labelKeterangan;
    }
}

