using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class Equipa
    {
        //Propriedades/Atributos da classe Equipa
        public string IDEquipa { get; set; }
        public string Localidade { get; set; }

        //Criação da Lista de Equipas
        public List<Equipa> equipas { get; set; } = new List<Equipa>();

        //Construtores
        public Equipa() { } //Construtor padrão - (criado vazio)
        public Equipa(string idequipa, string localidade)
        {
            IDEquipa = idequipa;
            Localidade = localidade;
        }

        //Secção de Métodos
        public void AddEquipa(string idequipa, string localidade)
        {
            Equipa equipa = new Equipa(idequipa, localidade);
            equipas.Add(equipa);
        }

        public void RemoveEquipa(string idequipa, string localidade)
        {
            Equipa equipa = new Equipa(idequipa, localidade);
            equipas.Remove(equipa);
        }

        public void MostrarEquipas()
        {
            foreach (Equipa equipas in equipas)
            {
                Console.WriteLine(
                "ID Equipa: " + equipas.IDEquipa
                + "\n"
                + "Localidade: " + equipas.Localidade
                + "\n"
                + "-----------------------");
            }
        }

        public override string ToString()
        {
            return
                "\n"
                + "ID Equipa: " + IDEquipa
                + "\n"
                + "Localidade: " + Localidade;
        }

    }
}
