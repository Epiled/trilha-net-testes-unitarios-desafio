using System.Runtime.Intrinsics;
using TestesUnitarios.Desafio.Console.Services;

List<int> lista = new List<int> { 1, 2, 3, 4, -7, -6 };
int num = 5;

ValidacoesLista vl = new ValidacoesLista();

Console.WriteLine($"---- Lista original");
foreach (var item in lista)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine($"---- Fim lista original");

List<int> listaSemNegativos = vl.RemoverNumerosNegativos(lista);
Console.WriteLine($"---- Lista sem negativo");
foreach (var item in listaSemNegativos)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine($"---- Fim lista sem negativo");

bool listaContemDeterminadoNumero = vl.ListaContemDeterminadoNumero(lista, num);
Console.WriteLine($"{listaContemDeterminadoNumero}");

List<int> listaNumerosMultiplicado = vl.MultiplicarNumerosLista(lista, num);
Console.WriteLine($"---- Lista numeros multiplicado");
foreach (var item in listaNumerosMultiplicado)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine($"---- Fim lista numeros multiplicado");

int maiorNumeroLista = vl.RetornarMaiorNumeroLista(lista);
Console.WriteLine($"{maiorNumeroLista}");

int menorNumeroLista = vl.RetornarMenorNumeroLista(lista);
Console.WriteLine($"{menorNumeroLista}");

Console.WriteLine($"---- Strings ----");

ValidacoesString vs = new ValidacoesString();

string texto = "Olá Mundo";
string palavraBusca = "Olá";

int quantidadeCaracteres = vs.RetornarQuantidadeCaracteres(texto);

Console.WriteLine($"{quantidadeCaracteres}");

bool contemCaractere = vs.ContemCaractere(texto, palavraBusca);

Console.WriteLine($"{contemCaractere}");

bool textoTerminaCom = vs.TextoTerminaCom(texto, palavraBusca);

Console.WriteLine($"{textoTerminaCom}");
