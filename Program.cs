using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace CS_TP1.Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Iterando sobre uma lista de inteiros:
            //List<int> lista = new List<int> { 1, 2, 3, 4, 5 };
            //IEnumerator<int> enumerador = lista.GetEnumerator();
            //while (enumerador.MoveNext())
            //{
            //    int item = enumerador.Current;
            //    Console.WriteLine(item);
            //}

            ////Iterando sobre um array de strings:
            //string[] nomes = new string[] { "João", "Maria", "Pedro" };
            //IEnumerator<string> enumerador2 = ((IEnumerable<string>)nomes).GetEnumerator();
            //while (enumerador2.MoveNext())
            //{
            //    string item = enumerador2.Current;
            //    Console.WriteLine(item);
            //}

            //MinhaClasse m = new MinhaClasse();
            //IEnumerator<int> meuEnumerador = m.GetEnumerator();
            //while (meuEnumerador.MoveNext())
            //{
            //    int item = meuEnumerador.Current;
            //    Console.WriteLine(item);
            //}            

            //foreach (int i in m)
            //{
            //    Console.WriteLine(i);
            //}

            //ICollection collection = new List<string>();
            //int itens = collection.Count;

            //IList list = new List<bool>();

            //ArrayList nomeDaArrayList = new ArrayList();            

            //nomeDaArrayList.Add("string");
            ////nomeDaArrayList.Add(50);
            ////nomeDaArrayList.Add(10.6F);
            ////nomeDaArrayList.Add(10.6D);
            ////nomeDaArrayList.Add(false);
            ////nomeDaArrayList.Add(null);
            ////nomeDaArrayList.Add('a');

            //for (int i = 0; i < nomeDaArrayList.Count; i++)
            //{
            //    Console.Write($" {nomeDaArrayList[i]}");
            //}

            //Console.WriteLine($"\n{nomeDaArrayList.Count}" );


            List<string> listPets = new();
            List<MinhaClasse> listMinhaClasse = new();

            listPets.Add("Dora");
            listPets.Add("Toby");
            listPets.Add("Penelope");
            listPets.Add("Petisco");
            listPets.Add("Jorge");
            listPets.Add("Minnie");

            foreach(string pet in listPets)
            {
                Console.WriteLine(pet);
            }

            //listPets.Clear();

            List<string> listPets2 = new();
            listPets.Add("Sagui");
            listPets.Add("Lani");

            listPets.AddRange(listPets2);

            Console.WriteLine();
            //foreach (string pet in listPets)
            //{
            //    Console.WriteLine(pet);
            //} 

            listPets.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }    

    public class MinhaClasse : IEnumerable<int>
    {
        public List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

        public IEnumerator<int> GetEnumerator()
        {
            return new MinhaClasseEnumerador(lista);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MinhaClasseEnumerador(lista);
        }

        private class MinhaClasseEnumerador : IEnumerator<int>
        {
            private List<int> lista;
            private int posicao = -1;

            public MinhaClasseEnumerador(List<int> lista)
            {
                this.lista = lista;
            }

            public int Current
            {
                get { return lista[posicao]; }
            }

            object IEnumerator.Current
            {
                get { return lista[posicao]; }
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                posicao++;
                return (posicao < lista.Count);
            }

            public void Reset()
            {
                posicao = -1;
            }
        }
    }
}