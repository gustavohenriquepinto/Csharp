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
            #region List
            //lista.Items.Clear();

            ////Array
            //string[] users = { "Gustavo", "Henrique", "Silva" };

            ////Lista Genérica
            //List<string> usersList = new List<string>();

            //usersList.Add("Gabriel");
            //usersList.Add("Davi");
            //usersList.AddRange(users);

            ////if (usersList.Remove(usersList[0]))
            ////{
            ////    MessageBox.Show("O usuário foi removido.");
            ////}
            ////else
            ////{
            ////    MessageBox.Show($"{usersList[0]} não pôde ser removido.");
            ////}

            ////if(usersList.Contains("Davi"))
            ////{
            ////    MessageBox.Show("Contém Davi.");
            ////}
            ////else
            ////{
            ////    MessageBox.Show("Não contém Davi");
            ////}

            ////MessageBox.Show("Apresenta " + usersList.Count + " elementos.");
            ////usersList.Sort();

            ////MessageBox.Show("Davi está no índice: " + usersList.IndexOf("Davi"));

            ////usersList.Clear();

            //usersList.Insert(2, "João");
            //usersList.RemoveAt(5);

            //foreach(string name in usersList)
            //{
            //    lista.Items.Add(name);
            //}
            #endregion
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            #region HashSet
            //lista.Items.Clear();

            //HashSet<string> veiculosHashSet = new HashSet<string>()
            //{
            //    "Carro", "Moto", "Avião","Helicóptero", "Barco"
            //};

            ////if (veiculosHashSet.Add("Bicicleta"))
            ////{
            ////    MessageBox.Show("Um item foi adicionado.");
            ////}
            ////else
            ////{
            ////    MessageBox.Show("Um item não pôde ser adicionado.");
            ////}

            ////if (veiculosHashSet.Contains("Carro"))
            ////{
            ////    MessageBox.Show("Contém carro.");
            ////}
            ////else
            ////{
            ////    MessageBox.Show("Não contém carro.");
            ////}

            ////bool foiRemovido = veiculosHashSet.Remove("Carro");
            ////int quantidadeDeVeiculos = veiculosHashSet.Count;
            ////veiculosHashSet.Clear();
            ////veiculosHashSet.First();
            ////veiculosHashSet.Last();
            ////veiculosHashSet.ElementAt();

            //foreach (string veiculo in veiculosHashSet)
            //{
            //    lista.Items.Add(veiculo);
            //}
            #endregion
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                {25, "Henrique"},
                {80, "Henrique"}
            };

            alunos.Add(100, "Gustavo");
            int quantidadeDeAlunos = alunos.Count;
            bool alunoFoiRemovido = alunos.Remove(80);
            KeyValuePair<int, string> primeiroAluno = alunos.First();
            string ultimoAluno = alunos.Last().Value;
            bool contemChave = alunos.ContainsKey(30);
            bool contemValor = alunos.ContainsValue("Gustavo");
            alunos.Clear();

            foreach (KeyValuePair<int, string> aluno in alunos)
            {
                lista.Items.Add(aluno.Value);
            }
        }
    }
}