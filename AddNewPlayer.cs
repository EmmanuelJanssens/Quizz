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
    public partial class AddNewPlayer : Form
    {
        public AddNewPlayer()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();

            MySQL.current.Insert("joueur(Nom)",txtPseudo.Text);
            GameManager.current.CurrentPlayer = txtPseudo.Text;

            this.Dispose();
        }

        private void txtPseudo_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> res = MySQL.current.getData("SELECT Nom FROM joueur WHERE Nom =\"" + txtPseudo.Text+"\"");
            string status = "";
            if (res["Nom"].Count > 0)
            {
                status = "Indisponible";
                cmdOK.Enabled = false;
            }
            else
            {
                status = "Disponible";
                cmdOK.Enabled = true;

            }
            lblPseudo.Text = "Inserez votre Pseudo : " + status;

        }
    }
}
