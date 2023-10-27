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

            lista.Items.Add(usersList[0]);
            lista.Items.Add(usersList[1]);
            lista.Items.Add(usersList[2]);
            lista.Items.Add(usersList[3]);
            lista.Items.Add(usersList[4]);
        }
    }
}