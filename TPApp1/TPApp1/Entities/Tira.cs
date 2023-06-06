using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class Tira : Equipamento //Tira (subclasse) herda de Equipamento (superclasse)
    {
        //Propriedades/Atributos da classe Tira
        public string Tipo { get; set; }
        public int Quantidade { get; set; }

        //Criação da Lista de Tiras
        public List<Tira> tiras { get; set; } = new List<Tira>();

        //Construtores
        public Tira() { } //construtor padrão - (criado vazio)

        public Tira(string tipologia, int numSerie, string iDEquipa, string tipo, int quantidade) : base(tipologia, numSerie, iDEquipa)
        {
            Tipo = tipo;
            Quantidade = quantidade;
        }

        //Secção de Métodos
        public void AddTira(string tipologia, int numSerie, string iDEquipa, string tipo, int quantidade)
        {
            Tira tira = new Tira(tipologia, numSerie, iDEquipa, tipo, quantidade);
            tiras.Add(tira);
        }

        public void RemoveTira(string tipologia, int numSerie, string iDEquipa, string tipo, int quantidade)
        {
            Tira tira = new Tira(tipologia, numSerie, iDEquipa, tipo, quantidade);
            tiras.Remove(tira);
        }

        public void MostrarTira()
        {
            foreach (Tira tiras in tiras)
            {
                Console.WriteLine(
                "Tipologia: " + tiras.Tipologia
                + "\n"
                + "Número de Série: " + tiras.NumSerie
                + "\n"
                + "ID Equipa: " + tiras.IDEquipa
                + "\n"
                + "Tipo de Tira: " + tiras.Tipo
                + "\n"
                + "Quantidade: " + tiras.Quantidade
                + "\n"
                + "-----------------------");
            }
        }

        public override string ToString()
        {
            return
                "\n"
                + "Tipologia: " + Tipologia
                + "\n"
                + "Número de Série: " + NumSerie
                + "\n"
                + "ID Equipa: " + IDEquipa
                + "\n"
                + "Tipo de Tira: " + Tipo
                + "\n"
                + "Quantidade: " + Quantidade;
        }
    }
}
