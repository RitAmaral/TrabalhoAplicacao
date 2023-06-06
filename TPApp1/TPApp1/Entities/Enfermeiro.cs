using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;
using TPApp1.Entities.Enums;

namespace TPApp1.Entities
{
    internal class Enfermeiro : Colaborador //Enfermeiro (subclasse) herda de Colaborador (superclasse)
    {
        //Propriedades/Atributos da classe Enfermeiro
        //Enfermeiro herda as propriedades de Colaborador (estão em comentário), por isso não repetimos aqui
        /*
        public FuncaoColab Funcao { get; set; }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Localidade { get; set; }
        public DateOnly DataNasc { get; set; }
        public bool CartaConducao { get; set; }
        public double Vencimento { get; set; }
        public int CC { get; set; }
        public int NIF { get; set; }
        public int Telemovel { get; set; }
        public string Email { get; set; }
        */
        public string NomeUtil { get; set; }
        private string _password { get; set; }

        //Construtores
        public Enfermeiro() { } //Construtor padrão - (criado vazio)

        public Enfermeiro(FuncaoColab func, int id, string nome, string genero, string localidade, DateOnly datanasc, bool cartaconducao, double vencimento, int cc, int nif, int telemovel, string email, string nomeUtil, string password) : base(func, id, nome, genero, localidade, datanasc, cartaconducao, vencimento, cc, nif, telemovel, email)
        {
            NomeUtil = nomeUtil;
            _password = password;
        }

        //Secção de Métodos
        public bool Login()
        {
            if (NomeUtil == "Enf1" && _password == "******")
            { return true; }
            else
            { return false; }
        }
        public void SetPassword(string password)
        {
            if (password != null && password.Length > 1)
            {
                _password = password;
            }
            else { Console.WriteLine("Escreva uma password com mais de 5 caracteres."); }
        }
        public string GetPassword() { return _password; }
        public void Logout()
        {
            Console.WriteLine("Sessão terminada.");
        }
    }
}
