using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pac_man
{
    internal class Scoreboard
    {
        public int score;
        public string name;
        string stringData;
        string path = "scoreboard.txt";
        public List<string> players;
        string contents;


        public void AddToFile()
        {
            if (File.Exists(path))
            {
            stringData = "," + name + " - " + score.ToString();
            File.AppendAllText(path, stringData);
            }
            else
            {
                MessageBox.Show("no scoreboard file");
            }
        }

        public void ReadFile()
        {
            contents = File.ReadAllText(path);
            players = contents.Split(",").ToList();
        }
    }
}
