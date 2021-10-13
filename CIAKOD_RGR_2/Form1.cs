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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            rtbResultPath.Enabled = false;

            colors = new List<Color>();
            colors.Add(Color.Orange);
            colors.Add(Color.Red);
            colors.Add(Color.Blue);
            colors.Add(Color.Black);
            colors.Add(Color.Crimson);
            colors.Add(Color.Brown);
            colors.Add(Color.BlueViolet);

            dataGridViewPerexod.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewDoxod.DefaultCellStyle.ForeColor = Color.White;

        }


        public void Wait(double seconds)
        {
            int ticks = System.Environment.TickCount + (int)Math.Round(seconds * 1000.0);
            while (System.Environment.TickCount < ticks)
            {
                Application.DoEvents();
            }
        }

        public List<Color> colors;



        private void btnMark_Click(object sender, EventArgs e)
        {
            if (tbEtap.Text != null)
            {
                for (int i = 0; i < Int32.Parse(tbStrat.Text); i++)
                {
                    for (int j = 0; j < Int32.Parse(tbSost.Text); j++)
                    {
                        double sum = 0;
                        for (int k=0; k < Int32.Parse(tbSost.Text); k++)
                        {
                            sum += Convert.ToDouble(dataGridViewPerexod[(Int32.Parse(tbSost.Text) * i) + k, j].Value.ToString());
                        }
                        if (sum != 1.0)
                        {
                            labelError.Text = "Ошибка! Сумма не равна 1\n в ряду " + (j).ToString() + " и в столбцах с \n" + (Int32.Parse(tbSost.Text) * i).ToString() + " по " + (Int32.Parse(tbSost.Text) * (i+1)-1).ToString();
                        }
                    }
                }

                rtbResultPath.Enabled = true;
                List<Double[]> qiks = new List<Double[]>();
                int sost = Int32.Parse(tbSost.Text);
                int strat = Int32.Parse(tbStrat.Text);
                int etaps = Int32.Parse(tbEtap.Text);
                for (int i = 0; i < sost; ++i)
                {
                    qiks.Add(new double[(Int32.Parse(tbStrat.Text))]);
                    for (int j = 0; j < strat; ++j)
                        qiks[i][j] = 0;
                }

                rtbResultPath.Text += "Ожидаемые доходы:\n";
                for (int i = 0; i < sost; i++)
                {
                    for (int cnt = 0; cnt < strat; cnt++)
                    {
                        double sum = 0;
                        rtbResultPath.Text += "q" + (cnt + 1).ToString() + " sost" + (i + 1).ToString() + " = ";
                        for (int j = 0; j < sost; ++j)
                        {
                            sum += Convert.ToDouble(dataGridViewDoxod[cnt * sost + j, i].Value) * Convert.ToDouble(dataGridViewPerexod[cnt * sost + j, i].Value);
                            rtbResultPath.Text += dataGridViewDoxod[cnt * sost + j, i].Value.ToString() + " * " + dataGridViewPerexod[cnt * sost + j, i].Value.ToString() + " + ";
                        }
                        qiks[i][cnt] = sum;
                        rtbResultPath.Text += " = " + sum.ToString() + "\n";
                    }
                }
                for (int i = 0; i < sost; i++)
                {

                    for (int j = 0; j < strat; j++)
                        rtbResultPath.Text += qiks[i][j].ToString() + " ";
                    rtbResultPath.Text += "\n";
                }

                //rtbResultPath.Text += "\n Sostoyanie     Strategii     Perehodnie veroyatnosti     Doxodnosti     qiks\n";
                //for (int i=0; i<sost; i++)
                //{
                //    for (int j=0; j<sost; j++)
                //    {
                //        rtbResultPath.Text += 
                //    }
                //}

                List<List<int>> beststrats = new List<List<int>>();
                List <List<double>> bestvis = new List<List<double>>();
                List<List<double>> vis = new List<List<double>>();
                for (int i = 0; i <= etaps; i++)
                {
                    bestvis.Add(new List<double>());
                    beststrats.Add(new List<int>());
                }
                for (int j = 0; j <= etaps; ++j)
                {
                    for (int i = 0; i < strat; ++i)
                    {
                        bestvis[j].Add(0.0);
                        beststrats[j].Add(0);
                    }
                }
                rtbResultPath.Text += "\nРассчитаем полный ожидаемый доход\nv(0) = 0\n";
                for (int count = 0; count < etaps; count++)
                {
                    rtbResultPath.Text += "Step " + (count+1).ToString();
                    vis.Clear();
                    for (int i = 0; i < sost; i++)
                    {
                        vis.Add(new List<double>());
                    }
                    string tmp = "";
                    for (int i = 0; i < strat; ++i)
                    {
                        
                        int cnt = 0;
                        
                        foreach (List<double> a in vis)
                        {
                            double v = qiks[cnt][i];
                            tmp += "\nfunc vi sostoyanie " + (cnt + 1).ToString() + "(" + (count + 1).ToString() + ") = ";
                            tmp += qiks[cnt][i].ToString();
                            
                            for (int k = 0; k < sost; ++k)
                            {
                                v += Convert.ToDouble(dataGridViewPerexod[i * sost + k, cnt].Value) * bestvis[count][k];
                                tmp += " + " + dataGridViewPerexod[i * sost + k, cnt].Value.ToString() + " * " + bestvis[count][k].ToString();
                            }
                            tmp += " = " + v.ToString();
                            a.Add(v);
                            cnt++;
                            
                        }
                        

                    }
                    rtbResultPath.Text += "\n" + tmp;

                    rtbResultPath.Text += "\nMaxes:\n";
                    for (int i = 0; i < sost; ++i)
                    {
                        double max = 0;
                        int ind = 0;
                        rtbResultPath.Text += "func vi sostoyanie " + (i + 1).ToString() + "(" + (count + 1).ToString() + ") = max[";
                        for (int j = 0; j < strat; ++j)
                        {
                            rtbResultPath.Text += vis[i][j].ToString() + "; ";
                            if (vis[i][j] > max)
                            {
                                max = vis[i][j];
                                ind = j;
                            }
                        }
                        rtbResultPath.Text += "] = " + max.ToString() + "; Best strat = " + (ind+1).ToString() + "\n";
                        beststrats[count + 1][i] = (ind+1);
                        bestvis[count+1][i] = (max);
                    }

                    rtbResultPath.Text += "\n\n";
                }
                rtbResultPath.Text += "\n\n";

                Form2 f2 = new Form2(sost, etaps, bestvis, beststrats, colors);
                f2.Show();

            }
        }

        private void markovProc()
        {
            rtbResultPath.Enabled = true;
            List <Double[]> qiks = new List<Double[]>();
            int sost = Int32.Parse(tbSost.Text);
            int strat = Int32.Parse(tbStrat.Text);
            int etaps = Int32.Parse(tbEtap.Text);
            for (int i = 0; i < sost; ++i)
            {
                qiks.Add(new double[(Int32.Parse(tbSost.Text))]);
            }

            int row = 0;
            for (int i = 0; i < sost; i++)
            {
                double sum = 0;
                int cnt = 0;
                while (cnt < strat)
                {
                    for (int j = 0; j < sost; ++j)
                    {
                        sum += Convert.ToDouble(dataGridViewDoxod[i * sost + j, i].Value) * Convert.ToDouble(dataGridViewPerexod[i * sost + j, i].Value);
                    }
                    qiks[i][cnt] = sum;
                    cnt++;
                }
            }
            rtbResultPath.Text += qiks[0].ToString() + "\n" + qiks[1].ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridViewPerexod.RowCount = Int32.Parse(tbSost.Text);
            dataGridViewPerexod.ColumnCount = Int32.Parse(tbSost.Text)* Int32.Parse(tbStrat.Text);
            dataGridViewPerexod.Rows[0].Cells[0].Selected = false;
            dataGridViewPerexod.RowHeadersWidth = 80;
            int cnt = 0;
            for (int i = 0; i < dataGridViewPerexod.ColumnCount; i++)
            {
                dataGridViewPerexod.Columns[i].Name = "Sost " + (cnt+1).ToString();
                cnt++;
                if (cnt == (int.Parse(tbSost.Text)))
                    cnt = 0;
                dataGridViewPerexod.Columns[i].Width = 50;
            }
            for (int i = 0; i < dataGridViewPerexod.RowCount; i++)
            {
                dataGridViewPerexod.Rows[i].HeaderCell.Value = "Sost" + (i+1).ToString();
            }
            for (int i = 0; i < Int32.Parse(tbStrat.Text); i++)
            {
                for (int j = 0; j < Int32.Parse(tbSost.Text); j++)
                    dataGridViewPerexod.Columns[(Int32.Parse(tbSost.Text)*i) +j].DefaultCellStyle.BackColor = colors[i];
            }

            dataGridViewDoxod.RowCount = Int32.Parse(tbSost.Text);
            dataGridViewDoxod.ColumnCount = Int32.Parse(tbSost.Text) * Int32.Parse(tbStrat.Text);
            dataGridViewDoxod.Rows[0].Cells[0].Selected = false;
            dataGridViewDoxod.RowHeadersWidth = 80;
            cnt = 0;
            for (int i = 0; i < dataGridViewDoxod.ColumnCount; i++)
            {
                dataGridViewDoxod.Columns[i].Name = "Sost " + (cnt + 1).ToString();
                cnt++;
                if (cnt == (int.Parse(tbSost.Text)))
                    cnt = 0;
                dataGridViewDoxod.Columns[i].Width = 50;
                dataGridViewDoxod.Columns[i].DefaultCellStyle.Format = "N2";
            }
            for (int i = 0; i < dataGridViewDoxod.RowCount; i++)
            {
                dataGridViewDoxod.Rows[i].HeaderCell.Value = "Sost " + (i + 1).ToString();
            }
            for (int i = 0; i < Int32.Parse(tbStrat.Text); i++)
            {
                for (int j = 0; j < Int32.Parse(tbSost.Text); j++)
                    dataGridViewDoxod.Columns[(Int32.Parse(tbSost.Text) * i) + j].DefaultCellStyle.BackColor = colors[i];
            }

            if (cbExample2.Checked)
            {
                dataGridViewDoxod[0, 0].Value = 8.68;
                dataGridViewDoxod[1, 0].Value = 0;
                dataGridViewDoxod[2, 0].Value = 16.83;
                dataGridViewDoxod[3, 0].Value = 0;
                dataGridViewDoxod[4, 0].Value = 3.23;
                dataGridViewDoxod[5, 0].Value = 0;

                dataGridViewDoxod[0, 1].Value = 2.43;
                dataGridViewDoxod[1, 1].Value = 3.29;
                dataGridViewDoxod[2, 1].Value = 14.11;
                dataGridViewDoxod[3, 1].Value = 7.63;
                dataGridViewDoxod[4, 1].Value = 10.07;
                dataGridViewDoxod[5, 1].Value = 7.86;

                dataGridViewPerexod[0, 0].Value = 1;
                dataGridViewPerexod[1, 0].Value = 0;
                dataGridViewPerexod[2, 0].Value = 1;
                dataGridViewPerexod[3, 0].Value = 0;
                dataGridViewPerexod[4, 0].Value = 1;
                dataGridViewPerexod[5, 0].Value = 0;

                dataGridViewPerexod[0, 1].Value = 0.1;
                dataGridViewPerexod[1, 1].Value = 0.9;
                dataGridViewPerexod[2, 1].Value = 0.33;
                dataGridViewPerexod[3, 1].Value = 0.67;
                dataGridViewPerexod[4, 1].Value = 0.33;
                dataGridViewPerexod[5, 1].Value = 0.67;
            }


            if (cbExample3.Checked)
            {
                dataGridViewPerexod[0, 0].Value = 0.7;
                dataGridViewPerexod[1, 0].Value = 0.25;
                dataGridViewPerexod[2, 0].Value = 0.05;
                dataGridViewPerexod[3, 0].Value = 0.1;
                dataGridViewPerexod[4, 0].Value = 0.5;
                dataGridViewPerexod[5, 0].Value = 0.4;
                dataGridViewPerexod[6, 0].Value = 0.25;
                dataGridViewPerexod[7, 0].Value = 0.7;
                dataGridViewPerexod[8, 0].Value = 0.05;

                dataGridViewPerexod[0, 1].Value = 0.55;
                dataGridViewPerexod[1, 1].Value = 0.35;
                dataGridViewPerexod[2, 1].Value = 0.1;
                dataGridViewPerexod[3, 1].Value = 0.05;
                dataGridViewPerexod[4, 1].Value = 0.8;
                dataGridViewPerexod[5, 1].Value = 0.15;
                dataGridViewPerexod[6, 1].Value = 0.05;
                dataGridViewPerexod[7, 1].Value = 0.85;
                dataGridViewPerexod[8, 1].Value = 0.1;

                dataGridViewPerexod[0, 2].Value = 0.15;
                dataGridViewPerexod[1, 2].Value = 0.6;
                dataGridViewPerexod[2, 2].Value = 0.25;
                dataGridViewPerexod[3, 2].Value = 0.03;
                dataGridViewPerexod[4, 2].Value = 0.07;
                dataGridViewPerexod[5, 2].Value = 0.9;
                dataGridViewPerexod[6, 2].Value = 0.05;
                dataGridViewPerexod[7, 2].Value = 0.6;
                dataGridViewPerexod[8, 2].Value = 0.35;




                dataGridViewDoxod[0, 0].Value = 4000;
                dataGridViewDoxod[1, 0].Value = 8000;
                dataGridViewDoxod[2, 0].Value = 10000;
                dataGridViewDoxod[3, 0].Value = 500;
                dataGridViewDoxod[4, 0].Value = 2500;
                dataGridViewDoxod[5, 0].Value = 4500;
                dataGridViewDoxod[6, 0].Value = 2500;
                dataGridViewDoxod[7, 0].Value = 4500;
                dataGridViewDoxod[8, 0].Value = 6500;

                dataGridViewDoxod[0, 1].Value = 3000;
                dataGridViewDoxod[1, 1].Value = 5000;
                dataGridViewDoxod[2, 1].Value = 8000;
                dataGridViewDoxod[3, 1].Value = 1000;
                dataGridViewDoxod[4, 1].Value = 3000;
                dataGridViewDoxod[5, 1].Value = 5000;
                dataGridViewDoxod[6, 1].Value = 3000;
                dataGridViewDoxod[7, 1].Value = 5000;
                dataGridViewDoxod[8, 1].Value = 7000;

                dataGridViewDoxod[0, 2].Value = 1000;
                dataGridViewDoxod[1, 2].Value = 3000;
                dataGridViewDoxod[2, 2].Value = 5000;
                dataGridViewDoxod[3, 2].Value = 1500;
                dataGridViewDoxod[4, 2].Value = 3500;
                dataGridViewDoxod[5, 2].Value = 5500;
                dataGridViewDoxod[6, 2].Value = 3500;
                dataGridViewDoxod[7, 2].Value = 5500;
                dataGridViewDoxod[8, 2].Value = 7500;
            }
        }

        private void tbSost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbStrat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbEtap_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewDoxod_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        private void dataGridViewPerexod_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                if (e.KeyChar != (char)Keys.Back)
                { e.Handled = true; }
            }
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            tbSost.Text = "";
            tbStrat.Text = "";
            tbEtap.Text = "";
            dataGridViewDoxod.Rows.Clear();
            dataGridViewPerexod.Rows.Clear();
            int count = dataGridViewDoxod.Columns.Count;
            for (int i = 0; i < count; i++) 
            {
                dataGridViewDoxod.Columns.RemoveAt(0);
                dataGridViewPerexod.Columns.RemoveAt(0);
            }


            rtbResultPath.Text = ""; 
        }
    }
}

