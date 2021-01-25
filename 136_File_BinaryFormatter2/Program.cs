using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _136_File_BinaryFormatter2
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
        const string fileName = "list.dat";
        static void Main(string[] args)
        {
            List<Player> listPlayers = new List<Player>();

            for (int i = 0; i < 10; i++)
            {
                Player player = new Player();
                player._Name = i.ToString();
                player._Level = i;
                player._Exp = i * 10;

                listPlayers.Add(player);
            }

            //쓰기
            FileStream fsw = new FileStream(fileName, FileMode.Create);

            BinaryFormatter bfw = new BinaryFormatter();
            bfw.Serialize(fsw, listPlayers);

            fsw.Close();

            //읽기
            FileStream fsr = new FileStream(fileName, FileMode.Open);

            BinaryFormatter bfr = new BinaryFormatter();
            List<Player> readPlayer = (List<Player>)bfr.Deserialize(fsr);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Name: " + readPlayer[i]._Name);
                Console.WriteLine("Level: " + readPlayer[i]._Level);
                Console.WriteLine("Exp: " + readPlayer[i]._Exp);

            }
            fsr.Close();
        }
    }
}
