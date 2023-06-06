using System.Drawing;
using System.Runtime.CompilerServices;
using TPApp1.Entities;
using TPApp1.Entities.Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        /*-----------------Novos objetos (Med1, Enf1, Adm1, Mot1) - inicializados vazios-------------------*/

        Medico Med1 = new Medico();
        Enfermeiro Enf1 = new Enfermeiro();
        Administrativo Adm1 = new Administrativo();
        Motorista Mot1 = new Motorista();

        /*-------------------------------------------------Início da Aplicação-------------------------------------------*/

        Console.WriteLine("Bem-vindo/a! Digite o número correspondente à sua função: " + "\n" + "1. Médico" + "\n" + "2. Enfermeiro" + "\n" + "3. Administrativo" + "\n" + "4. Motorista");
        Console.Write("Número: "); //funciona tanto o número como o nome da funcão
        string func = Console.ReadLine(); //o colaborador escreve o número ou o nome correspondente à sua função
        FuncaoColab funcao = (FuncaoColab)Enum.Parse(typeof(FuncaoColab), func);
        Console.WriteLine("-----------------------");

        /*----------------------Criação das Listas----------------------*/
        //Lista de Colaboradores
        Colaborador ListaColaboradores = new Colaborador();
        //Instanciar colaboradores:
        ListaColaboradores.AddColaborador(Enum.Parse<FuncaoColab>("Motorista"), 20, "Tomás Rodrigues", "Masculino", "Braga", DateOnly.Parse("12/05/1980"), true, 1000, 13415625, 231562784, 966126621, "tomas@gmail.com");
        ListaColaboradores.AddColaborador(Enum.Parse<FuncaoColab>("Enfermeiro"), 21, "Maria Santos", "Feminino", "Braga", DateOnly.Parse("22/08/1987"), false, 1300, 18423790, 225432790, 936125512, "maria@gmail.com");
        ListaColaboradores.AddColaborador(Enum.Parse<FuncaoColab>("Médico"), 22, "Carlos Silva", "Masculino", "Braga", DateOnly.Parse("09/03/1985"), true, 1800, 12815633, 211792762, 916124429, "carlos@gmail.com");
        ListaColaboradores.AddColaborador(Enum.Parse<FuncaoColab>("Administrativo"), 23, "Rosa Gomes", "Feminino", "Barcelos", DateOnly.Parse("07/12/1990"), true, 1050, 13675392, 269354571, 926892564, "rosa@gmail.com");

        //Lista de Equipas
        Equipa ListaEquipas = new Equipa();
        //Instanciar equipas:
        ListaEquipas.AddEquipa("Equipa06", "Lisboa");
        ListaEquipas.AddEquipa("Equipa07", "Coimbra");
        ListaEquipas.AddEquipa("Equipa08", "Portimão");
        ListaEquipas.AddEquipa("Equipa09", "Aveiro");
        ListaEquipas.AddEquipa("Equipa10", "Setúbal");
        ListaEquipas.AddEquipa("Equipa11", "Beja");

        //Lista de Utentes
        Utente ListaUtentes = new Utente();
        //Instanciar utentes:
        ListaUtentes.AddUtente(30, "Joaquim Silva", "Masculino", "Braga", DateOnly.Parse("01/03/1950"), 14566999, 776653890, 914567296, "joaquim@gmail.com", "Atorvastatin Calcium");
        ListaUtentes.AddUtente(31, "Inês Magalhães", "Feminino", "Barcelos", DateOnly.Parse("02/04/1956"), 12255789, 55723891, 931117333, "ines@gmail.com", "Sinvascor");
        ListaUtentes.AddUtente(32, "Olga Costa", "Feminino", "Guimarães", DateOnly.Parse("03/05/1966"), 13622543, 446983892, 962227444, "olga@gmail.com", "Rosuvastatin Sandoz");

        //Lista de Equipamentos
        Equipamento ListaEquipamentos = new Equipamento();
        Viatura ListaViaturas = new Viatura();
        Tira ListaTiras = new Tira();
        Estetoscopio ListaEstetoscopios = new Estetoscopio();
        Esfigmomanometro ListaEsfigmomanometros = new Esfigmomanometro();

        //Instanciar equipamentos:
        ListaEquipamentos.AddEquipamento("Viatura", 457, "Equipa06");
        ListaEquipamentos.AddEquipamento("Estetoscópio", 123, "Equipa06");
        ListaEquipamentos.AddEquipamento("Esfigmomanómetro", 241, "Equipa06");
        ListaEquipamentos.AddEquipamento("Tiras", 339, "Equipa06");
        ListaEquipamentos.AddEquipamento("Viatura", 458, "Equipa07");
        ListaEquipamentos.AddEquipamento("Estetoscópio", 124, "Equipa07");
        ListaEquipamentos.AddEquipamento("Esfigmomanómetro", 242, "Equipa07");
        ListaEquipamentos.AddEquipamento("Tiras", 340, "Equipa07");

        //Instanciar viaturas:
        ListaViaturas.AddViatura("Viatura", 457, "Equipa06", "Viatura Ligeira", "BB-01-BB");
        ListaViaturas.AddViatura("Viatura", 458, "Equipa07", "Viatura de Rastreio Ambulante", "CC-01-CC");
        //Instanciar tiras:
        ListaTiras.AddTira("Tiras", 339, "Equipa06", "Avaliação de colestrol", 60);
        ListaTiras.AddTira("Tiras", 340, "Equipa07", "Avaliação de colestrol", 55);
        //Instanciar estetoscópios:
        ListaEstetoscopios.AddEstetoscopio("Estetoscópio", 123, "Equipa06", 2022);
        ListaEstetoscopios.AddEstetoscopio("Estetoscópio", 124, "Equipa07", 2023);
        //Instanciar esfigmomanómetros:
        ListaEsfigmomanometros.AddEsfigmomanometro("Esfigmomanómetro", 241, "Equipa06", "Sim", 0.05);
        ListaEsfigmomanometros.AddEsfigmomanometro("Esfigmomanómetro", 242, "Equipa07", "Sim", 0.04);

        //Lista de Deslocações
        Deslocacao ListaDeslocacoes = new Deslocacao();
        //Instanciar deslocação:
        ListaDeslocacoes.AddDeslocacao(07, "Lisboa", DateOnly.Parse("30/06/2023"), "Equipa06");
        ListaDeslocacoes.AddDeslocacao(08, "Aveiro", DateOnly.Parse("15/07/2023"), "Equipa09");
        ListaDeslocacoes.AddDeslocacao(09, "Setúbal", DateOnly.Parse("08/08/2023"), "Equipa10");
        ListaDeslocacoes.AddDeslocacao(10, "Coimbra", DateOnly.Parse("28/09/2023"), "Equipa07");
        ListaDeslocacoes.AddDeslocacao(11, "Beja", DateOnly.Parse("23/10/2023"), "Equipa11");
        ListaDeslocacoes.AddDeslocacao(12, "Portimão", DateOnly.Parse("13/11/2023"), "Equipa08");

        //Relatório de Consultas / dados gerais
        Consulta RelatorioConsultas = new Consulta();
        //Adicionar ao relatório de consultas:
        RelatorioConsultas.AddRelConsulta(07, DateOnly.Parse("04/04/2023"), "Braga", "HTA Grau II");
        RelatorioConsultas.AddRelConsulta(08, DateOnly.Parse("14/04/2023"), "Braga", "HTA Grau I");
        RelatorioConsultas.AddRelConsulta(09, DateOnly.Parse("28/04/2023"), "Braga", "HTA Grau III");
        RelatorioConsultas.AddRelConsulta(10, DateOnly.Parse("07/05/2023"), "Braga", "Normal");
        RelatorioConsultas.AddRelConsulta(11, DateOnly.Parse("12/05/2023"), "Braga", "Ótima");
        RelatorioConsultas.AddRelConsulta(12, DateOnly.Parse("29/05/2023"), "Braga", "HTA Grau II");

        switch (funcao)
        {
            case FuncaoColab.Médico: /*--------------------------------------------LOGIN DO MÉDICO-----------------------------------*/
                Console.WriteLine("Função: Médico.");
                Console.WriteLine();
                Console.WriteLine("Insira o nome de utilizador: ");
                Med1.NomeUtil = (Console.ReadLine()); //inserir nome de Utilizador = Med1

                Console.WriteLine("Insira a password: ");
                string password = Console.ReadLine();
                Med1.SetPassword(password); 

                if (Med1.Login())
                { Console.WriteLine("Login Aceite."); }
                else
                {
                    Console.WriteLine("Login Errado. Tente novamente.");
                    while (Med1.Login() == false)
                    {
                        Console.WriteLine("Insira o nome de utilizador: ");
                        Med1.NomeUtil = (Console.ReadLine());
                        Console.WriteLine("Insira a password: ");
                        password = Console.ReadLine();
                        Med1.SetPassword(password);
                    }
                }

                /*------------------Médico: Escolher Menu---------------*/

                Med1.Nome = "Carlos Silva";
                Console.WriteLine();
                Console.WriteLine("Bem-vindo/a " + Med1.Nome + "! \n Estes são os menus a que pode aceder: ");

                Console.WriteLine("\n 1. Registar Utente \n 2. Registar Consulta \n 3. Consultar Dados");
                Console.Write("Selecione o menu a que quer aceder: ");

                int escMenu = int.Parse(Console.ReadLine());
                switch (escMenu)
                {
                    case 1: /*--------Registar Utente----------*/
                        Console.WriteLine("Menu escolhido: Registar Utente.");
                        Console.WriteLine();

                        //Questiona o número de registos a serem feitos
                        Console.Write("Quantos utentes serão registados? ");
                        int k = int.Parse(Console.ReadLine());

                        //Corre o ciclo for para preencher a lista de utentes com o número de registos pretendidos
                        for (int i = 1; i <= k; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Utente #{i} :"); //Apresenta os Registos Numerados
                            Console.Write("Insira o ID do Utente (exemplo: 01): ");
                            int idut = int.Parse(Console.ReadLine());
                            Console.Write("Insira o Nome do Utente: ");
                            string nomeUt = Console.ReadLine();
                            Console.Write("Insira o Género do Utente: ");
                            string genero = Console.ReadLine();
                            Console.Write("Insira a Localidade do Utente: ");
                            string localidadeUt = Console.ReadLine();
                            Console.Write("Insira a Data de Nascimento do Utente (dd/mm/yyyy): ");
                            DateOnly datanasc = DateOnly.Parse(Console.ReadLine());
                            Console.Write("Insira o Cartão de Cidadão do Utente: ");
                            int cc = int.Parse(Console.ReadLine());
                            Console.Write("Insira o Número de Utente (exemplo 000000001): ");
                            int nUt = int.Parse(Console.ReadLine());
                            Console.Write("Insira o Número de Telemóvel do Utente: ");
                            int telemovel = int.Parse(Console.ReadLine());
                            Console.Write("Insira o Email do Utente: ");
                            string email = Console.ReadLine();
                            Console.Write("Insira o Histórico de Medicação do Utente: ");
                            string historicomedicacao = Console.ReadLine();

                            ListaUtentes.AddUtente(idut, nomeUt, genero, localidadeUt, datanasc, cc, nUt, telemovel, email, historicomedicacao);

                            /*--------Mostra a Lista atualizada de Utentes-------*/
                            Console.WriteLine();
                            Console.WriteLine("Lista de Utentes atualizada: ");
                            ListaUtentes.MostrarUtentes();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Este registo cumpre com o Regulamento Geral de Proteção de Dados (RGPD).");
                        Console.WriteLine("--------------------");

                        break;/*fim do case 1: Registar Utente*/

                    case 2: /*--------Registar Consulta----------*/
                        Console.WriteLine("Menu escolhido: Registar Consulta.");
                        Console.WriteLine();

                        //_____________________________________1ªParte___________________________________//

                        //Questiona o número de registos a serem feitos
                        Console.Write("Quantas consultas serão registadas? ");
                        int l = int.Parse(Console.ReadLine());

                        //Corre o ciclo for para preencher o relatório de consultas com o número de registos pretendidos
                        for (int i = 1; i <= l; i++)
                        {
                            Console.WriteLine(); 
                            Console.WriteLine($"Consulta #{i} :"); //Apresenta os Registos Numerados
                            Console.WriteLine("Dados da Consulta");
                            Console.Write("Atribua um ID à Consulta (exemplo: 01): ");
                            int idcons = int.Parse(Console.ReadLine());

                            Console.Write("Data da consulta (dd/mm/yyyy): ");
                            DateOnly datacons = DateOnly.Parse(Console.ReadLine());

                            Console.Write("Localidade visitada: ");
                            string localidade = Console.ReadLine();

                            //_____________________________________2ªParte___________________________________//
                            Console.Write("Escreva o Nome do Utente a ser consultado: ");
                            string nome = Console.ReadLine();
                            Console.Write("Escreva o Número do Utente a ser consultado (exemplo 000000001): ");
                            int numUt = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            //_____________________________________3ªParte___________________________________//
                            Console.Write("Insira os valores de pressão arterial sistólica (PAS): ");
                            int PAS = int.Parse(Console.ReadLine());
                            Console.Write("Insira os valores de pressão arterial diastólica (PAD): ");
                            int PAD = int.Parse(Console.ReadLine());

                            if (PAS < 120 && PAD < 80)
                            {
                                Console.WriteLine("Categoria: Ótima");
                                string categoriaRisco = "Ótima";
                                RelatorioConsultas.AddRelConsulta(idcons,datacons, localidade, categoriaRisco);
                            }
                            else if ((PAS > 120 && PAS < 129) || (PAD > 80 && PAD < 84))
                            {
                                Console.WriteLine("Categoria: Normal");
                                string categoriaRisco = "Normal";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if ((PAS > 130 && PAS < 139) || (PAD > 85 && PAD < 89))
                            {
                                Console.WriteLine("Categoria: Normal-Alta(1)");
                                string categoriaRisco = "Normal-Alta(1)";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if ((PAS > 140 && PAS < 159) || (PAD > 90 && PAD < 99))
                            {
                                Console.WriteLine("Categoria: HTA Grau I");
                                string categoriaRisco = "HTA Grau I";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if ((PAS > 160 && PAS < 179) || (PAD > 100 && PAD < 109))
                            {
                                Console.WriteLine("Categoria: HTA Grau II");
                                string categoriaRisco = "HTA Grau II";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if (PAS >= 180 || PAD >= 110)
                            {
                                Console.WriteLine("Categoria: HTA Grau III");
                                string categoriaRisco = "HTA Grau III";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if (PAS >= 140 && PAD < 90)
                            {
                                Console.WriteLine("Categoria: Hipertensão Sistólica Isolada (2)");
                                string categoriaRisco = "Hipertensão Sistólica Isolada (2)";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            Console.WriteLine();

                            //_____________________________________4ªParte___________________________________//
                            Console.Write("Prescrever Medicação para este Utente? S/N: ");
                            char resp = char.Parse(Console.ReadLine());

                            if (resp == 'S' || resp == 's')
                            {
                                Console.Write("Prescrição da Medicação: ");
                                string prescMed = Console.ReadLine();
                                Console.WriteLine("Receita Gerada. Email enviado ao Utente com a Receita Gerada. Informação atualizada na DGS.");
                                Console.WriteLine();
                                Console.Write("Marcar nova consulta de seguimento para este Utente. Atribua um ID à nova deslocação (exemplo 01): ");
                                int iDDesl = int.Parse(Console.ReadLine());

                                Console.Write("Indique a localidade da nova deslocação: ");
                                localidade = Console.ReadLine();

                                Console.Write("Indique a data da nova deslocação (dd/mm/yyyy): ");
                                DateOnly dataDesl = DateOnly.Parse(Console.ReadLine());

                                Console.Write("Indique o ID da Equipa encarregue da nova deslocação (exemplo: Equipa01): ");
                                string iDEquipa = Console.ReadLine();

                                //Adiciona nova deslocação à lista
                                ListaDeslocacoes.AddDeslocacao(iDDesl, localidade, dataDesl,iDEquipa);

                                /*--------Mostra Lista de Deslocações atualizada-------*/
                                Console.WriteLine();
                                Console.WriteLine("Nova consulta de seguimento agendada para este Utente. E-mail sobre nova consulta agendada enviada ao Utente. Lista de Próximas Deslocações atualizada.");
                                ListaDeslocacoes.MostrarDeslocacao();

                                Console.WriteLine();
                                Console.WriteLine("Consulta gravada. Listas de Dados Gerais e Deslocação por Equipa atualizadas.");
                            }
                            else
                            {
                                Console.Write("Deseja agendar nova consulta para este Utente? S/N: ");
                                char resp2 = char.Parse(Console.ReadLine());
                                if (resp2 == 'S' || resp2 == 's')
                                {
                                    Console.Write("Atribua um ID à nova deslocação (exemplo 01): ");
                                    int iDDesl = int.Parse(Console.ReadLine());

                                    Console.Write("Indique a localidade da nova deslocação: ");
                                    localidade = Console.ReadLine();

                                    Console.Write("Indique a data da nova deslocação (dd/mm/yyyy): ");
                                    DateOnly dataDesl = DateOnly.Parse(Console.ReadLine());

                                    Console.Write("Indique o ID da Equipa encarregue da nova deslocação (exemplo: Equipa01): ");
                                    string iDEquipa = Console.ReadLine();

                                    //Adiciona nova deslocação à lista
                                    ListaDeslocacoes.AddDeslocacao(iDDesl, localidade, dataDesl, iDEquipa);

                                    /*--------Mostra Lista de Deslocações atualizada-------*/
                                    Console.WriteLine();
                                    Console.WriteLine("Lista de Deslocações atualizada: ");
                                    ListaDeslocacoes.MostrarDeslocacao();

                                    Console.WriteLine();
                                    Console.WriteLine("Consulta Agendada. Lista de Próximas Deslocações atualizada. E-mail sobre nova consulta agendada enviada ao utente.");
                                    Console.WriteLine();
                                    Console.WriteLine("Consulta Gravada. Listas de Dados Gerais e Deslocação por Equipa atualizadas.");
                                }
                                else
                                {
                                    Console.Write("Deseja gravar consulta? S/N: ");
                                    char resp3 = char.Parse(Console.ReadLine());
                                    if (resp3 == 'S' || resp3 == 's')
                                    {
                                        Console.WriteLine("Consulta Gravada. Listas de Dados Gerais e Deslocação por Equipa atualizadas.");
                                    }
                                    else { Console.WriteLine("Consulta não foi gravada."); }
                                }
                            }
                            
                            /*--------Mostra o Relatório de consultas atualizado-------*/
                            Console.WriteLine();
                            Console.WriteLine("Relatório de Consultas atualizado: ");
                            RelatorioConsultas.MostrarRelConsulta();
                        }

                        break; /*fim do case 2: Registar Consulta*/

                    case 3: /*--------Consultar Dados----------*/
                        Console.WriteLine("Menu escolhido: Consultar Dados.");
                        Console.WriteLine();
                        Console.WriteLine("Escolha o submenu: \n 1. Relatório de dados estatísticos gerais das consultas \n " +
                            "2. Consulta Utentes \n 3. Consulta Próximas Deslocações \n 4. Consulta equipa por deslocação \n " +
                            "5. Consulta de equipamentos por equipa");
                        Console.Write("Selecione o submenu a que quer aceder: ");
                        int escSubMenu = int.Parse(Console.ReadLine());

                        switch (escSubMenu)
                        {
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("Submenu escolhido: Relatório de dados estatísticos gerais das consultas.");
                                //Console.Write("Insira um mês e ano para consultar (MM/AAAA): "); //isto não conseguimos implementar
                                //string mesAno = Console.ReadLine();
                                //int mes = int.Parse(mesAno.Substring(0,2)); //aqui retiramos o mês, a partir da posição 0 até 2
                                //int ano = int.Parse(mesAno.Substring(3)); //aqui retiramos o ano, a partir da posição 3
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                RelatorioConsultas.MostrarRelConsulta();
                                RelatorioConsultas.CountRelConsulta();

                                break; //fim do case 1: relatório dados estatísticos gerais das consultas
                            case 2:
                                Console.WriteLine("Submenu escolhido: Consulta de Utentes.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaUtentes.MostrarUtentes();
                                break; //fim do case 2: relatório de utentes
                            case 3:
                                Console.WriteLine("Submenu escolhido: Consulta Próximas Deslocações.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaDeslocacoes.MostrarDeslocacao();
                                break;
                            case 4:
                                Console.WriteLine("Submenu escolhido: Consulta equipa por deslocação.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaEquipas.MostrarEquipas(); //consulta equipa por localidade
                                break;
                            case 5:
                                Console.WriteLine("Submenu escolhido: Consulta de equipamentos por equipa.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaEquipamentos.MostrarEquipamentos();
                                break;
                        }

                        break; /*fim do case 3: Consultar Dados*/
                }

                /*--------------------Médico: Logout----------------------*/
                Console.WriteLine();
                Med1.Logout();
                Console.WriteLine("----------------------------");
                Console.WriteLine();

                break;

            case FuncaoColab.Enfermeiro: /*---------------------------------------------LOGIN DO ENFERMEIRO-----------------------------------*/
                Console.WriteLine("Função: Enfermeiro.");
                Console.WriteLine();
                Console.WriteLine("Insira o nome de utilizador: ");
                Enf1.NomeUtil = (Console.ReadLine());

                Console.WriteLine("Insira a password: ");
                password = Console.ReadLine();
                Enf1.SetPassword(password);

                if (Enf1.Login())
                { Console.WriteLine("Login Aceite."); }
                else
                {
                    Console.WriteLine("Login Errado. Tente novamente.");
                    while (Enf1.Login() == false)
                    {
                        Console.WriteLine("Insira o nome de utilizador: ");
                        Enf1.NomeUtil = (Console.ReadLine());
                        Console.WriteLine("Insira a password: ");
                        password = Console.ReadLine();
                        Enf1.SetPassword(password);
                    }
                }

                /*------------------Enfermeiro: Escolher Menu---------------*/
                Enf1.Nome = "Maria Santos";
                Console.WriteLine();
                Console.WriteLine("Bem-vindo/a " + Enf1.Nome + "! \n Estes são os menus a que pode aceder: ");

                Console.WriteLine("\n 1. Registar Utente \n 2. Registar Consulta \n 3. Consultar Dados");
                Console.Write("Selecione o menu a que quer aceder: ");

                int escMenu2 = int.Parse(Console.ReadLine());
                switch (escMenu2)
                {
                    case 1: /*--------Registar Utente----------*/
                        Console.WriteLine("Menu escolhido: Registar Utente.");
                        Console.WriteLine();

                        //Questiona o número de registos a serem feitos
                        Console.Write("Quantos utentes serão registados? ");
                        int k = int.Parse(Console.ReadLine());

                        //Corre o ciclo for para preencher a lista de utentes com o número de registos pretendidos
                        for (int i = 1; i <= k; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Utente #{i} :"); //Apresenta os Registos Numerados
                            Console.Write("Insira o ID do Utente (exemplo: 01): ");
                            int idut = int.Parse(Console.ReadLine());
                            Console.Write("Insira o Nome do Utente: ");
                            string nomeUt = Console.ReadLine();
                            Console.Write("Insira o Género do Utente: ");
                            string genero = Console.ReadLine();
                            Console.Write("Insira a Localidade do Utente: ");
                            string localidadeUt = Console.ReadLine();
                            Console.Write("Insira a Data de Nascimento do Utente (dd/mm/yyyy): ");
                            DateOnly datanasc = DateOnly.Parse(Console.ReadLine());
                            Console.Write("Insira o Cartão de Cidadão do Utente: ");
                            int cc = int.Parse(Console.ReadLine());
                            Console.Write("Insira o Número de Utente (exemplo 000000001): ");
                            int nUt = int.Parse(Console.ReadLine());
                            Console.Write("Insira o Número de Telemóvel do Utente: ");
                            int telemovel = int.Parse(Console.ReadLine());
                            Console.Write("Insira o Email do Utente: ");
                            string email = Console.ReadLine();
                            Console.Write("Insira o Histórico de Medicação do Utente: ");
                            string historicomedicacao = Console.ReadLine();

                            ListaUtentes.AddUtente(idut, nomeUt, genero, localidadeUt, datanasc, cc, nUt, telemovel, email, historicomedicacao);

                            /*--------Mostra a Lista atualizada de Utentes-------*/
                            Console.WriteLine();
                            Console.WriteLine("Lista de Utentes atualizada: ");
                            ListaUtentes.MostrarUtentes();
                        }
                        
                        Console.WriteLine();
                        Console.WriteLine("Este registo cumpre com o Regulamento Geral de Proteção de Dados (RGPD).");
                        Console.WriteLine("--------------------");
                        
                        break; /*fim do case 1: Registar Utente*/

                    case 2: /*--------Registar Consulta----------*/
                        Console.WriteLine("Menu escolhido: Registar Consulta.");
                        Console.WriteLine();

                        //_____________________________________1ªParte___________________________________//

                        //Questiona o número de registos a serem feitos
                        Console.Write("Quantas consultas serão registadas? ");
                        int l = int.Parse(Console.ReadLine());

                        //Corre o ciclo for para preencher o relatório de consultas com o número de registos pretendidos
                        for (int i = 1; i <= l; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Consulta #{i} :"); //Apresenta os Registos Numerados
                            Console.WriteLine("Dados da Consulta");
                            Console.Write("Atribua um ID à Consulta (exemplo: 01): ");
                            int idcons = int.Parse(Console.ReadLine());

                            Console.Write("Data da consulta (dd/mm/yyyy): ");
                            DateOnly datacons = DateOnly.Parse(Console.ReadLine());

                            Console.Write("Localidade visitada: ");
                            string localidade = Console.ReadLine();

                            //_____________________________________2ªParte___________________________________//
                            Console.Write("Escreva o Nome do Utente a ser consultado: ");
                            string nome = Console.ReadLine();
                            Console.Write("Escreva o Número do Utente a ser consultado (exemplo 000000001): ");
                            int numUt = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            //_____________________________________3ªParte___________________________________//
                            Console.Write("Insira os valores de pressão arterial sistólica (PAS): ");
                            int PAS = int.Parse(Console.ReadLine());
                            Console.Write("Insira os valores de pressão arterial diastólica (PAD): ");
                            int PAD = int.Parse(Console.ReadLine());

                            if (PAS < 120 && PAD < 80)
                            {
                                Console.WriteLine("Categoria: Ótima");
                                string categoriaRisco = "Ótima";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if ((PAS > 120 && PAS < 129) || (PAD > 80 && PAD < 84))
                            {
                                Console.WriteLine("Categoria: Normal");
                                string categoriaRisco = "Normal";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if ((PAS > 130 && PAS < 139) || (PAD > 85 && PAD < 89))
                            {
                                Console.WriteLine("Categoria: Normal-Alta(1)");
                                string categoriaRisco = "Normal-Alta(1)";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if ((PAS > 140 && PAS < 159) || (PAD > 90 && PAD < 99))
                            {
                                Console.WriteLine("Categoria: HTA Grau I");
                                string categoriaRisco = "HTA Grau I";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if ((PAS > 160 && PAS < 179) || (PAD > 100 && PAD < 109))
                            {
                                Console.WriteLine("Categoria: HTA Grau II");
                                string categoriaRisco = "HTA Grau II";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if (PAS >= 180 || PAD >= 110)
                            {
                                Console.WriteLine("Categoria: HTA Grau III");
                                string categoriaRisco = "HTA Grau III";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            else if (PAS >= 140 && PAD < 90)
                            {
                                Console.WriteLine("Categoria: Hipertensão Sistólica Isolada (2)");
                                string categoriaRisco = "Hipertensão Sistólica Isolada (2)";
                                RelatorioConsultas.AddRelConsulta(idcons, datacons, localidade, categoriaRisco);
                            }
                            Console.WriteLine();

                            //___________________________________4ªParte___________________________________//

                            Console.Write("Deseja agendar nova consulta para este Utente? S/N: ");
                            char resp4 = char.Parse(Console.ReadLine());
                            if (resp4 == 'S' || resp4 == 's')
                            {
                                Console.Write("Atribua um ID à nova deslocação (exemplo 01): ");
                                int iDDesl = int.Parse(Console.ReadLine());

                                Console.Write("Indique a localidade da nova deslocação: ");
                                localidade = Console.ReadLine();

                                Console.Write("Indique a data da nova deslocação (dd/mm/yyyy): ");
                                DateOnly dataDesl = DateOnly.Parse(Console.ReadLine());

                                Console.Write("Indique o ID da Equipa encarregue da nova deslocação (exemplo: Equipa01): ");
                                string iDEquipa = Console.ReadLine();

                                //Adiciona nova deslocação à lista
                                ListaDeslocacoes.AddDeslocacao(iDDesl, localidade, dataDesl, iDEquipa);

                                /*--------Mostra a Lista de Deslocações atualizada-------*/
                                Console.WriteLine();
                                Console.WriteLine("Lista de Deslocações atualizada: ");
                                ListaDeslocacoes.MostrarDeslocacao();

                                Console.WriteLine();
                                Console.WriteLine("Consulta Agendada. Lista de Próximas Deslocações atualizada. E-mail sobre nova consulta agendade enviada ao utente.");
                                Console.WriteLine();
                                Console.WriteLine("Consulta Gravada. Listas de Dados Gerais e Deslocação por Equipa atualizadas.");
                            }
                            else
                            {
                                Console.Write("Deseja gravar consulta? S/N: ");
                                char resp5 = char.Parse(Console.ReadLine());
                                if (resp5 == 'S' || resp5 == 's')
                                {
                                    Console.WriteLine("Consulta Gravada. Listas de Dados Gerais e Deslocação por Equipa atualizadas.");
                                }
                                else { Console.WriteLine("Consulta não gravada."); }
                            }

                            /*--------Mostra o Relatório de consultas atualizado-------*/
                            Console.WriteLine();
                            Console.WriteLine("Relatório de Consultas atualizado: ");
                            RelatorioConsultas.MostrarRelConsulta();
                        }

                        break; /*fim do case 2: Registar Consulta*/

                    case 3: /*--------Consultar Dados----------*/
                        Console.WriteLine("Menu escolhido: Consultar Dados.");
                        Console.WriteLine();
                        Console.WriteLine("Escolha o submenu: \n 1. Relatório de dados estatísticos gerais das consultas \n " +
                            "2. Consulta Utentes \n 3. Consulta Próximas Deslocações \n 4. Consulta equipa por deslocação \n " +
                            "5. Consulta de equipamentos por equipa");
                        Console.Write("Selecione o submenu a que quer aceder: ");
                        int escSubMenu1 = int.Parse(Console.ReadLine());

                        switch (escSubMenu1)
                        {
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("Submenu escolhido: Relatório de dados estatísticos gerais das consultas.");
                                //Console.Write("Insira um mês e ano para consultar (MM/AAAA): "); //isto não conseguimos implementar
                                //string mesAno = Console.ReadLine();
                                //int mes = int.Parse(mesAno.Substring(0,2)); //aqui retiramos o mês, a partir da posição 0 até 2
                                //int ano = int.Parse(mesAno.Substring(3)); //aqui retiramos o ano, a partir da posição 3

                                //IMPORTANTE: Testar se funcionará utilizar o mesAno chamando o método MostrarRelConsulta
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                RelatorioConsultas.MostrarRelConsulta();
                                RelatorioConsultas.CountRelConsulta();

                                break; //fim do case 1: relatório dados estatísticos gerais das consultas
                            case 2:
                                Console.WriteLine("Submenu escolhido: Consulta de Utentes.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaUtentes.MostrarUtentes();
                                break; //fim do case 2: relatório de utentes
                            case 3:
                                Console.WriteLine("Submenu escolhido: Consulta Próximas Deslocações.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaDeslocacoes.MostrarDeslocacao();
                                break;
                            case 4:
                                Console.WriteLine("Submenu escolhido: Consulta equipa por deslocação.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaEquipas.MostrarEquipas(); //consulta equipa por localidade
                                break;
                            case 5:
                                Console.WriteLine("Submenu escolhido: Consulta de equipamentos por equipa.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaEquipamentos.MostrarEquipamentos();
                                break;
                        }

                        break; /*fim do case 3: Consultar Dados*/
                }

                /*--------------------Enfermeiro: Logout----------------------*/
                Console.WriteLine();
                Enf1.Logout();
                Console.WriteLine("----------------------------");
                Console.WriteLine();

                break;

            case FuncaoColab.Administrativo: /*-----------------------------------------LOGIN DO ADMINISTRATIVO-----------------------------------*/
                Console.WriteLine("Função: Administrativo.");
                Console.WriteLine();
                Console.WriteLine("Insira o nome de utilizador: ");
                Adm1.NomeUtil = (Console.ReadLine());

                Console.WriteLine("Insira a password: ");
                password = Console.ReadLine();
                Adm1.SetPassword(password);

                if (Adm1.Login())
                { Console.WriteLine("Login Aceite."); }
                else
                {
                    Console.WriteLine("Login Errado. Tente novamente.");
                    while (Adm1.Login() == false)
                    {
                        Console.WriteLine("Insira o nome de utilizador: ");
                        Adm1.NomeUtil = (Console.ReadLine());
                        Console.WriteLine("Insira a password: ");
                        password = Console.ReadLine();
                        Adm1.SetPassword(password);
                    }
                }

                /*------------------Administrativo: Escolher Menu---------------*/
                Adm1.Nome = "Joana Carvalho";
                Console.WriteLine();
                Console.WriteLine("Bem-vindo/a " + Adm1.Nome + "! \n Estes são os menus a que pode aceder: ");

                Console.WriteLine("\n 1. Registar Colaborador \n 2. Registar Equipamento \n 3. Consultar Dados");
                Console.Write("Selecione o menu a que quer aceder: ");

                int escMenu3 = int.Parse(Console.ReadLine());
                switch (escMenu3)
                {
                    case 1: /*--------Registar Colaborador----------*/
                        Console.WriteLine("Menu escolhido: Registar Colaborador.");
                        Console.WriteLine();

                        //Questiona o número de registos a serem feitos
                        Console.Write("Quantos colaboradores serão registados? ");
                        int n = int.Parse(Console.ReadLine());

                        //Corre o ciclo for para preencher a lista colaborador com o número de registos pretendidos
                        for (int i = 1; i <= n; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Colaborador #{i} :"); //Apresenta os Registos Numerados
                            Console.Write("Escreva a função do Colaborador: ");
                            FuncaoColab funcao1 = Enum.Parse<FuncaoColab>(Console.ReadLine());//Insere função
                            Console.Write("Escreva o ID do Colaborador (exemplo 01): ");
                            int id = int.Parse(Console.ReadLine());//Insere ID
                            Console.Write("Escreva o Nome do Colaborador: ");
                            string nome = Console.ReadLine();//Insere Nome
                            Console.Write("Escreva o Género do Colaborador: ");
                            string genero = Console.ReadLine();//Insere Género
                            Console.Write("Escreva a Localidade do Colaborador: ");
                            string localidade = Console.ReadLine();//Insere Localidade
                            Console.Write("Escreva a Data de Nascimento do Colaborador (dd/mm/yyyy): ");
                            DateOnly datanasc = DateOnly.Parse(Console.ReadLine()); //Insere Data de Nascimento
                            Console.Write("O Colaborador tem Carta de Condução S/N ? ");
                            string cartaVF = Console.ReadLine();
                            bool cartaconducao = false; //Insere Carta de Condução
                            if (cartaVF == "S" || cartaVF == "s")
                            {
                                cartaconducao = true;
                            }
                            Console.Write("Qual é o vencimento do Colaborador (exemplo 1000,50)? ");
                            double vencimento = double.Parse(Console.ReadLine()); //Insere Vencimento
                            Console.Write("Qual é o Cartão de Cidadão do Colaborador? ");
                            int cc = int.Parse(Console.ReadLine()); //Insere Cartão do Cidadão
                            Console.Write("Qual é o NIF do Colaborador? ");
                            int nif = int.Parse(Console.ReadLine()); //Insere NIF
                            Console.Write("Qual é o número de Telemóvel do Colaborador? ");
                            int telemovel = int.Parse(Console.ReadLine()); //Insere Telemóvel
                            Console.Write("Qual é o Email do Colaborador? ");
                            string email = Console.ReadLine(); //Insere Email

                            ListaColaboradores.AddColaborador(funcao1, id, nome, genero, localidade, datanasc, cartaconducao, vencimento, cc, nif, telemovel, email);
                        }

                        Console.WriteLine();

                        Console.WriteLine("Deseja gravar novo Colaborador? S/N: ");
                        char resp6 = char.Parse(Console.ReadLine());
                        if (resp6 == 'S' || resp6 == 's')
                        {
                            Console.WriteLine("Registo gravado.");
                            Console.WriteLine();
                            Console.WriteLine("Este registo cumpre com o Regulamento Geral de Proteção de Dados (RGPD).");
                            Console.WriteLine();
                            Console.WriteLine("Lista de Colaboradores atualizada: ");

                            //Mostra a Lista atualizada de Colaboradores
                            ListaColaboradores.MostrarColaborador();

                            Console.WriteLine("----------------------------------");
                            Console.WriteLine();
                        }
                        else { Console.WriteLine("Colaborador não gravado."); }

                        //Questiona o número de Equipas a serem criadas
                        Console.Write("Quantas Equipas serão criadas? ");
                        int m = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= m; i++)
                        {
                            Console.Write("Atribua um ID à Equipa (exemplo: Equipa01): ");
                            string idequipa = Console.ReadLine();//Insere ID da Equipa, exemplo: Equipa1
                            Console.Write("Atribua a Localidade para onde a Equipa se deslocará: ");
                            string localidade = Console.ReadLine();//Insere Localidade da Equipa
                            ListaEquipas.AddEquipa(idequipa,localidade);

                            /*------Mostra a Lista atualizada de Equipas-----*/
                            Console.WriteLine();
                            Console.WriteLine("Lista de Equipas atualizada: ");
                            ListaEquipas.MostrarEquipas();
                        }

                        break; /*fim do case 1: Registar Colaborador*/

                    case 2: /*--------Registar Equipamento----------*/
                        Console.WriteLine("Menu escolhido: Registar Equipamento.");
                        Console.WriteLine();
                        
                        //Questiona o número de equipamentos a serem registados
                        Console.Write("Quantos equipamentos serão registados? ");
                        int p = int.Parse(Console.ReadLine());

                        //Corre o ciclo for para preencher o relatório de consultas com o número de registos pretendidos
                        for (int i = 1; i <= p; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Registo #{i} :"); //Apresenta os Registos Numerados

                            Console.Write("Tipo de Equipamento a registar (Viatura, Tira, Estetoscópio ou Esfigmomanómetro): ");
                            Equipamento Equipamento1 = new Equipamento(); //Novo objeto inicializado vazio
                            string tipologia = Console.ReadLine();

                            if (tipologia == "Viatura" || tipologia == "viatura")
                            {
                                Console.Write("Escreva o Número de Série (exemplo: 001): ");
                                int numSerie = int.Parse(Console.ReadLine());
                                Console.Write("Escreva o Tipo de Viatura (Viatura Ligeira ou Viatura de Rastreio Ambulante): ");
                                string tipo = Console.ReadLine();
                                Console.Write("Escreva a Matrícula (exemplo: AA-01-AA): ");
                                string matricula = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Viatura Registada.");
                                Console.Write("Atribua a nova Viatura registada a uma Equipa (exemplo: Equipa01): ");
                                string iDEquipa = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("------------------");
                                Console.WriteLine();
                                ListaViaturas.AddViatura(tipologia, numSerie, iDEquipa, tipo, matricula);
                                ListaEquipamentos.AddEquipamento(tipologia, numSerie, iDEquipa);
                            }
                            else if (tipologia == "Tira" || tipologia == "tira")
                            {
                                Console.Write("Escreva o Número de Série (exemplo: 001): ");
                                int numSerie = int.Parse(Console.ReadLine());
                                Console.Write("Escreva o Tipo de Tira (Avaliação de colestrol ou Avaliação de glicose): ");
                                string tipo = (Console.ReadLine());
                                Console.Write("Escreva a Quantidade: ");
                                int quantidade = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Tira Registada.");
                                Console.Write("Atribua o novo material registado a uma Equipa (exemplo: Equipa01): ");
                                string iDEquipa = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("------------------");
                                Console.WriteLine();
                                ListaTiras.AddTira(tipologia, numSerie, iDEquipa, tipo, quantidade);
                                ListaEquipamentos.AddEquipamento(tipologia, numSerie, iDEquipa);
                            }
                            else if (tipologia == "Estetoscópio" || tipologia == "estetoscópio")
                            {
                                Console.Write("Escreva o Número de Série (exemplo: 001): ");
                                int numSerie = int.Parse(Console.ReadLine());
                                Console.Write("Escreva o Ano de Compra (yyyy): ");
                                int anoCompra = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Estetoscópio Registado.");
                                Console.Write("Atribua o novo Equipamento registado a uma Equipa (exemplo: Equipa01): ");
                                string iDEquipa = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("------------------");
                                Console.WriteLine();
                                ListaEstetoscopios.AddEstetoscopio(tipologia, numSerie, iDEquipa, anoCompra);
                                ListaEquipamentos.AddEquipamento(tipologia, numSerie, iDEquipa);
                            }
                            else if (tipologia == "Esfigmomanómetro" || tipologia == "esfigmomanómetro")
                            {
                                Console.Write("Escreva o Número de Série (exemplo: 001): ");
                                int numSerie = int.Parse(Console.ReadLine());
                                Console.Write("Possui calibração? (Sim ou Não): ");
                                string calibracao = Console.ReadLine();
                                Console.Write("Escreva o Erro (exemplo: 0,05): ");
                                double erro = double.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Esfigmomanómetro Registado.");
                                Console.Write("Atribua o novo Equipamento registado a uma Equipa (exemplo: Equipa01): ");
                                string iDEquipa = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("------------------");
                                Console.WriteLine();
                                ListaEsfigmomanometros.AddEsfigmomanometro(tipologia, numSerie, iDEquipa, calibracao, erro);
                                ListaEquipamentos.AddEquipamento(tipologia, numSerie, iDEquipa);
                            }

                            /*------Mostra a Lista atualizada de Equipamentos-----*/
                            Console.WriteLine("Lista de Equipamentos atualizada: ");
                            ListaEquipamentos.MostrarEquipamentos(); //mostra os equipamentos todos
                            Console.WriteLine();
                            ListaViaturas.MostrarViatura(); //mostra as viaturas
                            Console.WriteLine();
                            ListaTiras.MostrarTira(); //mostra as tiras
                            Console.WriteLine();
                            ListaEstetoscopios.MostrarEstetoscopio(); //mostra os estetoscópios
                            Console.WriteLine();
                            ListaEsfigmomanometros.MostrarEsfigmomanometro(); //mostra os esfigmomanómetros
                        }
                        break; /*fim do case 2: Registar Equipamento*/

                    case 3: /*--------Consultar Dados----------*/
                        Console.WriteLine("Menu escolhido: Consultar Dados.");
                        Console.WriteLine();
                        Console.WriteLine("Escolha o submenu: \n 1. Consulta Equipamentos \n 2. Consulta Colaboradores" +
                            "\n 3. Consulta Equipas \n 4. Consulta próximas deslocações.");
                        Console.Write("Selecione o submenu a que quer aceder: ");
                        int escSubMenu2 = int.Parse(Console.ReadLine());

                        switch (escSubMenu2)
                        {
                            case 1:
                                Console.WriteLine("Submenu escolhido: Consulta Equipamentos.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaEquipamentos.MostrarEquipamentos();
                                break;
                            case 2:
                                Console.WriteLine("Submenu escolhido: Consulta Colaboradores.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaColaboradores.MostrarColaborador();
                                break;
                            case 3:
                                Console.WriteLine("Submenu escolhido: Consulta Equipas.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaEquipas.MostrarEquipas();
                                break;
                            case 4:
                                Console.WriteLine("Submenu escolhido: Consulta próximas deslocações.");
                                Console.WriteLine();
                                Console.WriteLine("--------Relatório--------");
                                Console.WriteLine();
                                ListaDeslocacoes.MostrarDeslocacao();
                                break;
                        }

                        break; /*fim do case 3: Consultar Dados*/
                }

                /*--------------------Administrativo: Logout----------------------*/
                Console.WriteLine();
                Adm1.Logout();
                Console.WriteLine("----------------------------");
                Console.WriteLine();

                break;

            case FuncaoColab.Motorista: /*--------------------------------------------LOGIN DO MOTORISTA---------------------------------------*/
                Console.WriteLine("Função: Motorista.");
                Console.WriteLine();
                Console.WriteLine("Insira o nome de utilizador: ");

                Mot1.NomeUtil = (Console.ReadLine());

                Console.WriteLine("Insira a password: ");
                password = Console.ReadLine();
                Mot1.SetPassword(password);

                if (Mot1.Login())
                { Console.WriteLine("Login Aceite."); }
                else
                {
                    Console.WriteLine("Login Errado. Tente novamente.");
                    while (Mot1.Login() == false)
                    {
                        Console.WriteLine("Insira o nome de utilizador: ");
                        Mot1.NomeUtil = (Console.ReadLine());
                        Console.WriteLine("Insira a password: ");
                        password = Console.ReadLine();
                        Mot1.SetPassword(password);
                    }
                }

                /*------------------Motorista: Escolher Submenu---------------*/
                Mot1.Nome = "Tomás Rodrigues";
                Console.WriteLine();
                Console.WriteLine("Bem-vindo/a " + Mot1.Nome + "! \n Estes são os submenus a que pode aceder dentro do menu Consultar Dados: ");

                Console.WriteLine("\n 1. Consulta Equipas \n 2. Consulta Próximas Deslocações \n 3. Consulta Equipamentos por Equipa");
                Console.Write("Selecione o submenu a que quer aceder: ");
                Console.WriteLine();

                int escMenu4 = int.Parse(Console.ReadLine());
                switch (escMenu4)
                {
                    case 1: /*--------Consultar Equipas----------*/ //escolher
                        Console.WriteLine("Submenu escolhido: Consulta Equipas.");
                        Console.WriteLine();
                        Console.WriteLine("--------Relatório--------");
                        Console.WriteLine();
                        ListaEquipas.MostrarEquipas();
                        break;

                    case 2: /*--------Consultar Próximas Deslocações----------*/
                        Console.WriteLine("Submenu escolhido: Consulta Próximas Deslocações.");
                        Console.WriteLine();
                        Console.WriteLine("--------Relatório--------");
                        Console.WriteLine();
                        ListaDeslocacoes.MostrarDeslocacao();
                        break;

                    case 3: /*--------Consultar Equipamentos por Equipa----------*/ 
                        Console.WriteLine("Submenu escolhido: Consulta Equipamentos por Equipa.");
                        Console.WriteLine();
                        Console.WriteLine("--------Relatório--------");
                        Console.WriteLine();
                        ListaEquipamentos.MostrarEquipamentos();
                        break;
                }

                /*--------------------Motorista: Logout----------------------*/
                Console.WriteLine();
                Mot1.Logout();
                Console.WriteLine("----------------------------");
                Console.WriteLine();

                break;
        }

    }
}