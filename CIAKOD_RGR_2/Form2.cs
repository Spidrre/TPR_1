using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int ssost;
        public Form2(int sost, int cnt, List<List<double>> vi, List<List<int>> str, List<Color> col)
        {
            InitializeComponent();
            ssost = sost;
            dataGridView1.RowCount = sost*2;
            dataGridView1.ColumnCount = cnt+1;
            dataGridView1.RowHeadersWidth = 100;
            int k = 1;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Name = (i).ToString();
                dataGridView1.Columns[i].Width = 50;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (i < sost)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = "vi sost " + k.ToString() + "(n)";
                    dataGridView1[0, i].Value = 0;
                }
                else
                {
                    dataGridView1.Rows[i].HeaderCell.Value = "d sost " + (-sost+k).ToString() + "(n)";
                    dataGridView1[0, i].Value = "-";
                }
                k++;
            }
            dataGridView1.Rows[0].Cells[0].Selected = false;

            for (int i=1; i< dataGridView1.ColumnCount; ++i)
            {
                int u = 0;
                for (int j = 0; j < dataGridView1.RowCount; ++j)
                {
                    if (j < sost)
                    {
                        dataGridView1[i, j].Value = vi[i][u];
                        u++;
                    }
                    else
                    {
                        dataGridView1[i, j].Value = str[i][dataGridView1.RowCount - u -1];
                        u++;
                    }
                }
            }


            if (pb.Image == null)
            {
                Bitmap bmp = new Bitmap(pb.Width, pb.Height);
                using (Graphics g1 = Graphics.FromImage(bmp))
                {
                    g1.Clear(Color.White);
                }
                pb.Image = bmp;
            }



            Graphics g = Graphics.FromImage(pb.Image);
            g.Clear(pb.BackColor);


            for (int i = 0; i < sost; ++i)
            {
                string s = "Sost ";
                s += (i + 1).ToString();
                g.DrawString(s, new Font("Arial", 12), Brushes.Black, new Point(10, 40+i*60));
            }

            pb.Update();
            pb.Select();

            int rad = 40;

            
            for (int i = 0; i < cnt; ++i)
            {
                Pen pen = new Pen(Color.Black);
                for (int j = 0; j < sost; ++j)
                {
                    pen.Color = Color.Black;
                    g.DrawEllipse(pen, 100 + i * 100, 30+j*60, rad, rad);
                    if (i != 0)
                    {
                       
                        for (int u = 0; u < (sost); ++u)
                        {
                            pen.Color = col[Convert.ToInt32(dataGridView1[i, (u + sost)].Value)-1];
                            g.DrawLine(pen, 
                                100 + i * 100+(rad/2), 
                                30 + j * 60+ (rad / 2), 
                                100 + (i-1) * 100 + (rad / 2),
                                30 + (u) * 60 + (rad / 2));
                        }



                    }
                }




            }
        }

        private void pb1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }


    }
}
