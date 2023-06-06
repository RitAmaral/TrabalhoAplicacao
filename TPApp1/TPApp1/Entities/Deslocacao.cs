using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class Deslocacao
    {
        //Propriedades/Atributos da classe Deslocação
        public int IDDesl { get; set; }
        public string Localidade { get; set; }
        public DateOnly DataDesl { get; set; }
        public string IDEquipa { get; set; }

        //Criação da Lista de Deslocações
        public List<Deslocacao> deslocacoes { get; set; } = new List<Deslocacao>();

        //Construtores
        public Deslocacao() { } //construtor padrão - (criado vazio)

        public Deslocacao(int iDDesl, string localidade, DateOnly dataDesl, string iDEquipa)
        {
            IDDesl = iDDesl;
            Localidade = localidade;
            DataDesl = dataDesl;
            IDEquipa = iDEquipa;
        }

        //Secção de Métodos
        public void AddDeslocacao(int iDDesl, string localidade, DateOnly dataDesl, string iDEquipa)
        {
            Deslocacao deslocacao = new Deslocacao(iDDesl, localidade, dataDesl, iDEquipa);
            deslocacoes.Add(deslocacao);
        }

        public void RemoveDeslocacao(int iDDesl, string localidade, DateOnly dataDesl, string iDEquipa)
        {
            Deslocacao deslocacao = new Deslocacao(iDDesl, localidade, dataDesl, iDEquipa);
            deslocacoes.Remove(deslocacao);
        }

        public void MostrarDeslocacao()
        {
            foreach (Deslocacao deslocacoes in deslocacoes)
            {
                Console.WriteLine(
                "ID Deslocação: " + deslocacoes.IDDesl
                + "\n"
                + "Localidade: " + deslocacoes.Localidade
                + "\n"
                + "Data da Deslocação: " + deslocacoes.DataDesl
                + "\n"
                + "ID Equipa: " + deslocacoes.IDEquipa
                + "\n"
                + "-----------------------");
            }
        }

        public override string ToString()
        {
            return
                "\n"
                + "ID Deslocação: " + IDDesl
                + "\n"
                + " Localidade: " + Localidade
                + "\n"
                + "Data da Deslocação: " + DataDesl.ToString("dd/MM/yyyy");
        }
    }
}
