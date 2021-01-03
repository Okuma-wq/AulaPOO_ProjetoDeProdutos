using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        
        
        public Usuario(){
            Cadastrar();
        }

        public Usuario(int _codigo, string _nome, string _email, string _senha){

            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;

        }

        public void Cadastrar(){
            Nome = "Paulo";
            Email = "admin@admin.com";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow;
        }

        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("");
        }
    }
}