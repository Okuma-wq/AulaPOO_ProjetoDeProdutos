using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();

        public Usuario Usuario = new Usuario();

        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){
            
            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto:");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.UtcNow;

            novoProduto.Marca = Marca.Cadastrar();

            novoProduto.Usuario = new Usuario();

            ListaDeProdutos.Add(novoProduto);

        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {item.Usuario.Nome}");
            }

            Console.ResetColor();
        }

        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);

        }        
        
        
        
        
        
        
        
        
        
        
    }
}