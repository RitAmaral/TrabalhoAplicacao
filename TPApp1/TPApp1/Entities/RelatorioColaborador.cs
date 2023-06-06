using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPApp1;

namespace TPApp1.Entities
{
    internal class RelatorioColaborador
    {
        //Propriedades/Atributos
        public Colaborador ID { get; set; } //esta propriedade vem da classe Colaborador
        public Colaborador Nome { get; set; } //esta propriedade vem da classe Colaborador
        public Colaborador Vencimento { get; set; } //esta propriedade vem da classe Colaborador
        public Equipa IDEquipa { get; set; } //esta propriedade vem da classe Equipa

        //Construtores
        public RelatorioColaborador() { } //Construtor padrão - (criado vazio)

        public RelatorioColaborador(Colaborador id, Colaborador nome, Colaborador vencimento, Equipa idequipa)
        {
            ID = id;
            Nome = nome;
            Vencimento = vencimento;
            IDEquipa = idequipa;
        }

        //Secção de Métodos
        public override string ToString()
        {
            return
                "\n"
                + "ID do Colaborador: " + ID
                + "\n"
                + "Nome do Colaborador: " + Nome
                + "\n"
                + "Vencimento: " + Vencimento
                + "\n"
                + "ID da Equipa: " + IDEquipa;
        }
    }
}
