using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _135_File_BinaryFormatter
{
    [Serializable]
    struct Player
    {
        public string _Name;
        public int _Level;
        public double _Exp;
    }
    class Program
    {
        const string fileName = "savePlayer.txt";
        static void Main(string[] args)
        {
            Player[] player = new Player[2];

            player[0]._Name = "aaa"; 
            player[0]._Level = 10;
            player[0]._Exp = 5400;

            player[1]._Name = "bbb"; 
            player[1]._Level = 99;
            player[1]._Exp = 53460;

            //쓰기
            FileStream fsw = new FileStream(fileName, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fsw, player);

            fsw.Close();

            //읽기
            FileStream fsr = new FileStream(fileName, FileMode.Open);

            BinaryFormatter bf2 = new BinaryFormatter();
            Player[] readPlayer = (Player[])bf2.Deserialize(fsr);

            for (int i = 0; i < readPlayer.Length; i++)
            {
                Console.WriteLine("Name: " + readPlayer[i]._Name);
                Console.WriteLine("Level: " + readPlayer[i]._Level);
                Console.WriteLine("Exp: " + readPlayer[i]._Exp);
            }
            fsr.Close();
        }
    }
}
