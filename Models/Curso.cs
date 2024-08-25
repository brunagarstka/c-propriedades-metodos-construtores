using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace c_propriedades_metodos_construtores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public void AdicionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados() //nescessario ter return no int 
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAlunos(Pessoa aluno) //nescessario ter return no bool
        {
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}