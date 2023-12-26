namespace TeknolojiMagazasi
{
    partial class Kampanya
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
            txtKampanyaID = new TextBox();
            txtKampanyaAd = new TextBox();
            txtMinTutar = new TextBox();
            txtTarih1 = new TextBox();
            txtTarih2 = new TextBox();
            txtIndirimOran = new TextBox();
            btnKampanyaEkle = new Button();
            btnKampanyaSil = new Button();
            dataGridViewKampanya = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKampanya).BeginInit();
            SuspendLayout();
            // 
            // txtKampanyaID
            // 
            txtKampanyaID.Location = new Point(132, 68);
            txtKampanyaID.Name = "txtKampanyaID";
            txtKampanyaID.Size = new Size(125, 27);
            txtKampanyaID.TabIndex = 0;
            txtKampanyaID.Visible = false;
            // 
            // txtKampanyaAd
            // 
            txtKampanyaAd.Location = new Point(132, 101);
            txtKampanyaAd.Name = "txtKampanyaAd";
            txtKampanyaAd.Size = new Size(125, 27);
            txtKampanyaAd.TabIndex = 1;
            // 
            // txtMinTutar
            // 
            txtMinTutar.Location = new Point(132, 134);
            txtMinTutar.Name = "txtMinTutar";
            txtMinTutar.Size = new Size(125, 27);
            txtMinTutar.TabIndex = 2;
            // 
            // txtTarih1
            // 
            txtTarih1.Location = new Point(132, 167);
            txtTarih1.Name = "txtTarih1";
            txtTarih1.Size = new Size(125, 27);
            txtTarih1.TabIndex = 3;
            txtTarih1.TextChanged += txtTarih1_TextChanged;
            // 
            // txtTarih2
            // 
            txtTarih2.Location = new Point(132, 200);
            txtTarih2.Name = "txtTarih2";
            txtTarih2.Size = new Size(125, 27);
            txtTarih2.TabIndex = 4;
            // 
            // txtIndirimOran
            // 
            txtIndirimOran.Location = new Point(132, 233);
            txtIndirimOran.Name = "txtIndirimOran";
            txtIndirimOran.Size = new Size(125, 27);
            txtIndirimOran.TabIndex = 5;
            // 
            // btnKampanyaEkle
            // 
            btnKampanyaEkle.Location = new Point(82, 290);
            btnKampanyaEkle.Name = "btnKampanyaEkle";
            btnKampanyaEkle.Size = new Size(94, 29);
            btnKampanyaEkle.TabIndex = 6;
            btnKampanyaEkle.Text = "Ekle";
            btnKampanyaEkle.UseVisualStyleBackColor = true;
            btnKampanyaEkle.Click += btnKampanyaEkle_Click;
            // 
            // btnKampanyaSil
            // 
            btnKampanyaSil.Location = new Point(195, 290);
            btnKampanyaSil.Name = "btnKampanyaSil";
            btnKampanyaSil.Size = new Size(94, 29);
            btnKampanyaSil.TabIndex = 7;
            btnKampanyaSil.Text = "Sil";
            btnKampanyaSil.UseVisualStyleBackColor = true;
            btnKampanyaSil.Click += btnKampanyaSil_Click;
            // 
            // dataGridViewKampanya
            // 
            dataGridViewKampanya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKampanya.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKampanya.Location = new Point(394, 45);
            dataGridViewKampanya.Name = "dataGridViewKampanya";
            dataGridViewKampanya.RowHeadersWidth = 51;
            dataGridViewKampanya.RowTemplate.Height = 29;
            dataGridViewKampanya.Size = new Size(637, 347);
            dataGridViewKampanya.TabIndex = 8;
            dataGridViewKampanya.CellContentClick += dataGridViewKampanya_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 101);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 9;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 10;
            label2.Text = "Min Tutar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 11;
            label3.Text = "Başlangıç Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 200);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 12;
            label4.Text = "Bitiş Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 233);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 13;
            label5.Text = "İndirim Oranı:";
            // 
            // Kampanya
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1102, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewKampanya);
            Controls.Add(btnKampanyaSil);
            Controls.Add(btnKampanyaEkle);
            Controls.Add(txtIndirimOran);
            Controls.Add(txtTarih2);
            Controls.Add(txtTarih1);
            Controls.Add(txtMinTutar);
            Controls.Add(txtKampanyaAd);
            Controls.Add(txtKampanyaID);
            Name = "Kampanya";
            Text = "Kampanya";
            Load += Kampanya_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKampanya).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKampanyaID;
        private TextBox txtKampanyaAd;
        private TextBox txtMinTutar;
        private TextBox txtTarih1;
        private TextBox txtTarih2;
        private TextBox txtIndirimOran;
        private Button btnKampanyaEkle;
        private Button btnKampanyaSil;
        private DataGridView dataGridViewKampanya;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}