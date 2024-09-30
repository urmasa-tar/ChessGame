namespace ChessGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int n;
        PictureBox[,] P;
        private void Form1_Load(object sender, EventArgs e)
        {
            n = 8;
            P = new PictureBox[n, n];
            int left = 2; int top = 2;
            Color[] colors = new Color[] { Color.White, Color.Black};

            for (int i = 0; i < n; i++)
            {
                left = 2;
                // Random r = new Random();
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                else { colors[1] = Color.White; colors[0] = Color.Black; }
                for (int j = 0; j < n; j++)
                {

                    P[i, j] = new PictureBox();
                    // P[i, j].BackColor = Color.FromArgb(255, r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                    P[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    P[i, j].Location = new Point(left, top);
                    P[i, j].Size = new Size(60, 60);

                    left += 60;
                    P[i, j].Name = i + " " + j;
                    if (i < ((n / 2) - 1) && P[i, j].BackColor == Color.Black)
                    {
                        P[i, j].Image = Properties.Resources.bhourse;
                        P[i, j].Name += " bhourse";
                    }
                    else if (i > (n / 2) && P[i, j].BackColor == Color.Black)
                    {
                        P[i, j].Image = Properties.Resources.horse4;
                        P[i, j].Name += " hourse04";
                    }
                    P[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                    mainPanel.Controls.Add(P[i, j]);
                }

                top += 60;
            }
        }
       
    }
}
