using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class Consulta
    {
        //Propriedades/Atributos da classe Consulta
        public int IDCons { get; set; }
        public DateOnly DataCons { get; set; }
        public string Localidade { get; set; }
        public string MedicacaoPrescrita { get; set; }
        public string CategoriaRisco { get; set; }

        //Criação da Lista - Relatório de Consultas
        public List<Consulta> RelConsultas { get; set; } = new List<Consulta>();

        //Construtores
        public Consulta() { } //construtor padrão - (criado vazio)

        public Consulta(int idcons, DateOnly datacons, string localidade, string medicacaoprescrita, string categoriaRisco) 
        { 
            IDCons = idcons;
            DataCons = datacons;
            Localidade = localidade;
            MedicacaoPrescrita = medicacaoprescrita;
            CategoriaRisco = categoriaRisco;
        } 

        public Consulta(int idcons, DateOnly datacons, string localidade, string categoriaRisco)
        {
            IDCons = idcons;
            DataCons = datacons;
            Localidade = localidade;
            CategoriaRisco= categoriaRisco;
        }

        public Consulta(DateOnly datacons, string localidade, string categoriaRisco)
        {
            DataCons = datacons;
            Localidade = localidade;
            CategoriaRisco = categoriaRisco;
        }

        public Consulta(int idcons, DateOnly datacons, string localidade)
        {
            IDCons = idcons;
            DataCons = datacons;
            Localidade = localidade;
        }


        //Secção de Métodos
        public void AddRelConsulta(int idcons, DateOnly datacons, string localidade, string categoriaRisco)
        {
            Consulta consulta = new Consulta(idcons, datacons, localidade, categoriaRisco);
            RelConsultas.Add(consulta);
        }

        public void RemoveRelConsulta(int idcons, DateOnly datacons, string localidade, string categoriaRisco)
        {
            Consulta consulta = new Consulta(idcons, datacons, localidade, categoriaRisco);
            RelConsultas.Remove(consulta);
        }

        public void MostrarRelConsulta()
        {
            foreach (Consulta consultas in RelConsultas)
            {
                Console.WriteLine(
                "ID Consulta: " + consultas.IDCons
                + "\n"
                + "Data da Consulta: " + consultas.DataCons.ToString("dd/MM/yyyy")
                + "\n"
                + "Localidade: " + consultas.Localidade
                + "\n"
                + "Categoria de Risco: " + consultas.CategoriaRisco
                + "\n"
                + "-----------------------");
            }
        }

        public override string ToString()
        {
            return
                "\n"
                + "ID Consulta: " + IDCons
                + "\n"
                + "Data da Consulta: " + DataCons.ToString("dd/MM/yyyy")
                + "\n"
                + "Localidade: " + Localidade
                + "\n"
                + "Medicação Prescrita: " + MedicacaoPrescrita
                + "\n"
                + "Categoria de Risco: " + CategoriaRisco;
        }
        
    }
}
