using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CheckPoint03_1
{
    class Program
    {
        const int MAXX = 7;
        const int MAXY = 22;

        static void UpdateGo(int[] _arrIndexX,int[,] _map)
        {
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                int indexX = i + 1;
                int indexY = _arrIndexX[i];

                int temp = _map[indexX, indexY];
                _map[indexX, indexY + 1] = temp;
                _map[indexX, indexY] = 0;

                _arrIndexX[i]++;

            }
        }
        static void ClearView()
        {
            Thread.Sleep(300);
            Console.Clear();
        }

        static void UpdateView(char[] _tile,int[,] _map)
        {
            for (int i = 0; i < MAXX; i++)
            {
                for (int j = 0; j < MAXY; j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write(_tile[tileIndex]);

                    if (j == MAXY - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }

        }
        static bool UpdateRandomGo(int[] _arrIndexX, int[,] _map,Random _rnd)
        {
            bool isFinish = false;
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                if (_arrIndexX[i] >= 20)
                {
                    isFinish = true;
                    break;
                }
            }

            int indexRnd = _rnd.Next(0, 5);
            int _indexY = _arrIndexX[indexRnd];

            int _temp = _map[indexRnd + 1, _indexY];
            _map[indexRnd + 1, _indexY + 1] = _temp;
            _map[indexRnd + 1, _indexY] = 0;

            _arrIndexX[indexRnd]++;

            return isFinish;
        }

        static bool ResultView(bool isFinish, int[] _arrIndexX, int[,] _map)
        {
            if (isFinish)
            {
                Console.WriteLine();
                for (int i = 0; i < _arrIndexX.Length; i++)
                {
                    if (_arrIndexX[i] >= 20)
                    {
                        Console.Write("달리기 결과 1등은 {0}입니다.", (i + 1));
                        break;
                    }
                }
                Console.Write("\n다시 시작하려면 0을 입력");
                string inputStr = Console.ReadLine();

                if (inputStr == "0")
                {
                    for (int i = 0; i < _arrIndexX.Length; i++)
                    {
                        int indexY = _arrIndexX[i];
                        _map[(i + 1), indexY] = 0;

                    }

                    for (int i = 0; i < _arrIndexX.Length; i++)
                    {
                        _arrIndexX[i] = 0;
                    }

                    for (int i = 0; i < _arrIndexX.Length; i++)
                    {
                        _map[(i + 1), 20] = 2;
                        _map[(i + 1), 0] = i + 3;
                    }
                    return false;
                }
                else
                {
                    Console.Write("\n나가기\n");
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
                           //0    1    2    3    4    5    6    7
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[MAXX, MAXY]
            {
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
                {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                {4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                {5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                {6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                {7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }
            };

            

            int[] arrIndexX = { 0, 0, 0, 0, 0 };
            bool isFinish = false;
            bool isResult = false;
            while (true)
            {
                UpdateView(tile, map);
                UpdateGo(arrIndexX, map);
                isFinish = UpdateRandomGo(arrIndexX,map,rnd);
                isResult=ResultView(isFinish,arrIndexX,map);
                if (isResult)
                {
                    break;
                }
                ClearView();




            }

        }
    }
}
