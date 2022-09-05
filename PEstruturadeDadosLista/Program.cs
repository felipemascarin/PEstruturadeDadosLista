using System;

namespace PEstruturadeDadosLista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListaAluno lista = new ListaAluno();
            Aluno aluno = new Aluno(123, "Luís", 30, "ADS");
            lista.Push(aluno);
            aluno = new Aluno(124, "Zaza", 25, "Engenharia Elétrica");
            lista.Push(aluno);

            lista.Push(new Aluno(125, "Antenor", 40, "Engenharia Civil"));
            lista.Push(new Aluno(126, "Brenda", 20, "Educação Física"));
            lista.Push(new Aluno(127, "Brendo", 20, "Agronomia"));
            lista.Print();

            Console.WriteLine("\nDigite o nome a ser localizado na lista: ");
            string nome = Console.ReadLine();

            Aluno encontrado = lista.Buscar(nome);

            if (encontrado == null)
                Console.WriteLine("Não Localizado");
            else Console.WriteLine(encontrado.ToString());


            Console.WriteLine("\nDigite o nome a ser Removido da lista: ");
            string remover = Console.ReadLine();
            lista.Remover(remover);

            lista.Print();




            //Remover
            //- 1o.Elemento(HEAD)
            //- Ultimo Elemento(TAIL)
            //- No meio
            //- VAZIA
            //Tamanho
            //Localizar



        }
    }
}
