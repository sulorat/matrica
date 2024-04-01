using matrica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestMatrix
{
    [TestClass]
    public class UnitTest1
    {
    
        private Matrix _matrix;
        private Matrix _secMatrix;


        static IEnumerable<object[]> array1()
        {
            return new[] {
            new []{ new[,] 
            {
                    { 1.0, 2.0, 3.0, 4.0, 5.0 },
                    { 6.0, 3.6, 4.7, 5.9, 6.5 },
                    { 5.5, 8.8, 3.1, 2.5, 9.9 },
                    { 1.7, 2.3, 8.6, 5.22, 6.44 }
            }
            }
        };
        }

        static IEnumerable<object[]> array2()
        {
            return new[] {
            new []{ new[,]
            {
                { 1.0, 2.0, 3.0 },
                { 2.5, 2.6, 5.0 },
                { 4.5, 2.0, 1.6 },
                { 6.5, 3.0, 1.0 }
            } 
            }
        };
        }

        static IEnumerable<object[]> array3()
        {
            return new[] {
            new []{ new[,]
            {
                { 1.5, 2.0, 1.0, 2.2 },
                { 2.5, 2.3, 9.0, 5.2 },
                { 3.5, 2.0, 1.6, 1.5 }
            } 
            }
        };
        }

        static IEnumerable<object[]> incorrect_array()
        {
            return new[] {
            new []{ new[,]
            {
                { 3, 0, 1.0, 2.2 },
                { 5, 3, 9.0, 5.2 },
                { 6, 2.0, 1.6, 1.5 }
            }
            }
        };
        }


        static IEnumerable<object[]> array_output1()
        {
            return new[] {
            new object[]
            {
                new[,]
                {
                    { 2.0, 3.0, 5.0, 6.0, 16.0 },
                    { 9.0, 7.6, 3.7, 9.9, 7.5 },
                    { 1.5, 5.8, 7.1, 1.5, 1.9 },
                    { 0.7, 2.34, 5.6, 1.22, 1.55 }
                },
                "2 3 5 6 16 \n9 7,6 3,7 9,9 7,5 \n1,5 5,8 7,1 1,5 1,9 \n0,7 2,34 5,6 1,22 1,55 \n"
            }
        };
        }

        static IEnumerable<object[]> array_output2()
        {
            return new[] {
            new object[]
            {
                new[,]
                {
                    { 2.5, 2.0, 1.0 },
                    { 3.5, 3.0, 2.0 },
                    { 4.5, 4.0, 3.0 },
                    { 5.5, 5.0, 4.0 }
                },
                "2,5 2 1 \n3,5 3 2 \n4,5 4 3 \n5,5 5 4 \n"
            }
        };
        }

        static IEnumerable<object[]> array_output3()
        {
            return new[] {
            new object[]
            {
                new[,]
                {
                    { 2.5, 2.0, 1.0, 2.2 },
                    { 3.5, 2.3, 1.6, 1.7 },
                    { 4.5, 6.0, 1.6, 1.5 }
                },
                "2,5 2 1 2,2 \n3,5 2,3 1,6 1,7 \n4,5 6 1,6 1,5 \n"
            }
        };
        }

        static IEnumerable<object[]> SummArray1()
        {
            return new[]
            {
            new[]
            {
                new[,]
                {
                    { 3.0, 2.0, 8.0, 6.5 },
                    { 2.0, 5.0, 6.0, 8.5 },
                    { 4.0, 6.0, 5.0, 10.5 },
                    { 1.0, 3.0, 5.5, 1.0 }
                },
                new[,]
                {
                    { 2.5, 1.1, 1.2, 1.3 },
                    { 3.5, 2.5, 9.0, 10.0 },
                    { 4.5, 2.0, 8.7, 6.8 },
                    { 5.5, 8.3, 1.2, 2.0 }
                },
                new[,]
                {
                    { 5.5, 3.1, 9.2, 7.8 },
                    { 5.5, 7.5, 15.0, 18.5 },
                    { 8.5, 8.0, 13.7, 17.3 },
                    { 6.5, 11.3, 6.7, 3.0 }
                }
            }
        };
        }

        static IEnumerable<object[]> SummArray2()
        {
            return new[]
            {
            new[]
            {
                new[,]
                {
                    { 10.0, 8.1, 18.0 },
                    { 12.0, 5.5, 8.5 },
                    { 11.0, 5.0, 2.0 }
                },
                new[,]
                {
                    { 2.0, 3.5, 4.0 },
                    { 5.0, 1.0, 8.9 },
                    { 4.5, 1.8, 5.1 }
                },
                new[,]
                {
                    { 12.0, 11.6, 22.0 },
                    {17.0, 6.5, 17.4},
                    { 15.5, 6.8, 7.1 }
                }
            }
        };
        }

        static IEnumerable<object[]> Multuplyarr1()
        {
            return new[]
            {
            new[]
            {
                new[,]
                {
                    { 2, 3.5, 4.7 },
                    { 5.34, 126.7, 8.9 },
                    { 4.1, 1.8, 10.4 }
                },
                new[,]
                {
                    { 38.9, 80.9, 18.8 },
                    { 95.3, 7.5, 68.5 },
                    { 11.2, 95.2, 2.6 }
                },
                new[,]
                {
                    {463.99,635.49,289.57},
                    {12381.92, 2229.54, 8802.48},
                    {447.51, 1335.27, 227.42}
                }
            }
        };
        }

        static IEnumerable<object[]> Multuplyarr2()
        {
            return new[]
            {
            new[]
            {
                new[,]
                {
                    { 3.0, 2.0, 1.0, 6.5 },
                    { 3.0, 2.0, 6.0, 8.3 },
                    { 3.0, 2.0, 5.0, 10.0 },
                    { 1.0, 3.1, 5.5, 1.0 }
                },
                new[,]
                {
                    { 2.5, 1.1, 1.0, 1.0 },
                    { 3.5, 2.2, 9.0, 10.0 },
                    { 7.5, 2.0, 8.7, 6.8 },
                    { 9.6, 8.3, 1.2, 2.0 }
                },
                new[,]
                {
                    {84.4, 63.65, 37.5, 42.8},
                    {139.18, 88.59, 83.16, 80.4},
                    {148.0, 100.7, 76.5, 77.0},
                    {64.2, 27.22, 77.95, 71.4}
                }
            }
        };
        }
        //---------------------------------------1
        [TestMethod]
        [DataRow(10, 10)]
        [DataRow(5, 5)]
        [DataRow(3, 3)]
        [DataRow(7, 8)]

        public void RowsColmsEqual(int rows1, int cols1)
        {
            _matrix = new Matrix(rows1, cols1);
            Assert.AreEqual(_matrix.CountCols, cols1,"Коллоны не равны" );
            Assert.AreEqual(_matrix.CountRows, rows1, "Строки не равны");
        }


        //-----------------------------------2
        [TestMethod]
        [DynamicData(nameof(array1), DynamicDataSourceType.Method)]
        [DynamicData(nameof(array2), DynamicDataSourceType.Method)]
        [DynamicData(nameof(array3), DynamicDataSourceType.Method)]
        [DynamicData(nameof(incorrect_array), DynamicDataSourceType.Method)]
        public void CorrectCharacteristics(double[,] arr)
        {
            _matrix = new Matrix(arr);
            if(_matrix==null)
                Assert.Fail("В матрицу нужно передавать только двумерный массив чисел");
            Console.WriteLine(_matrix.ToString());
            Assert.IsTrue(_matrix != null);
        }


        //---------------------------------------3
        [TestMethod]
        [DynamicData(nameof(array_output1), DynamicDataSourceType.Method)]
        [DynamicData(nameof(array_output2), DynamicDataSourceType.Method)]
        [DynamicData(nameof(array_output3), DynamicDataSourceType.Method)]

        public void ShowMatrix(double[,] matrix, string expected)
        {
            _matrix = new Matrix(matrix);
            Console.WriteLine(_matrix.ToString());
            Assert.AreEqual(expected, _matrix.ToString(), "Матрица выведена некорректно!");
        }

        //-------------------------------------4
        [TestMethod]
        [DataRow(10, 10, 8, 8)]
        [DataRow(8, 10, 7, 7)]
        [DataRow(11, 11, 6, 6)]

        public void RowsColmsNotEqualSum(int rows1, int cols1, int rows2, int cols2)
        {
            _matrix = new Matrix(rows1, cols1);
            _secMatrix = new Matrix(rows2, cols2);
            Matrix.Summ(_matrix, _secMatrix);
        }


        //-----------------------------------------------5

        [TestMethod]
        [DynamicData(nameof(SummArray1), DynamicDataSourceType.Method)]
        [DynamicData(nameof(SummArray2), DynamicDataSourceType.Method)]

        public void SumMat(double[,] arr1, double[,] arr2, double[,] expected)
        {
            _matrix = new Matrix(arr1);
            _secMatrix = new Matrix(arr2);
            Matrix expectedMatrix = new Matrix(expected);

            Matrix result = Matrix.Summ(_matrix, _secMatrix);
            Console.WriteLine(result.ToString());
            Assert.AreEqual(expectedMatrix.ToString(), result.ToString(), "неправильный подсчёт");
        }

        //-----------------------------------------6

        [TestMethod]
        [DataRow(10, 10, 8, 8)]
        [DataRow(8, 10, 7, 7)]

        public void RowsColmsNotEqualMul(int rows1, int cols1, int rows2, int cols2)
        {
            _matrix = new Matrix(rows1, cols1);
            _secMatrix = new Matrix(rows2, cols2);
            Matrix.Multiply(_matrix, _secMatrix);
        }


        //------------------------------------7


        [TestMethod]
        [DataRow(10, 10, 10, 10)]
        [DataRow(5, 5, 5, 5)]

        public void ResultSizeEqual(int rows1, int cols1, int rows2, int cols2)
        {
            _matrix = new Matrix(rows1, cols1);
            _secMatrix = new Matrix(rows2, cols2);

            Matrix result = Matrix.Multiply(_matrix, _secMatrix);
            Assert.AreEqual(result.CountCols, rows2);
            Assert.AreEqual(result.CountRows, cols1);
        }


        //----------------------------------8


        [TestMethod]
        [DynamicData(nameof(Multuplyarr1), DynamicDataSourceType.Method)]
        [DynamicData(nameof(Multuplyarr2), DynamicDataSourceType.Method)]

        public void MultiplyMat(double[,] arr1, double[,] arr2, double[,] expected)
        {
            _matrix = new Matrix(arr1);
            _secMatrix = new Matrix(arr2);
            Matrix expectedMatrix = new Matrix(expected);

            Matrix result = Matrix.Multiply(_matrix, _secMatrix);
            Console.WriteLine(result.ToString());
            Assert.AreEqual(expectedMatrix.ToString(), result.ToString(), "неправильный подсчёт");
        }

    }
    }

