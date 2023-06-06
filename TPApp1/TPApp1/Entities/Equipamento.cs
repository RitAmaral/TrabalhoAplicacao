using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class Equipamento //superclasse
    {
        //Propriedades/Atributos da classe Equipamento
        public string Tipologia { get; set; }
        public int NumSerie { get; set; }
        public string IDEquipa { get; set; }

        //Criação da Lista de Equipamentos
        public List<Equipamento> equipamentos { get; set; } = new List<Equipamento>();

        //Construtores
        public Equipamento() { } //construtor padrão - (criado vazio)

        public Equipamento(string tipologia, int numSerie, string iDEquipa)
        {
            Tipologia = tipologia;
            NumSerie = numSerie;
            IDEquipa = iDEquipa;
        }

        //Secção de Métodos
        public void AddEquipamento(string tipologia, int numSerie, string iDEquipa)
        {
            Equipamento equipamento = new Equipamento(tipologia, numSerie, iDEquipa);
            equipamentos.Add(equipamento);
        }

        public void RemoveEquipamento(string tipologia, int numSerie, string iDEquipa)
        {
            Equipamento equipamento = new Equipamento(tipologia, numSerie, iDEquipa);
            equipamentos.Remove(equipamento);
        }
        public void MostrarEquipamentos()
        {
            foreach (Equipamento equipamentos in equipamentos)
            {
                Console.WriteLine(
                "Tipologia: " + equipamentos.Tipologia
                + "\n"
                + "Número de Série: " + equipamentos.NumSerie
                + "\n"
                + "ID Equipa: " + equipamentos.IDEquipa
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
                + "ID Equipa: " + IDEquipa;
        }
    }
}
