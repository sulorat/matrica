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

        static IEnumerable<object[]> arr1()
        {
            return new[] {
            new []{ new[,] {
                    { 2.0, 3.0, 5.0, 6.0, 16.0 },
                    { 9.0, 7.6, 3.7, 9.9, 7.5 },
                    { 1.5, 5.8, 7.1, 1.5, 1.9 },
                    { 0.7, 2.34, 5.6, 1.22, 1.55 }
            }
            }
        };
        }

        static IEnumerable<object[]> arr2()
        {
            return new[] {
            new []{ new[,]
            {
                { 2.5, 2.0, 1.0 },
                { 2.5, 2.0, 1.0 },
                { 2.5, 2.0, 1.0 },
                { 2.5, 3.0, 1.0 }
            } }
        };
        }

        static IEnumerable<object[]> arr3()
        {
            return new[] {
            new []{ new[,]
            {
                { 2.5, 2.0, 1.0, 2.2 },
                { 2.5, 2.3, 9.0, 5.2 },
                { 2.0, 2.0, 1.6, 1.5 }
            } }
        };
        }

        static IEnumerable<object[]> arrToShow1()
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

        static IEnumerable<object[]> arrToShow2()
        {
            return new[] {
            new object[]
            {
                new[,]
                {
                    { 2.5, 2.0, 1.0 },
                    { 2.5, 2.0, 1.0 },
                    { 2.5, 2.0, 1.0 },
                    { 2.5, 3.0, 1.0 }
                },
                "2,5 2 1 \n2,5 2 1 \n2,5 2 1 \n2,5 3 1 \n"
            }
        };
        }

        static IEnumerable<object[]> arrToShow3()
        {
            return new[] {
            new object[]
            {
                new[,]
                {
                    { 2.5, 2.0, 1.0, 2.2 },
                    { 2.5, 2.3, 9.0, 5.2 },
                    { 2.0, 2.0, 1.6, 1.5 }
                },
                "2,5 2 1 2,2 \n2,5 2,3 9 5,2 \n2 2 1,6 1,5 \n"
            }
        };
        }
    }
    }

