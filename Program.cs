using System.Xml.Serialization;
using c_propriedades_metodos_construtores.Models;
using System.Globalization;
using System.Data;

string dataString = "2024-08-28 22:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");                                                        //MM maiusculo representa mes, e mm minusculo é minuto
}
else 
{
    Console.WriteLine($"{dataString} não é uma data valida");
}




/*CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
decimal valorMonetario = 1082.40M;
Console.WriteLine($"{valorMonetario:C}");

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));
*/









/*int numero1 = 10;
int numero2 = 20;

int resultado = numero1 + numero2;
Console.WriteLine(resultado);*/











/*Pessoa p1 = new Pessoa(nome: "Bruna",sobrenome: "Garstka");
Pessoa p2 = new Pessoa(nome: "David",sobrenome: "Garstka");
Pessoa p3 = new Pessoa(nome: "Geovanna",sobrenome: "Garstka");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(p1);
cursoDeIngles.AdicionarAlunos(p2);
cursoDeIngles.AdicionarAlunos(p3);
cursoDeIngles.ListarAlunos();
*/


/*p1.Idade = 17;
p1.apresentar();*/