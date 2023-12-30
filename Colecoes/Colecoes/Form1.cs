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
            //lista.Items.Clear();

            //string[] users = { "Gustavo", "Henrique", "Silva" };

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
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
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
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            //lista.Items.Clear();

            //Dictionary<int, string> alunos = new Dictionary<int, string>()
            //{
            //    {25, "Henrique"},
            //    {80, "Henrique"}
            //};

            //alunos.Add(100, "Gustavo");
            //int quantidadeDeAlunos = alunos.Count;
            //bool alunoFoiRemovido = alunos.Remove(80);
            //KeyValuePair<int, string> primeiroAluno = alunos.First();
            //string ultimoAluno = alunos.Last().Value;
            //bool contemChave = alunos.ContainsKey(30);
            //bool contemValor = alunos.ContainsValue("Gustavo");
            //alunos.Clear();

            //foreach (KeyValuePair<int, string> aluno in alunos)
            //{
            //    lista.Items.Add(aluno.Value);
            //}
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            //lista.Items.Clear();
            //SortedList<int, string> alunos = new SortedList<int, string>()
            //{
            //    {30,"Gustavo" },
            //    {15,"Lucas" },
            //    {80, "Eu" }
            //};

            //alunos.Add(35, "Maria");
            //alunos.Add(38, "Maria");
            //alunos.Remove(38);
            //alunos.RemoveAt(2);


            //foreach (KeyValuePair<int, string> aluno in alunos.Reverse())
            //{
            //    lista.Items.Add(aluno);
            //}
        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            //SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            //{
            //    {4512, "Gustavo" },
            //    {134, "Henrique" }
            //};

            //alunos.Add(2412, "Maria");
            //bool foiRemovido = alunos.Remove(10);
            //int quantidadeAlunos = alunos.Count;
            //bool contemValor = alunos.ContainsValue("j3iuf");
            //bool contemChave = alunos.ContainsKey(245);
            //alunos.Clear();
            //KeyValuePair<int, string> parChaveValor = alunos.ElementAt(0);

            //foreach (KeyValuePair<int, string> aluno in alunos)
            //{
            //    lista.Items.Add(aluno);
            //}
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            //lista.Items.Clear();

            //SortedSet<string> nomes = new SortedSet<string>()
            //{
            //    "Gustavo", "Maria", "Alberto", "Pedro", "Carlos"
            //};

            //if (nomes.Add("Lucas"))
            //{
            //    MessageBox.Show("Lucas foi adicionado");
            //}
            //else
            //{
            //    MessageBox.Show("Já contém Lucas");
            //}

            //foreach (string nome in nomes)
            //{
            //    lista.Items.Add(nome);
            //}

        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            //lista.Items.Clear();

            //Queue<string> fila = new Queue<string>();
            //fila.Enqueue("Gustavo");
            //fila.Enqueue("Henrique");
            //fila.Enqueue("Silva");

            ////MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show(fila.Peek());
            //MessageBox.Show(fila.Dequeue());
            //MessageBox.Show(fila.First());
            //MessageBox.Show(fila.Last());


            //foreach (string item in fila)
            //{
            //    lista.Items.Add(item);
            //}
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            Stack<string> pilha = new Stack<string>();
            pilha.Push("Gustavo");
            pilha.Push("Henrique");
            pilha.Push("Silva");

            MessageBox.Show(pilha.Peek());

            foreach(string nomes in pilha)
            {
                lista.Items.Add(nomes);
            }
        }
    }
}