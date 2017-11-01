using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    class GameManager
    {
        public static GameManager current;

        public int CategoryID { get; set; }
        public int QuestionID { get; set; }
        public string CurrentPlayer { get; set; }

        public GameManager()
        {
            if (current == null)
                current = this;
        }

        public static void Init()
        {
            if (current == null)
                current = new GameManager();

            MySQL.Init();
        }


    }
}
