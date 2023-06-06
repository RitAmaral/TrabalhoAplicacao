using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;
using TPApp1.Entities.Enums;

namespace TPApp1.Entities
{
    internal class Colaborador //a classe Colaborador é uma superclasse (subclasses que herdam de colaborador: méd, enf, adm e mot)
    {
        //Propriedades/Atributos da classe Colaborador
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

        //Criação da Lista de Colaboradores
        public List<Colaborador> colaboradores { get; set; } = new List<Colaborador>();

        //Construtores
        public Colaborador() { } //Construtor padrão - (criado vazio)
        public Colaborador(FuncaoColab func, int id, string nome, string genero, string localidade, DateOnly datanasc, bool cartaconducao, double vencimento, int cc, int nif, int telemovel, string email)
        {
            Funcao = func;
            ID = id;
            Nome = nome;
            Genero = genero;
            Localidade = localidade;
            DataNasc = datanasc;
            CartaConducao = cartaconducao;
            Vencimento = vencimento;
            CC = cc;
            NIF = nif;
            Telemovel = telemovel;
            Email = email;
        }

        //Secção de Métodos
        public void AddColaborador(FuncaoColab func, int id, string nome, string genero, string localidade, DateOnly datanasc, bool cartaconducao, double vencimento, int cc, int nif, int telemovel, string email)
        {
            Colaborador colaborador = new Colaborador(func, id, nome, genero, localidade, datanasc, cartaconducao, vencimento, cc, nif, telemovel, email);
            colaboradores.Add(colaborador);
        }

        public void RemoveColaborador(FuncaoColab func, int id, string nome, string genero, string localidade, DateOnly datanasc, bool cartaconducao, double vencimento, int cc, int nif, int telemovel, string email)
        {
            Colaborador colaborador = new Colaborador(func, id, nome, genero, localidade, datanasc, cartaconducao, vencimento, cc, nif, telemovel, email);
            colaboradores.Remove(colaborador);
        }

        public void MostrarColaborador()
        {
            foreach (Colaborador colaboradores in colaboradores)
            {
                Console.WriteLine(
                "Função: " + colaboradores.Funcao
                + "\n"
                + "ID: " + colaboradores.ID
                + "\n"
                + "Nome: " + colaboradores.Nome
                + "\n"
                + "Género: " + colaboradores.Genero
                + "\n"
                + "Localidade: " + colaboradores.Localidade
                + "\n"
                + "Data de Nascimento: " + colaboradores.DataNasc.ToString("dd/MM/yyyy")
                + "\n"
                + "Carta de Condução: " + colaboradores.CartaConducao
                + "\n"
                + "Vencimento: " + colaboradores.Vencimento
                + "\n"
                + "CC: " + colaboradores.CC
                + "\n"
                + "NIF: " + colaboradores.NIF
                + "\n"
                + "Telemóvel: " + colaboradores.Telemovel
                + "\n"
                + "Email: " + colaboradores.Email
                + "\n"
                + "-----------------------");
            }
        }

        public override string ToString()
        {
            return
                "\n"
                + "Função: " + Funcao
                + "\n"
                + "ID: " + ID
                + "\n"
                + "Nome: " + Nome
                + "\n"
                + "Género: " + Genero
                + "\n"
                + "Localidade: " + Localidade
                + "\n"
                + "Data de Nascimento: " + DataNasc.ToString("dd/MM/yyyy")
                + "\n"
                + "Carta de Condução: " + CartaConducao
                + "\n"
                + "Vencimento: " + Vencimento
                + "\n"
                + "CC: " + CC
                + "\n"
                + "NIF: " + NIF
                + "\n"
                + "Telemóvel: " + Telemovel
                + "\n"
                + "Email: " + Email;

        }

    }

}
