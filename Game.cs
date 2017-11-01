using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> res = MySQL.current.getData("SELECT Categorie FROM categorie WHERE idCategorie = " + GameManager.current.CategoryID.ToString());
            lblCategory.Text = res["Categorie"][0];
        }
    }
}
