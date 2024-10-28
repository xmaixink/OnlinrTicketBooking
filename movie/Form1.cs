namespace movie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoSoGhe(5, 7);
        }

        private void KhoiTaoSoGhe(int dong, int cot)
        {
            int x, y = 20, khoangCach = 100, dem = 1;
            for (int i = 0; i < dong; i++)
            {
                x = 3;

                for (int j = 0; j < cot; j++)
                {
                    Button btnGhe = new Button();
                    btnGhe.Location = new Point(x, y);
                    btnGhe.Size = new Size(90, 60);
                    btnGhe.Text = dem++.ToString();
                    btnGhe.BackColor = Color.White;
                    pnlHangGhe.Controls.Add(btnGhe);
                    btnGhe.Click += BtnGhe_Click;
                    x += khoangCach;
                }
                y += khoangCach;
            }

        }

        private void BtnGhe_Click(object? sender, EventArgs e)
        {
            Button btnGhe = (Button)sender;
            if (btnGhe.BackColor == Color.Red)

            {
                MessageBox.Show("Ghe da duoc dat rui!");
                return;

            }
            else if (btnGhe.BackColor == Color.White)
            {
                btnGhe.BackColor = Color.Green;

            }
            else
            {
                btnGhe.BackColor = Color.White;
            }
        }
        private void pnlHangGhe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            double tongTien = 0;
            foreach (Button Ghe in pnlHangGhe.Controls)
            {
                if (Ghe.BackColor == Color.Green)
                {
                    tongTien += TinhTien(Ghe.Text);
                    Ghe.BackColor = Color.Red;
                }

            }
            txtTinhTien.Text = tongTien.ToString();
        }

        private double TinhTien(string text)
        {
            int soGhe = int.Parse(text);
            if (soGhe <= 7)
            {
                return 30000;

            }
            else if (soGhe <= 14)
            {
                return 40000;
            }
            return 55000;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
