﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrica
{
    public class Matrix
    {
        private int _CountRows, _CountCols;
        private double[,] _Matrix;
        Random _Random = new Random();

       

        public Matrix(double[,] matrix)
        {
            _Matrix = matrix;
            CountRows = _Matrix.GetLength(0);
            CountCols = _Matrix.GetLength(1);
        }

        public Matrix(int rows, int columns)
        {
            double[,] result = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = _Random.NextDouble();
                }
            }
            _Matrix = result;
            CountRows = rows;
            CountCols = columns;
        }
        public int CountRows
        {
            get => _CountRows;
            set => _CountRows = value;
        }

        public int CountCols
        {
            get => _CountCols;
            set => _CountCols = value;
        }
        public override string ToString()
        {
            StringBuilder builderMatrix = new StringBuilder();
            for (int i = 0; i < _Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _Matrix.GetLength(1); j++)
                {
                    builderMatrix.Append(Math.Round(_Matrix[i, j], 2) + " ");
                }
                builderMatrix.Append("\n");
            }
            return builderMatrix.ToString();
        }

        
        public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.CountRows != matrix2.CountRows || matrix1.CountCols != matrix2.CountCols)
            {
                throw new ArithmeticException("Разное количество строк и столбцов");
            }

            Matrix result = new Matrix(matrix1.CountRows, matrix1.CountCols);

            for (int i = 0; i < matrix1.CountRows; i++)
            {
                for (int j = 0; j < matrix1.CountCols; j++)
                {
                    result._Matrix[i, j] = Math.Round(matrix1._Matrix[i, j] + matrix2._Matrix[i, j], 2);
                }
            }

            return result;
        }

        public static Matrix Summ(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.CountCols != matrix2.CountRows)
            {
                throw new ArithmeticException("Разное количество строк и столбцов");
            }

            Matrix result = new Matrix(matrix1.CountRows, matrix2.CountCols);

            for (int i = 0; i < matrix1.CountRows; i++)
            {
                for (int j = 0; j < matrix2.CountCols; j++)
                {
                    for (int k = 0; k < matrix1.CountCols; k++)
                    {
                        result._Matrix[i, j] += Math.Round(matrix1._Matrix[i, k] * matrix2._Matrix[k, j], 2);
                    }
                }
            }

            return result;
        }


    }
}
