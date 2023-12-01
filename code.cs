using System;
using CSharpShellCore;
namespace JogoDeAdvinharNúmero{
class Classe{
static void Main(String[] args){
Random random = new Random();
bool jogarDeNovo = true;
int min = 1;
int max = 57;
int palpite;
int num;
int tentativas;
String resposta;


while(jogarDeNovo){
	palpite = 0;
	resposta = "";
	tentativas = 0;
	num = random.Next(min, max +1);
	
	while(palpite != num){
	Console.WriteLine("insira um número entre " + min + " - " + max);
	palpite = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("seu palpite: "+ palpite);
	
	if(palpite > num){
	Console.WriteLine(palpite+ " é muito alto ");
	
	}
	else if(palpite < num){
	Console.WriteLine(palpite+" é muito baixo ");
	
	}
	
	tentativas++;
	
	}
	Console.WriteLine("número: "+ num);
	Console.WriteLine("VOCÊ VENCEU! ");
	Console.WriteLine("tentativas: "+ tentativas);
	
	Console.WriteLine("quer jogar novamente? (S/N:)  ");
	resposta = Console.ReadLine();
	resposta = resposta.ToUpper();
	if(resposta == "S"){
	jogarDeNovo = true;
	
	}
	else{
		jogarDeNovo = false;
	}
}
Console.WriteLine("obrigado por jogar");
}
}
}