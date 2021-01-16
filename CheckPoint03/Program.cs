using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


// CheckPoint03 - 배열을 활용하기
namespace CheckPoint03
{
    class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 300;
        static void UpdateView(char[] _tile, int[,] _map)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write(_tile[tileIndex]);

                    if (j == MAP_Y - 1)
                        Console.WriteLine();
                }
            }
        }
        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }
        static void UpdateGo(int[] _arrIndexX, int[,] _map)
        {
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                int indexMapX = i + 1;
                int indexY = _arrIndexX[i];

                int temp = _map[indexMapX, indexY]; // temp=3    
                _map[indexMapX, indexY + 1] = temp;
                _map[indexMapX, indexY] = 0;

                _arrIndexX[i]++;
            }
        }

        static bool UpdateRandomGo(int[] _arrIndexX, int[,] _map , Random _rnd)
        {
            bool isFinish = false;
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                if (_arrIndexX[i] >= 19)
                {
                    isFinish = true;
                    break;
                }
            }
            int rndIndex = _rnd.Next(0, 5); // 0 ~ 4

            int indexY = _arrIndexX[rndIndex];

            int temp = _map[rndIndex + 1, indexY]; // rndIndex가 0일 경우 map[1,???]  1일 경우 map[2,??]  
            _map[rndIndex + 1, indexY + 1] = temp;
            _map[rndIndex + 1, indexY] = 0;

            _arrIndexX[rndIndex]++;

            return isFinish;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            //               0    1    2    3    4    5    6    7
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[MAP_X, MAP_Y]
            {
                // 0  1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20 21
                  {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, //0
                  {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0},
                  {4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0},
                  {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0},
                  {6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0},
                  {7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0},
                  {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} //0

            };

            int[] arrIndexX = { 0, 0, 0, 0, 0 };
            bool isFinish = false;
            while (true)
            {                          
                UpdateGo(arrIndexX,map);
                isFinish = UpdateRandomGo(arrIndexX, map, rnd);               
                UpdateView(tile, map);

                if (isFinish)
                {
                    Console.WriteLine();
                    for (int i = 0; i < arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] >= 19)
                        {
                            Console.Write("달리기 결과 => 1등 : {0}", (i + 1));
                            break;
                        }
                    }
                    Console.Write("\n다시 시작하려면 0을 입력");
                    string inputStr = Console.ReadLine();

                    if (inputStr == "0")
                    {
                        map[1, arrIndexX[0]] = 0;
                        map[2, arrIndexX[1]] = 0;
                        map[3, arrIndexX[2]] = 0;
                        map[4, arrIndexX[3]] = 0;
                        map[5, arrIndexX[4]] = 0;

                        arrIndexX[0] = 0;
                        arrIndexX[1] = 0;
                        arrIndexX[2] = 0;
                        arrIndexX[3] = 0;
                        arrIndexX[4] = 0;

                        map[1, 20] = 2;
                        map[2, 20] = 2;
                        map[3, 20] = 2;
                        map[4, 20] = 2;
                        map[5, 20] = 2;

                        map[1, 0] = 3;
                        map[2, 0] = 4;
                        map[3, 0] = 5;
                        map[4, 0] = 6;
                        map[5, 0] = 7;
                    }
                    else
                    {
                        Console.Write("\n나가기");
                        break;
                    }
                }
                ClearView();
            }

        }
    }
}
