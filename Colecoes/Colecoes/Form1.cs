using System.Xml.Linq;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            //Array
            string[] users = new string[3];
            users[0] = "Gustavo";
            users[1] = "Henrique";
            users[2] = "Silva";

            //Lista Genérica
            List<string> usersList = new List<string>();

            usersList.Add("Gabriel");
            usersList.Add("Davi");
            usersList.AddRange(users);

            //if (usersList.Remove(usersList[0]))
            //{
            //    MessageBox.Show("O usuário foi removido.");
            //}
            //else
            //{
            //    MessageBox.Show($"{usersList[0]} não pôde ser removido.");
            //}

            //if(usersList.Contains("Davi"))
            //{
            //    MessageBox.Show("Contém Davi.");
            //}
            //else
            //{
            //    MessageBox.Show("Não contém Davi");
            //}

            //MessageBox.Show("Apresenta " + usersList.Count + " elementos.");
            //usersList.Sort();

            //MessageBox.Show("Davi está no índice: " + usersList.IndexOf("Davi"));

            //usersList.Clear();

            usersList.Insert(2, "João");
            usersList.RemoveAt(5);

            foreach(string name in usersList)
            {
                lista.Items.Add(name);
            }
            
        }
    }
}