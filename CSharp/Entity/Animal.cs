using CSharp.Interface;

namespace CSharp.Entity
{
    internal class Animal : IAnimal
    {
        public string NomeDoAnimal { get; set; }
        public string NomeDoDono { get; set; }

        public void NomeAnimal(string nome)
        {
            this.NomeDoAnimal = nome;
        }

        public void NomeDono(string nome)
        {
            this.NomeDoDono = nome;
        }
    }
}
