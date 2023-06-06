using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPApp1.Entities
{
    internal class Viatura : Equipamento //viatura (subclasse) herda de Equipamento (superclasse)
    {
        //Propriedades/Atributos da classe Viatura
        public string Tipo { get; set; }
        public string Matricula { get; set; }

        //Criação da Lista de Viaturas
        public List<Viatura> viaturas { get; set; } = new List<Viatura>();

        //Construtores
        public Viatura() { } //construtor padrão - (criado vazio)

        public Viatura(string tipologia, int numSerie, string iDEquipa, string tipo, string matricula) : base (tipologia, numSerie, iDEquipa)
        {
            Tipo = tipo;
            Matricula = matricula;
        }

        //Secção de Métodos
        public void AddViatura(string tipologia, int numSerie, string iDEquipa, string tipo, string matricula)
        { 
            Viatura viatura = new Viatura(tipologia, numSerie, iDEquipa, tipo, matricula);
            viaturas.Add(viatura);
        }

        public void RemoveViatura(string tipologia, int numSerie, string iDEquipa, string tipo, string matricula)
        {
            Viatura viatura = new Viatura(tipologia, numSerie, iDEquipa, tipo, matricula);
            viaturas.Remove(viatura);
        }

        public void MostrarViatura()
        {
            foreach (Viatura viaturas in viaturas)
            {
                Console.WriteLine(
                "Tipologia: " + viaturas.Tipologia
                + "\n"
                + "Número de Série: " + viaturas.NumSerie
                + "\n"
                + "ID Equipa: " + viaturas.IDEquipa
                + "\n"
                + "Tipo de Viatura: " + viaturas.Tipo
                + "\n"
                + "Matrícula: " + viaturas.Matricula
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
                + "Tipo de Viatura: " + Tipo
                + "\n"
                + "Matrícula: " + Matricula;
        }
    }
}
