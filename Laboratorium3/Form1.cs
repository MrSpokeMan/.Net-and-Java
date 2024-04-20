using System.Drawing;

namespace Laboratorium3
{
    public partial class Form1 : Form
    {
        Thread[] threadsArray;
        MatrixMultiplier matrixMultiplier;
        private Bitmap? image;

        private readonly object imageLock = new object();

        private int threads;
        private int[,] matrix1, matrix2, resultMatrix;

        public Form1()
        {
            InitializeComponent();
            textBoxMatrixColumn1.KeyPress += textBoxMatrixColumn1_KeyPress;
            textBoxMatrixColumn2.KeyPress += textBoxMatrixColumn2_KeyPress;
            textBoxMatrixRow1.KeyPress += textBoxMatrixRow1_KeyPress;
            textBoxMatrixRow2.KeyPress += textBoxMatrixRow2_KeyPress;
            textBoxThreads.KeyPress += textBoxThreads_KeyPress;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxThreads.Text != "")
            {
                this.threads = int.Parse(textBoxThreads.Text);
            }
            else
            {
                this.threads = 1;
            }

            if (!matrixMultiplier.IsMultiplicationPossible())
            {
                MessageBox.Show("Nie można pomnożyć tych macierzy");
                return;
            }

            int size = matrix1.GetLength(0);
            int rowsPerThread = size / threads;

            this.threadsArray = new Thread[threads];
            for (int i = 0; i < threads; i++)
            {
                int startRow = i * rowsPerThread;
                int endRow = (i == threads - 1) ? size : (i + 1) * rowsPerThread;

                threadsArray[i] = new Thread(() => matrixMultiplier.CalculateMatrix(startRow, endRow));
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (var thread in threadsArray)
            {
                thread.Start();
            }
            foreach (var thread in threadsArray)
            {
                thread.Join();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            labelThread.Text = "Czas niskopoziomowy: " + elapsedMs + " ms";

            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = threads;

            var watchParallel = System.Diagnostics.Stopwatch.StartNew();
            matrixMultiplier.CalculateMatrixParallel(options);
            watchParallel.Stop();
            var elapsedMsParallel = watchParallel.ElapsedMilliseconds;
            labelParallel.Text = "Czas wysokopoziomowy: " + elapsedMsParallel + " ms";

            // Wypisanie wyniku
            //this.resultMatrix = matrixMultiplier.GetResultMatrix();
            //matrixMultiplier.DisplayMatrix(this.resultMatrix, textBoxMatrixResult); 
        }

        private void textBoxMatrixRow1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMatrixColumn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMatrixRow2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMatrixColumn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxThreads_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonMatrixGenerate_Click(object sender, EventArgs e)
        {
            int row1 = int.Parse(textBoxMatrixRow1.Text);
            int column1 = int.Parse(textBoxMatrixColumn1.Text);
            int row2 = int.Parse(textBoxMatrixRow2.Text);
            int column2 = int.Parse(textBoxMatrixColumn2.Text);

            matrixMultiplier = new MatrixMultiplier(row1, column1, row2, column2);

            matrixMultiplier.GenerateMatrix(row1, column1, row2, column2);

            this.matrix1 = matrixMultiplier.GetMatrix1();
            this.matrix2 = matrixMultiplier.GetMatrix2();

            // Wypisanie macierzy
            //matrixMultiplier.DisplayMatrix(this.matrix1, textBoxMatrix1);
            //matrixMultiplier.DisplayMatrix(this.matrix2, textBoxMatrix2);
        }

        private void buttonLoadImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.PNG;*.JPG;)|*.PNG;*.JPG;|All files (*.*)|*.*";
            var file = openFileDialog1.FileName;
            if (file != "")
            {
                image = new Bitmap(file);
                pictureBox1.Image = image;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            Thread[] processes = new Thread[4];
            processes[0] = new Thread(() =>
            {
                Bitmap negativeImage;
                lock (imageLock)
                {
                    negativeImage = ImageProcessing.Negative(image);
                }
                pictureBox2.Image = negativeImage;
            });

            processes[1] = new Thread(() =>
            {
                Bitmap thresholdedImage;
                lock (imageLock)
                {
                    thresholdedImage = ImageProcessing.ApplyThreshold(image, 128);
                }
                pictureBox3.Image = thresholdedImage;
            });

            processes[2] = new Thread(() =>
            {
                Bitmap mirroredImage;
                lock (imageLock)
                {
                    mirroredImage = ImageProcessing.MirrorEffect(image);
                }
                pictureBox4.Image = mirroredImage;
            });

            processes[3] = new Thread(() =>
            {
                Bitmap edgesImage;
                lock (imageLock)
                {
                    edgesImage = ImageProcessing.DetectEdges(image);
                }
                pictureBox5.Image = edgesImage;
            });

            foreach (var process in processes)
            {
                process.Start();
            }
            foreach (var process in processes)
            {
                process.Join();
            }
        }
    }
}
