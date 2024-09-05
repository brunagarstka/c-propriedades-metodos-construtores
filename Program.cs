using System.Xml.Serialization;
using c_propriedades_metodos_construtores.Models;
using System.Globalization;
using System.Data;

int numero = 10;
bool ehPar = false;

//IF TERNÁRIO
ehPar = numero % 2 == 0;
Console.WriteLine($"O numero {numero} é "+ (ehPar ? "par" : "impar"));
/*
if(numero % 2 == 0)
{
    Console.WriteLine($"O numero {numero} é par");
}
else
{
    Console.WriteLine($"O numero {numero} é impar");
}
*/



/*
Pessoa p1 = new Pessoa("Bruna", "Luisa");
(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");

*/










/*
LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt"); // O _ SERVE PARA UM DESCARTE DE INFORMAÇÕES

if(sucesso)
{
    //Console.WriteLine("Quantidade de linhas: " + QuantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}
*/




/*
    (int, string, string, decimal) tupla = (1, "Bruna", "Luisa", 1.66M);


    //ValueTuple<int, string, string, decimal> outroExemploTuple = (1, "Bruna", "Luisa", 1.66M);
    //var outroExemploTupleCreat = Tuple.Create(1, "Bruna", "Luisa", 1.66M);

    Console.WriteLine($"Id: {tupla.Item1}");
    Console.WriteLine($"Nome: {tupla.Item2}");
    Console.WriteLine($"Sobrenome: {tupla.Item3}");
    Console.WriteLine($"Altura: {tupla.Item4}");

*/














/*
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");

foreach(KeyValuePair<string, string> item in estados) //pode se utilizar var no lugar de KeyValuePair
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("----------------");
estados.Remove("MG");
estados["SP"] = "São Paulo - valor alterado";
foreach(KeyValuePair<string, string> item in estados) //pode se utilizar var no lugar de KeyValuePair
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("----------------");
string chave = "RJ";
Console.WriteLine($"Verificando o elemento: {chave}");
if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else 
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}
Console.WriteLine(estados["RJ"]);
*/








/*
Stack<int> pilha = new Stack<int>();
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);
foreach(int item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
pilha.Push(20);
foreach(int item in pilha)
{
    Console.WriteLine(item);
}
*/






   







/*
Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
foreach(int item in fila)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);
foreach(int item in fila)
{
    Console.WriteLine(item);
}
*/









/*new ExemploExceção().Metodo1();*/












/*
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma execeção genérica. {ex.Message}");
}
finally
{
Console.WriteLine("Chegou ate aqui");
}
*/





















/*string dataString = "2024-08-28 22:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");                                                        //MM maiusculo representa mes, e mm minusculo é minuto
}
else 
{
    Console.WriteLine($"{dataString} não é uma data valida");
}*/




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