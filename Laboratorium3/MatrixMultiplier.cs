using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    internal class MatrixMultiplier
    {
        private int[,] matrix1;
        private int[,] matrix2;
        private volatile int[,] resultMatrix;
        private Random random = new Random();
        private int row1, row2, column1, column2;

        public MatrixMultiplier(int row1, int row2, int column1, int column2)
        {
            this.row1 = row1;
            this.row2 = row2;
            this.column1 = column1;
            this.column2 = column2;
        }

        public void GenerateMatrix(int row1, int column1, int row2, int column2)
        {
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
        }

        public void DisplayMatrix(int[,] matrix, TextBox textBox)
        {
            textBox.Text = "[";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    textBox.Text += matrix[i, j] + " ";
                }
                if (i != matrix.GetLength(0) - 1)
                {
                    textBox.Text += "\r\n";
                }
            }

            textBox.Text += "]";
        }

        public void CalculateMatrix(int startRow, int endRow)
        {
            for (int i = startRow; i < endRow; i++)
            {
                for (int j = 0; j < this.column2; j++)
                {
                    for (int k = 0; k < this.column1; k++)
                    {
                        this.resultMatrix[i, j] += this.matrix1[i, k] * this.matrix2[k, j];
                    }
                }
            }
        }

        public void CalculateMatrixParallel(ParallelOptions opt)
        {
            Parallel.For(0, this.row1, opt, i =>
            {
                for (int j = 0; j < this.column2; j++)
                {
                    for (int k = 0; k < this.column1; k++)
                    {
                        this.resultMatrix[i, j] += this.matrix1[i, k] * this.matrix2[k, j];
                    }
                }
            });
        }

        public int[,] GetMatrix1()
        {
            return this.matrix1;
        }
        
        public int[,] GetMatrix2()
        {
            return this.matrix2;
        }
        
        public int[,] GetResultMatrix()
        {
            return this.resultMatrix;
        }
        
        public bool IsMultiplicationPossible()
        {
            return this.column1 == this.row2;
        }
    }
}
