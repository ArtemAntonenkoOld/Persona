using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cons
{
    class Program
    {
        static int[][] baseArray;
        static List<int[]> matrixCords = new List<int[]>();
        static List<int[][]> matrixArray = new List<int[][]>();
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            baseArray = new int[size][];
            for(int i = 0; i < size; i++)
            {
                baseArray[i] = new int[size];
            }
            SetArray();
            PrintArray(baseArray);
            Console.WriteLine();
            //LeftTopMatrixs(2,2,size);
            Console.WriteLine("-----------------------------------------------------------------------------");
            LeftBottomMatrixs(2, 2, size);
            foreach (var item in matrixArray)
            {
                PrintArray(item);
                Console.WriteLine();
            }

            Console.Read();
        }
        static int[][] SetSmallArray(int leftDownXPoint,int LeftDownYPoint,int rightUpXPoint,int rightUpYPoint)
        {
            int[][] arr=new int[Math.Abs(rightUpXPoint-leftDownXPoint)][];
            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = new int[Math.Abs(rightUpYPoint - LeftDownYPoint)];
            }
            int z = 0;
            int l = 0;
            for (int k= rightUpYPoint; k< LeftDownYPoint; k++)
            {
                for (int q = leftDownXPoint; q < rightUpXPoint; q++)
                {
                    arr[z][l] = baseArray[q][k];
                    z++;
                }
                l++;
                z = 0;
            }

            return arr;
        }
        static void PrintArray(int[][] arr)
        {
            foreach (var item in arr)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2);
                }
                Console.WriteLine();
            }
        }
        static void SetArray()
        {
            Random r = new Random();
            for (int i=0; i < baseArray.Length;i++)
            {
                for (int j = 0; j < baseArray[i].Length; j++)
                {
                    baseArray[i][j] = r.Next(0,10);
                }
            }

        }
        static void LeftTopMatrixs(int pointX,int pointY,int size) {
            int z = 0;
            int k = 0;
            for (int i = 0; i < pointX; i++) {
                for (int j=0;j<pointY;j++) {
                    int[] ar = new int[4] { j, pointY, pointX, i };
                    if (matrixCords.Exists(p=>p.Equals(ar))==false) {
                        matrixArray.Add(SetSmallArray(j, pointY, pointX, i));
                        matrixCords.Add(ar);
                    }
                    z++;
                }
                k++;
                z = 0;
            }
        }
        static void LeftBottomMatrixs(int pointX, int pointY, int size)
        {
            int z = 0;
            int k = 0;
            for (int i = 0; i < pointX; i++)
            {
                for (int j = pointY; j < size; j++)
                {
                    int[] ar = new int[4] { i, j, pointX, pointY };
                    if (matrixCords.Exists(p => p.Equals(ar)) == false)
                    {
                        matrixArray.Add(SetSmallArray(i, j, pointX, pointY));
                        matrixCords.Add(ar);
                    }
                    z--;
                }
                k++;
                z = 0;
            }
        }
        static void RightTopMatrixs() { }
        static void RightBottomMatrixs() { }
    }
}
