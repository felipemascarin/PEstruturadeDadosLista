using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEstruturadeDadosLista
{
    internal class ListaAluno
    {
        public Aluno Head { get; set; }
        public Aluno Tail { get; set; }


        public ListaAluno()
        {
            Head = Tail = null;
        }

        private bool Vazia()
        {
            if (Head == null && Tail == null)
                return true;
            else
                return false;
        }



        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Lista está vazia.");
            }
            else
            {
                Aluno aux = Head;
                Console.WriteLine("DADOS DA LISTA");
                do
                {
                    Console.WriteLine(aux.ToString() + "\n");
                    aux = aux.Proximo;
                } while (aux != null);
                Console.WriteLine("FIM DA IMPRESSÃO!");
            }
            Console.WriteLine("PRESSIONE ENTER!");
            Console.ReadKey();
        }


        //A inserção leva em consideração o padrão de ordem alfabética pelo nome do aluno.
        public void Push(Aluno aluno)
        {
            if (Vazia())
            {
                Head = Tail = aluno;
                aluno.Proximo = null;
            }
            else
            {
                //Inserir no final da lista
                if (aluno.Nome.ToUpper().CompareTo(Tail.Nome.ToUpper()) >= 0)
                {
                    Tail.Proximo = aluno;
                    Tail = aluno;

                }
                else
                {
                    //Inserir no inicio da lista
                    if (aluno.Nome.ToUpper().CompareTo(Head.Nome.ToUpper()) < 0)
                    {
                        aluno.Proximo = Head;
                        Head = aluno;
                    }
                    else
                    {
                        Aluno aux1, aux2;
                        aux1 = Head;
                        aux2 = Head;

                        do
                        {
                            if (aluno.Nome.ToUpper().CompareTo(aux1.Nome.ToUpper()) >= 0)
                            {
                                aux2 = aux1;
                                aux1 = aux1.Proximo;
                            }
                            else
                            { 
                                aux2.Proximo = aluno;
                                aluno.Proximo = aux1;
                                break;
                            }
                        } while (aux1 != null);
                    }
                }
            }
        }


        //Buscar um aluno pelo nome
        public Aluno Buscar(string nome)
        {
            {

                if (Vazia())
                {
                    Console.WriteLine("Lista vazia");
                    return null;
                }
                else
                {
                    Aluno aux1 = Head;
                    do
                    {
                        if (aux1.Nome == nome)
                        {
                            return aux1;
                        }
                        aux1 = aux1.Proximo;
                    } while (aux1 != null);
                    return null;
                }
            }
        }

        //Remover um aluno pelo nome
        public void Remover(string nome)
        {
            if (Vazia())
            {
                Console.WriteLine("Lista Vazia!");
                return;
            }
            else
            {
                Aluno aux1, aux2;
                aux1 = aux2 = Head;
                do
                {
                    if (aux1.Nome.Equals(nome))
                    {
                        if (Head == Tail)
                        {
                            Head = Tail = null;
                            return;
                        }
                        else
                        {
                            if (aux1.Proximo == null)
                            {
                                Tail = aux2;
                                return;
                            }
                            else
                            { if (aux1 == Head)
                                {
                                    Head = aux1.Proximo;
                                    return;
                                }
                                else
                                {
                                    aux2.Proximo = aux1.Proximo;
                                    return;
                                }
                                
                            }
                        }
                    }
                    aux2 = aux1;
                    aux1 = aux1.Proximo;
                } while (true);
            }
        }











    }
}

