using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class RelatorioConsulta : Consulta // RelatoriaConsulta herda da Consulta (superclasse)
    {
        //Propriedades/Atributos
        //public Consulta DataCons { get; set; } //esta propriedade vem da classe Consulta
        //public Consulta Localidade { get; set; } //esta propriedade vem da classe Consulta
        //public string CategoriaRisco { get; set; } //esta propriedade vem da classe Consulta, logo estão todas comentadas, não são necessárias

        //Construtores
        public RelatorioConsulta() { } //Construtor padrão - (criado vazio)

        public RelatorioConsulta(DateOnly datacons, string localidade, string categoriaRisco) :base(datacons, localidade, categoriaRisco)
        {
            //DataCons = datacons;
            //Localidade = localidade; ---- não é preciso colocar estes 3 argumentos aqui porque já vêm da classe Consulta
            //CategoriaRisco = categoriaRisco;
        }

        //Secção de Métodos

        public override string ToString()
        {
            return
                "\n"
                + "Data da Consulta: " + DataCons.ToString("dd/MM/yyyy")
                + "\n"
                + "Localidade: " + Localidade
                + "\n"
                + "Categoria de Risco: " + CategoriaRisco;
        }
    }
}
