using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class Esfigmomanometro : Equipamento //Esfigmomanometro (subclasse) herda de Equipamento (superclasse)
    {
        //Propriedades/Atributos da classe Esfigmomanómetro
        public string Calibracao { get; set; }
        public double Erro { get; set; }

        //Criação da Lista de Esfigmomanómetros
        public List<Esfigmomanometro> esfigmomanometros { get; set; } = new List<Esfigmomanometro>();

        //Construtores
        public Esfigmomanometro() { } //Construtor padrão - (criado vazio)

        public Esfigmomanometro(string tipologia, int numSerie, string iDEquipa, string calibracao, double erro) :base(tipologia, numSerie, iDEquipa)
        {
            Calibracao = calibracao;
            Erro = erro;
        }

        //Secção de Métodos
        public void AddEsfigmomanometro(string tipologia, int numSerie, string iDEquipa, string calibracao, double erro)
        {
            Esfigmomanometro esfigmomanometro = new Esfigmomanometro(tipologia, numSerie, iDEquipa, calibracao, erro);
            esfigmomanometros.Add(esfigmomanometro);
        }

        public void RemoveEsfigmomanometro(string tipologia, int numSerie, string iDEquipa, string calibracao, double erro)
        {
            Esfigmomanometro esfigmomanometro = new Esfigmomanometro(tipologia, numSerie, iDEquipa, calibracao, erro);
            esfigmomanometros.Remove(esfigmomanometro);
        }

        public void MostrarEsfigmomanometro()
        {
            foreach (Esfigmomanometro esfigmomanometros in esfigmomanometros)
            {
                Console.WriteLine(
                "Tipologia: " + esfigmomanometros.Tipologia
                + "\n"
                + "Número de Série: " + esfigmomanometros.NumSerie
                + "\n"
                + "ID Equipa: " + esfigmomanometros.IDEquipa
                + "\n"
                + "Calibração: " + esfigmomanometros.Calibracao
                + "\n"
                + "Erro: " + esfigmomanometros.Erro
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
                + "Calibração: " + Calibracao
                + "\n"
                + "Erro: " + Erro;
        }
    }
}
