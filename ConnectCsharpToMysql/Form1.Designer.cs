namespace ConnectCsharpToMysql
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
            this.bInsert = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bSelect = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bCount = new System.Windows.Forms.Button();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.machine_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makina_calisma_sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_adedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalama_hiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description_durus_nedeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durus_saati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guncelleme_zamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih_zaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(72, 12);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(102, 51);
            this.bInsert.TabIndex = 0;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(394, 12);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(95, 51);
            this.bUpdate.TabIndex = 1;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(233, 12);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(95, 51);
            this.bSelect.TabIndex = 2;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(735, 12);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(106, 51);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bCount
            // 
            this.bCount.Location = new System.Drawing.Point(562, 12);
            this.bCount.Name = "bCount";
            this.bCount.Size = new System.Drawing.Size(97, 51);
            this.bCount.TabIndex = 4;
            this.bCount.Text = "Count";
            this.bCount.UseVisualStyleBackColor = true;
            this.bCount.Click += new System.EventHandler(this.bCount_Click);
            // 
            // dgDisplay
            // 
            this.dgDisplay.AllowUserToAddRows = false;
            this.dgDisplay.AllowUserToDeleteRows = false;
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machine_id,
            this.makina_calisma_sure,
            this.urun_adedi,
            this.urun_kodu,
            this.ortalama_hiz,
            this.description_durus_nedeni,
            this.durus_saati,
            this.guncelleme_zamani,
            this.tarih_zaman});
            this.dgDisplay.Location = new System.Drawing.Point(0, 89);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.ReadOnly = true;
            this.dgDisplay.RowHeadersVisible = false;
            this.dgDisplay.Size = new System.Drawing.Size(1221, 448);
            this.dgDisplay.TabIndex = 7;
            this.dgDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDisplay_CellContentClick);
            // 
            // machine_id
            // 
            this.machine_id.HeaderText = "Makina Numarasý";
            this.machine_id.Name = "machine_id";
            this.machine_id.ReadOnly = true;
            this.machine_id.Width = 130;
            // 
            // makina_calisma_sure
            // 
            this.makina_calisma_sure.HeaderText = "Makina Çalýsma Süresi";
            this.makina_calisma_sure.Name = "makina_calisma_sure";
            this.makina_calisma_sure.ReadOnly = true;
            this.makina_calisma_sure.Width = 140;
            // 
            // urun_adedi
            // 
            this.urun_adedi.HeaderText = "Ürün Adedi";
            this.urun_adedi.Name = "urun_adedi";
            this.urun_adedi.ReadOnly = true;
            this.urun_adedi.Width = 130;
            // 
            // urun_kodu
            // 
            this.urun_kodu.HeaderText = "Ürün Kodu";
            this.urun_kodu.Name = "urun_kodu";
            this.urun_kodu.ReadOnly = true;
            this.urun_kodu.Width = 130;
            // 
            // ortalama_hiz
            // 
            this.ortalama_hiz.HeaderText = "Ortalama Hýz";
            this.ortalama_hiz.Name = "ortalama_hiz";
            this.ortalama_hiz.ReadOnly = true;
            this.ortalama_hiz.Width = 130;
            // 
            // description_durus_nedeni
            // 
            this.description_durus_nedeni.HeaderText = "Makinanýn Durma Sebebi";
            this.description_durus_nedeni.Name = "description_durus_nedeni";
            this.description_durus_nedeni.ReadOnly = true;
            this.description_durus_nedeni.Width = 150;
            // 
            // durus_saati
            // 
            this.durus_saati.HeaderText = "Duruþ Saati";
            this.durus_saati.Name = "durus_saati";
            this.durus_saati.ReadOnly = true;
            this.durus_saati.Width = 130;
            // 
            // guncelleme_zamani
            // 
            this.guncelleme_zamani.HeaderText = "Günçelleme Zamaný";
            this.guncelleme_zamani.Name = "guncelleme_zamani";
            this.guncelleme_zamani.ReadOnly = true;
            this.guncelleme_zamani.Width = 130;
            // 
            // tarih_zaman
            // 
            this.tarih_zaman.HeaderText = "Tarih";
            this.tarih_zaman.Name = "tarih_zaman";
            this.tarih_zaman.ReadOnly = true;
            this.tarih_zaman.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 541);
            this.Controls.Add(this.bCount);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.dgDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Csharp To Mysql";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bCount;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn machine_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn makina_calisma_sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_adedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalama_hiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn description_durus_nedeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn durus_saati;
        private System.Windows.Forms.DataGridViewTextBoxColumn guncelleme_zamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih_zaman;
    }
}

