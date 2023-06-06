using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class RelatorioEquipa 
    {
        //Propriedades/Atributos
        public Equipa IDEquipa { get; set; } //esta propriedade vem da Classe Equipa
        public Colaborador ID { get; set; } //esta propriedade vem da Classe Colaborador
        public Equipa Localidade { get; set; } //esta propriedade vem da Classe Equipa

        //Construtores
        public RelatorioEquipa() { } //Construtor padrão - (criado vazio)
        
        public RelatorioEquipa(Equipa idequipa, Colaborador id, Equipa localidade) 
        {
            IDEquipa = idequipa;
            ID = id;
            Localidade = localidade;
        }
        
        //Secção de Métodos
        public override string ToString()
        {
            return
                "\n"
                + "ID Equipa: " + IDEquipa
                + "\n"
                + "ID Colaborador: " + ID
                + "\n"
                + "Localidade: " + Localidade;
        }
    }
}
