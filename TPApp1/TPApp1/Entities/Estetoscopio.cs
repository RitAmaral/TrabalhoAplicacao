using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class Estetoscopio : Equipamento //Estetoscopio (subclasse) herda de Equipamento (superclasse)
    {
        //Propriedades/Atributos da classe Estetoscópio
        public int AnoCompra { get; set; }

        //Criação da Lista de Estetoscópios
        public List<Estetoscopio> estetoscopios { get; set; } = new List<Estetoscopio>();

        //Contrutores
        public Estetoscopio() { } //construtor padrão - (criado vazio)

        public Estetoscopio(string tipologia, int numSerie, string iDEquipa, int anoCompra) : base(tipologia, numSerie, iDEquipa)
        {
            AnoCompra = anoCompra;
        }

        //Secção de Métodos
        public void AddEstetoscopio(string tipologia, int numSerie, string iDEquipa, int anoCompra)
        {
            Estetoscopio estetoscopio = new Estetoscopio(tipologia, numSerie, iDEquipa, anoCompra);
            estetoscopios.Add(estetoscopio);
        }

        public void RemoveEstetoscopio(string tipologia, int numSerie, string iDEquipa, int anoCompra)
        {
            Estetoscopio estetoscopio = new Estetoscopio(tipologia, numSerie, iDEquipa, anoCompra);
            estetoscopios.Remove(estetoscopio);
        }

        public void MostrarEstetoscopio()
        {
            foreach (Estetoscopio estetoscopios in estetoscopios)
            {
                Console.WriteLine(
                "Tipologia: " + estetoscopios.Tipologia
                + "\n"
                + "Número de Série: " + estetoscopios.NumSerie
                + "\n"
                + "ID Equipa: " + estetoscopios.IDEquipa
                + "\n"
                + "Ano de Compra: " + estetoscopios.AnoCompra
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
                + "Ano de Compra: " + AnoCompra;
        }
    }
}
