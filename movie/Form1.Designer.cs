namespace movie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            pnlHangGhe = new Panel();
            txtTinhTien = new TextBox();
            btnChon = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            STT = new DataGridViewTextBoxColumn();
            MaHoaDon = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            NgayMua = new DataGridViewTextBoxColumn();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(744, 83);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(738, 83);
            label1.TabIndex = 0;
            label1.Text = "MÀN ẢNH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pnlHangGhe
            // 
            pnlHangGhe.Location = new Point(15, 98);
            pnlHangGhe.Name = "pnlHangGhe";
            pnlHangGhe.Size = new Size(741, 395);
            pnlHangGhe.TabIndex = 2;
            pnlHangGhe.Paint += pnlHangGhe_Paint;
            // 
            // txtTinhTien
            // 
            txtTinhTien.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtTinhTien.Location = new Point(420, 499);
            txtTinhTien.Multiline = true;
            txtTinhTien.Name = "txtTinhTien";
            txtTinhTien.Size = new Size(336, 44);
            txtTinhTien.TabIndex = 3;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(420, 564);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(94, 40);
            btnChon.TabIndex = 4;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(542, 564);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 40);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(662, 564);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 40);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { STT, MaHoaDon, TongTien, NgayMua });
            dataGridView1.Location = new Point(791, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(570, 188);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(791, 365);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(570, 188);
            dataGridView2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(807, 30);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 9;
            label2.Text = "Danh sách hóa đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(791, 324);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 10;
            label3.Text = "Danh sách chi tiết hóa đơn";
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.Width = 125;
            // 
            // MaHoaDon
            // 
            MaHoaDon.HeaderText = "MaHoaDon";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.Width = 125;
            // 
            // TongTien
            // 
            TongTien.HeaderText = "TongTien";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.Width = 125;
            // 
            // NgayMua
            // 
            NgayMua.HeaderText = "NgayMua";
            NgayMua.MinimumWidth = 6;
            NgayMua.Name = "NgayMua";
            NgayMua.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 653);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnChon);
            Controls.Add(txtTinhTien);
            Controls.Add(pnlHangGhe);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Panel pnlHangGhe;
        private TextBox txtTinhTien;
        private Button btnChon;
        private Button btnHuy;
        private Button btnThoat;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn NgayMua;
    }
}
