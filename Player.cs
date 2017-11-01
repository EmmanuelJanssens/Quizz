using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    class Player
    {

        string _Name;
        int _Score;

        public string Name { get { return _Name; } set { _Name = value; } }
        public int Score { get { return _Score; } }

        public Player()
        {
            _Name = "";
            _Score = 0;
        }
        public Player(string nom)
        {
            _Name = nom;
            _Score = 0;
        }
        public Player(string nom,int score)
        {
            _Name = nom;
            _Score = score;
        }

        public void addScore(int score)
        {
            _Score += score;
        }
    }
}
