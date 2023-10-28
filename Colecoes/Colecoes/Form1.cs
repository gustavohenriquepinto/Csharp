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

            //Lista Gen�rica
            List<string> usersList = new List<string>();

            usersList.Add("Gabriel");
            usersList.Add("Davi");
            usersList.AddRange(users);

            //if (usersList.Remove(usersList[0]))
            //{
            //    MessageBox.Show("O usu�rio foi removido.");
            //}
            //else
            //{
            //    MessageBox.Show($"{usersList[0]} n�o p�de ser removido.");
            //}

            //if(usersList.Contains("Davi"))
            //{
            //    MessageBox.Show("Cont�m Davi.");
            //}
            //else
            //{
            //    MessageBox.Show("N�o cont�m Davi");
            //}

            //MessageBox.Show("Apresenta " + usersList.Count + " elementos.");
            //usersList.Sort();

            //MessageBox.Show("Davi est� no �ndice: " + usersList.IndexOf("Davi"));

            //usersList.Clear();

            usersList.Insert(2, "Jo�o");
            usersList.RemoveAt(5);

            foreach(string name in usersList)
            {
                lista.Items.Add(name);
            }
            
        }
    }
}