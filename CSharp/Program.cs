using CSharp.Entity;
using CSharp.Entity.Enum;

var pessoa = new Pessoa();
var pessoa1 = (PessoaEnum)1;
var pessoa2 = PessoaEnum.Gabriel;

pessoa.Nome = "Isabel Sleigman";
pessoa.Idade = 30;

Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");

var animal = new Animal();

animal.NomeDono(pessoa.Nome);
animal.NomeAnimal("Floquinho");

Console.WriteLine($"Dono(a): {animal.NomeDoDono} do {animal.NomeDoAnimal}");

Console.WriteLine($"Testando Enum: {pessoa1}");
Console.WriteLine($"Testando Enum: {pessoa2}");