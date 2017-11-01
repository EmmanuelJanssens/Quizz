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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Selectionner une catégorie de base et jouer
        /// Ouvrir le formulaire de sélection de pseudonyme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPlay_Click(object sender, EventArgs e)
        {
            AddNewPlayer form = new AddNewPlayer();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();

            GameManager.current.CategoryID = lstCategory.SelectedIndex+1;
        }

        /// <summary>
        /// Lors du chargement du menu principal
        /// Ouvrir la connection
        /// Insérer dans la liste les catégories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Load(object sender, EventArgs e)
        {

            MySQL.current.Connect("localhost", "quizz", "root", "");

            Dictionary<string, List<string>> res = MySQL.current.getData("SELECT * from categorie");
            List<string> test = new List<string>(res.Keys);
            for (int i = 0; i < res["Categorie"].Count; i++)
            {
                lstCategory.Items.Add( res["Categorie"][i] );
            }

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySQL.current.Close();
        }


    }
}
