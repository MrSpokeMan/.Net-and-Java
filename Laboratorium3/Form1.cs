namespace Laboratorium3
{
    public partial class Form1 : Form
    {
        private int[,] matrix1;
        private int[,] matrix2;
        private volatile int[,] resultMatrix;
        private Random random = new Random();
        private int row1, row2, column1, column2, threads;
        Thread[] threadsArray;

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
            if (column1 != row2)
            {
                MessageBox.Show("Nie można pomnożyć tych macierzy");
                return;
            }

            this.threadsArray = new Thread[threads];
            for (int i = 0; i < threads; i++)
            {
                threadsArray[i] = new Thread(() => CalculateMatrix(row1, column1, column2, matrix1, matrix2, resultMatrix));
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
            textBoxMatrixResult.Text = "Czas: " + elapsedMs + " ms";

            // Wypisanie wyniku
            //this.DisplayMatrix(resultMatrix, row1, column2, textBoxMatrixResult);  
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
            this.row1 = int.Parse(textBoxMatrixRow1.Text);
            this.column1 = int.Parse(textBoxMatrixColumn1.Text);
            this.row2 = int.Parse(textBoxMatrixRow2.Text);
            this.column2 = int.Parse(textBoxMatrixColumn2.Text);

            if (textBoxThreads.Text != "")
            {
                this.threads = int.Parse(textBoxThreads.Text);
            } else
            {
                this.threads = 1;
            }

            this.matrix1 = new int[row1, column1];
            this.matrix2 = new int[row2, column2];

            this.resultMatrix = new int[row1, column2];

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < column1; j++)
                {
                    matrix1[i, j] = random.Next(1, 100);
                    matrix2[i, j] = random.Next(1, 100);
                }
            }

            // Wypisanie macierzy
            this.DisplayMatrix(this.matrix1, row1, column1, textBoxMatrix1);
            this.DisplayMatrix(this.matrix2, row2, column2, textBoxMatrix2);
        }

        private void DisplayMatrix(int[,] matrix, int row, int column, TextBox textBox)
        {
            textBox.Text = "[";

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    textBox.Text += matrix[i, j] + " ";
                }
                if (i != row - 1)
                {
                    textBox.Text += "\r\n";
                }
            }

            textBox.Text += "]";
        }

        private static void CalculateMatrix(int row1, int column1, int column2, int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
        {
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    for (int k = 0; k < column1; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
        }
    }
}
