using System.Xml.Serialization;
using c_propriedades_metodos_construtores.Models;



Pessoa p1 = new Pessoa(nome: "Bruna",sobrenome: "Garstka");
Pessoa p2 = new Pessoa(nome: "David",sobrenome: "Garstka");
Pessoa p3 = new Pessoa(nome: "Geovanna",sobrenome: "Garstka");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(p1);
cursoDeIngles.AdicionarAlunos(p2);
cursoDeIngles.AdicionarAlunos(p3);
cursoDeIngles.ListarAlunos();



/*p1.Idade = 17;
p1.apresentar();*/