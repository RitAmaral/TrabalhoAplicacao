using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class Utente
    {
        //Propriedades/Atributos da classe Utente
        public int IDUt { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Localidade { get; set; }
        public DateOnly DataNasc { get; set; }
        public int CC { get; set; }
        public int NumUt { get; set; }
        public int Telemovel { get; set; }
        public string Email { get; set; }
        public string HistoricoMedicacao { get; set; }

        //Criação da Lista de Utentes
        public List<Utente> utentes { get; set; } = new List<Utente>();

        //Construtores
        public Utente() { } //Construtor padrão - (criado vazio)

        public Utente(int idut, string nome, string genero, string localidade, DateOnly datanasc, int cc, int numut, int telemovel, string email, string historicomedicacao)
        {
            IDUt = idut;
            Nome = nome;
            Genero = genero;
            Localidade = localidade;
            DataNasc = datanasc;
            CC = cc;
            NumUt = numut;
            Telemovel = telemovel;
            Email = email;
            HistoricoMedicacao = historicomedicacao;
        }

        public Utente(string nome, int numut)
        {
            Nome = nome;
            NumUt = numut;
        }

        //Secção de Métodos
        public void AddUtente(int idut, string nome, string genero, string localidade, DateOnly datanasc, int cc, int numut, int telemovel, string email, string historicomedicacao)
        {
            Utente utente = new Utente(idut, nome, genero, localidade, datanasc, cc, numut, telemovel, email, historicomedicacao);
            utentes.Add(utente);
        }

        public void RemoveUtente(int idut, string nome, string genero, string localidade, DateOnly datanasc, int cc, int numut, int telemovel, string email, string historicomedicacao)
        {
            Utente utente = new Utente(idut, nome, genero, localidade, datanasc, cc, numut, telemovel, email, historicomedicacao);
            utentes.Remove(utente);
        }
        public void MostrarUtentes()
        {
            foreach (Utente utentes in utentes)
            {

                Console.WriteLine(
                "ID: " + utentes.IDUt
                + "\n"
                + "Nome: " + utentes.Nome
                + "\n"
                + "Género: " + utentes.Genero
                + "\n"
                + "Localidade: " + utentes.Localidade
                + "\n"
                + "Data de Nascimento: " + utentes.DataNasc.ToString("dd/MM/yyyy")
                + "\n"
                + "Cartão de Cidadão: " + utentes.CC
                + "\n"
                + "Número de Utente: " + utentes.NumUt
                + "\n"
                + "Telemóvel: " + utentes.Telemovel
                + "\n"
                + "Email: " + utentes.Email
                + "\n"
                + "Histórico de Medicação: " + utentes.HistoricoMedicacao
                + "\n"
                + "-----------------------");
            }
        }
        
        public override string ToString()
        {
            return
                 "\n"
                + "ID: " + IDUt
                + "\n"
                + "Nome: " + Nome
                + "\n"
                + "Género: " + Genero
                + "\n"
                + "Localidade: " + Localidade
                + "\n"
                + "Data de Nascimento: " + DataNasc.ToString("dd/MM/yyyy")
                + "\n"
                + "Cartão de Cidadão: " + CC
                + "\n"
                + "Número de Utente: " + NumUt
                + "\n"
                + "Telemóvel: " + Telemovel
                + "\n"
                + "Email: " + Email
                + "\n"
                + "Histórico de Medicação: " + HistoricoMedicacao;
        }
        
    }
}
