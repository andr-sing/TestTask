using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TestTask.Models;
using System.Linq;
using System.IO;

namespace TestTask
{
    public partial class MainForm : Form
    {
        List<Receiver> recs = new List<Receiver>() { new Receiver { Coords = new double[] {0,0 } },
                                                     new Receiver { Coords = new double[] {0,0 } },
                                                     new Receiver { Coords = new double[] {0,0 } } };
        const double prec = 0.05; //Точность
        public List<Point> history = new List<Point>();

        const int latency = 100; //Дискретизация симуляции в миллисекундах

        NumericUpDown[,] receiversNumeric;
        

        public MainForm()
        {
            InitializeComponent();            
        }

        //Загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Определение начала координат
            Params.DefPoint = new Point { X = pictureBox1.Width / 2, Y = pictureBox1.Height / 2 };

            receiversNumeric = new[,] { { rec0xNum, rec0yNum },{ rec1xNum, rec1yNum }, { rec2xNum, rec2yNum } };

            Params.file = fileTB.Text;
        }

        //Восстановление траектории из файла
        private void ReadBtn_Click(object sender, EventArgs e)
        {            
            pictureBox1.Refresh();
            try
            {
                Model.ReadInput(out recs, out List<Ping> ping);
            
            Draw.DrawReceivers(recs, this);
            List<Coords2D> coords = Model.GetCoords(recs, ping, prec);
            Draw.DrawPath(coords, this);
            Model.WriteOutput(coords);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в формате исходных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        //Событие при изменении координат приемников
        private void Coords_changed(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 2; j++)
                    if (((NumericUpDown)sender).Name == receiversNumeric[i, j].Name)
                        recs[i].Coords[j] = Convert.ToDouble(receiversNumeric[i, j].Value);
            pictureBox1.Refresh();
            Draw.DrawReceivers(recs, this);
        }

        #region События симуляции
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (!SimulateCB.Checked)
                return;
            history = new List<Point>();
            pictureBox1.Refresh();
            Draw.DrawReceivers(recs, this);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!SimulateCB.Checked)
                return;
            history.Add(new Point(e.X, e.Y));
            if (history.Count > 1)
                Draw.DrawSegment(history.Last(), history[history.Count - 2], this);
            Thread.Sleep(latency);
        }
        #endregion

        //Сохранение в файл
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (history.Count != 0)
                try {
                    Model.SaveCoords(history, recs, this, out string file);
                    MessageBox.Show($"Сохранено в {file}");
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
                MessageBox.Show("Нет данных для сохранения!","", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
        }

        //Включение режима симуляции
        private void SimulateCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SimulateCB.Checked)
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 2; j++)
                        receiversNumeric[i, j].Enabled = true;

            }
            else
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 2; j++)
                        receiversNumeric[i, j].Enabled = false;
            }
            FillForm();
        }

        //Заполнение координат радиоприемников
        private void FillForm()
        {
            for (int i=0;i<3;i++)
                for (int j=0;j<2;j++)
                    receiversNumeric[i,j].Value= Convert.ToDecimal(recs[i].Coords[j]);
        }

        //Открытие файла
        private void FileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Params.file = openFileDialog.FileName;
                    fileTB.Text = Path.GetFileName(Params.file);
                }
            }
        }
    }
}
