// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aula 02");

//Strings

string texto = "exemplo";
//char texto2 = ""; //string.Empty
//o de cima é o mesmo do de baixo
int[] arrayTaina = new int[6]; //new cria o array de fato, sem ele ela não existe
arrayTaina[3] = 55;
Console.WriteLine(arrayTaina[3]); //acessa a posicao 3 do array
int[] arrayTaina2 = { 12, 13, 14 };
Console.WriteLine(arrayTaina2[2]); //acessou uma posição de uma array já definida
List<int> arrayTaina3 = new List<int>(); //.NET versões anteriores
List<int> arrayTaina4 = new(); //.NET 6 aceita assim
string texto3 = string.Empty;
var texto4 = char.MinValue; //representação do vazio. também pode ser representado por \0
Console.WriteLine(texto4); //vazio
texto4 = texto[0]; //puxa o caractere da posição pedida (e)
//texto4 = 'b' + 'a'; //nao aceita pois precisa estar escrito em UTF-16
Console.WriteLine(texto4); //devolve "e"
Console.WriteLine(texto); //devolve "exemplo"
texto4 = '\u0033';
Console.WriteLine(texto4); //devolve "3"
string texto5 = "Heber\nSilva"; //primeira forma de escrever
string texto6 = $@"Heber
{"Silva"}"; //segunda forma de escrever
Console.WriteLine(texto5);
Console.WriteLine(texto6);
//pensando num csv recebido (nome;telefone;email):
string arquivo = @"heber silva; 11982632463; heberhenrique@gmail.com";
//pegar só o telefone (split precisa do array):
string[] arquivoArray = arquivo.Split(';'); //criando um array e dividindo a variável usando ; como separador
string telefone = arquivo.Split(';')[1]; //dividiu o arquivo e acessou o índice 1
Console.WriteLine(arquivoArray.Length); //devolve o tamanho
Console.WriteLine(arquivoArray[1]); //devolve a segunda posição
Console.WriteLine(telefone); //devolve a segunda posição pois foi definido na variável
Console.WriteLine(telefone.Trim()); //remove espaços em branco antes ou depois da string
//O Trim pode ser colocado já na string: string telefone = arquivo.Split(';')[1].Trim()
Console.WriteLine(telefone.Remove(1)); //remove algo da string da posição escolhida em diante (nesse caso está removendo a string toda e deixando só o espaço inicial)
string nome = "heber silva";
Console.WriteLine(nome.Remove(5)); //está removendo do espaço em diante
Console.WriteLine(nome.Remove(0, 5)); //removeu a partir da posição 0, até 5 caracteres
Console.WriteLine(nome.Remove(2, 3)); //removeu a partir da posição 2, 3 caracteres
//Substring - parece com o remove, define o indice a ser recuperado
Console.WriteLine(nome.Substring(0, 4)); //pega uma string dentro de uma string - começa da posição 0 e recupera os 4 primeiros caracteres
Console.WriteLine(telefone.Replace('1', 'A')); //remove tudo que é 1 pela letra A
Console.WriteLine(telefone.Replace("1", "")); //remove o 1 e coloca vazio
string cpf = "724.374.410-93";
Console.WriteLine(
    cpf.Replace(".", "")
       .Replace("-", "")); //remove o que for pedido
string nome2 = "Taina Costa Maia";
var arrayNome2 = nome2.Split(' ');
Console.WriteLine(arrayNome2); //devoveu o tipo
Console.WriteLine(arrayNome2[2]); //devolve a string da posição 2
string nome3 = "FUlAno da sIlva".ToUpper(); //converte tudo par maiúscula
Console.WriteLine(nome3);

//Tipos Numéricos
/* sem sinais (unsigned):
byte | 0 a 255 | Inteiro de 8 bits sem sinal
ushort | 0 a 65.535 | Inteiro de 16 bits sem sinal
uint | 0 a 4.294.967.295 | Inteiro de 32 bits sem sinal
ulong | 0 a 18.446.744.073.709.551.615 | Inteiro de 64 bits sem sinal
nuint | Depende da plataforma | Inteiro de 32 bits ou 64 bits não assinado

Inteiros com sinais:
sbyte | -128 a 127 | Inteiro de 8 bits com sinal
short | -32.768 a 32.767 | Inteiro de 16 bits com sinal
int | -2.147.483.648 a 2.147.483.647 | Inteiro assinado de 32 bits
long | -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 | Inteiro assinado de 64 bits
nint | Depende da plataforma | Número inteiro de 32 bits ou 64 bits assinado

O tipo de um literal real é determinado pelo seu sufixo da seguinte maneira:
O literal sem sufixo ou com o sufixo d é do tipo double.
O literal com o sufixo f é do tipo float.
O literal com o sufixo m é do tipo decimal.*/

//double.MaxValue: 1.79769313486232E+308 <= suporta um número inteiro com 308 dígitos, com precisão de 15 a 17 dígitos
//decimal.MaxValue: 79228162514264337593543950335 <= suporta um número inteiro com 29 dígitos, com precisão de 28 a 29 dígitos

var salarioTexto = "11234.55";
float salario1 = 11234.55f;
double salario2 = 11234.55; //nao precisa de letra no final
decimal salario3 = 11234.55m;
salario3 = (decimal)salario1;
salario3 = Convert.ToDecimal(salarioTexto);

int teste = 1233;
long teste2 = teste;

var estadoAprovado = "Aprovado";
var estadoReprovado = "Reprovado";
var aprovado = 1;
var reprovado = 2;
//as variaveis acima nao sao necessarias no enum pq ele ja enumera

int statusAluno = 3;
StatusAluno statusAluno2 = StatusAluno.Aprovado;

if (statusAluno == 1)
{
//
}
else if (statusAluno == 2)
{
//
}
//o enum tambem pode substituir um if como o acima

switch (statusAluno2)
{
case StatusAluno.Aprovado:
break;
case StatusAluno.Reprovado:
break;
case StatusAluno.NaoFezAProva:
break;
default:
break;
}
//o switch pega os dados do enum

Console.WriteLine((int)StatusAluno.Aprovado); //traz o numero referente a aprovado
Console.WriteLine((StatusAluno)statusAluno); //traz o status que foi definido
// nao pode colocar o WriteLine dps do enum
enum StatusAluno
{ // conta a partir de 0 se vc nao definir valor
    Aprovado = 1, //defini valor
    Reprovado,
    NaoFezAProva
}



