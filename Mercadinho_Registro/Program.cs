using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ESP_SW_AT05_DATA:26/11/2017
//Nome: Vinicius Neri Paiva de Jesus      RGM: 11171503739
//Nome: Dayelle Antonia de Souza          RGM: 11171502726			
//Nome: Natalia Inara Pires Moraes        RGM: 11171100878


namespace Mercadinho_Registro
{
    class Program
    {

        //Registro - Fornecedor
        struct F
        {
            public string categoria;
            public string empresa;
            public string cnpj;
            public string telefone;
            public string email;
            public string endereco;
            public string bairro;
            public string cep;
            public string cidade;
            public int vago;
        }                           //Fim do Registro - Fornecedores            

        //Registro - Produtos
        struct P
        {
            public string categoria;
            public string produto;
            public string codigo;
            public string tipo;
            public float preco;
            public int vago;
        }                          //Fim do Registro - Produtos

        //Registro - Clientes
        struct C
        {
            public string nome;
            public string CPF;
            public string endereco;
            public string bairro;
            public string CEP;
            public int vago;
        }                         //Fim do Registro - Clientes

        //Registro - Caixa
        struct Compras
        {
            public int vago;
            public int codigo;
            public int quant;
        }                  //Fim Registro - Caixa

        

        //Programa principal
        static void Main(string[] args)
        {
            F[] Fornecedores = new F[3];
            P[] Produtos = new P[3];                 
            C[] Clientes = new C[3];                //VETORES DE REGISTRO
            Compras[] compra = new Compras[3];

            int op = 0; 

            do               //Estrutura de repetição
            {               
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("***Menu Principal***");
                Console.WriteLine("1 - Fornecedores");
                Console.WriteLine("2 - Produtos");
                Console.WriteLine("3 - Clientes");                          //MENU PRINCIPAL
                Console.WriteLine("4 - Caixa");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                bool validar = int.TryParse(Console.ReadLine(), out op);

                while (!validar)             //Validação (caso for digitado algo que não seja numeros)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***Menu Principal***");
                    Console.WriteLine("1 - Fornecedores");
                    Console.WriteLine("2 - Produtos");
                    Console.WriteLine("3 - Clientes");
                    Console.WriteLine("4 - Caixa");
                    Console.WriteLine("5 - Sair");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção digitada inválida!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite novamente: ");
                    validar = int.TryParse(Console.ReadLine(), out op);
                }                          //Fim Validação (caso for digitado algo que não seja numeros)

                while (op < 1 || op > 5)    //Validação (caso for digitado uma opção diferente das opções existente no Menu principal)
                {                   
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***Menu Principal***");
                    Console.WriteLine("1 - Fornecedores");
                    Console.WriteLine("2 - Produtos");
                    Console.WriteLine("3 - Clientes");
                    Console.WriteLine("4 - Caixa");
                    Console.WriteLine("5 - Sair");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção digitada inválida!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite novamente: ");
                    validar = int.TryParse(Console.ReadLine(), out op);
                }                         // Fim Validação (caso for digitado uma opção diferente das opções existente no Menu principal)

                                        
                switch (op)             //Estrutura de escolha (chamada dos procedimentos)
                {
                    case 1: Fornecedor(Fornecedores); break;
                    case 2: Produto(Produtos); break;           //(Chamada dos Procedimentos)
                    case 3: Cliente(Clientes); break;
                    case 4: Caixa(Clientes,Produtos,compra); break;
                }                     //Fim da estrutura de escolha 

            } while (op != 5);              //Fim Estrutura de repetição 

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("***Encerrando***");
            Console.ReadKey();
        }         //Fim do programa principal

        static void Fornecedor(F[] fornecedor)          // INICIO PROCEDIMENTO - FORNECEDOR
        {
            int op;                              //VARIÁVEIS
            int cont=0;
            
            do                              //Inicio estrutura de repetição
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("***Menu Fornecedores***");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("3 - Listar fornecedores");               //*MENU SECUNDARIO (FORNECEDOR)
                Console.WriteLine("4 - Excluir");
                Console.WriteLine("5 - Voltar ao menu principal");
                Console.Write("Digite uma opção: ");
                bool validar = int.TryParse(Console.ReadLine(), out op);


                while (!validar)                //Validação (caso for digitado algo que não seja numeros)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("***Menu Fornecedores***");
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Consultar");
                    Console.WriteLine("3 - Listar fornecedores");
                    Console.WriteLine("4 - Excluir");
                    Console.WriteLine("5 - Voltar ao menu principal");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite novamente: ");
                    validar = int.TryParse(Console.ReadLine(), out op);
                }                               // Fim Validação (caso for digitado algo que não seja numeros)

                while (op < 1 || op > 5)       //Validação (caso for digitado uma opção diferente das opções existente no Menu principal)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("***Menu Fornecedores***");
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Consultar");
                    Console.WriteLine("3 - Listar fornecedores");
                    Console.WriteLine("4 - Excluir");
                    Console.WriteLine("5 - Voltar ao menu principal");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite novamente: ");
                    validar = int.TryParse(Console.ReadLine(), out op);
                }                             //Fim Validação (caso for digitado uma opção diferente das opções existente no Menu principal)

                switch (op)
                {           //Inicio estrutura de escolha (Fornecedor)

                    case 1:                                 //CADASTRAR
                        int cheio=0;
                        int i;                           //VARIAVEIS
                        int pausa = 0;

                        for (i = 0; i < fornecedor.Length; i++)             //inicio repetição
                        {
                            if(fornecedor[i].vago==0)
                            {
                                if (pausa==0)
                                {
                                    cont = i;               //Estrutura de controle (Cadastra um fornecedor por vez)
                                    pausa = 1;
                                }
                            }

                            else
                            {
                                cheio = cheio + 1;          //Verifica se todas as posições estão preenchidas
                            }
                        }                                   // fim repetição

                        if (cheio == fornecedor.Length)             //inicio if (cheio)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("ERRO!!!");
                            Console.WriteLine("Número maximo de cadastros alcançado!!!");
                            Console.WriteLine("Cadastro indisponivel no momento!!!");               //Mensagem de erro
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pressione uma tecla para continuar");
                            Console.ReadKey();
                        }                                           //Fim if (cheio)

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("Cadastro de Fornecedores");
                            Console.Write("Insira a categoria: ");
                            fornecedor[cont].categoria = Console.ReadLine();
                            Console.Write("Insira o nome da empresa: ");
                            fornecedor[cont].empresa = Console.ReadLine();
                            Console.Write("Insira o CNPJ: ");
                            fornecedor[cont].cnpj = Console.ReadLine();
                            Console.Write("Insira o telefone: ");
                            fornecedor[cont].telefone = Console.ReadLine();         //else (entrada)
                            Console.Write("Insira o email: ");
                            fornecedor[cont].email = Console.ReadLine();
                            Console.Write("Insira o endereço: ");
                            fornecedor[cont].endereco = Console.ReadLine();
                            Console.Write("Insira o bairro: ");
                            fornecedor[cont].bairro = Console.ReadLine();
                            Console.Write("Insira o CEP: ");
                            fornecedor[cont].cep = Console.ReadLine();
                            Console.Write("Insira a cidade: ");
                            fornecedor[cont].cidade = Console.ReadLine();
                            fornecedor[cont].vago = 1;
                            pausa = 0;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Cadastro concluido, o código deste fornecedor é {0}!!", cont + 1);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Pressione qualquer tecla para continuar");
                            Console.ReadKey();
                        }
                        break;

                    case 2:                         //CONSULTAR

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Consulta de fornecedor");
                        Console.Write("Digite o código do fornecedor: ");
                        i = int.Parse(Console.ReadLine())-1;

                        if (i < 0 || i > fornecedor.Length)         //INICIO IF
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Código inexistente");                        //IF - verifica se o código digitado existe
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Digite novamente o código do fornecedor: ");
                            i = int.Parse(Console.ReadLine())-1;
                        }                                          //FIM IF

                        if(fornecedor[i].vago==1)
                        {                                           //INICIO IF
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("Categoria:  {0}", fornecedor[i].categoria);
                            Console.WriteLine("Nome da empresa: {0}", fornecedor[i].empresa);
                            Console.WriteLine("CNPJ: {0}", fornecedor[i].cnpj);
                            Console.WriteLine("Telefone: {0}", fornecedor[i].telefone);
                            Console.WriteLine("Email: {0}", fornecedor[i].email);               //LISTAGEM DO FORNECEDOR 
                            Console.WriteLine("Endereço: {0}", fornecedor[i].endereco);
                            Console.WriteLine("Bairro: {0}", fornecedor[i].bairro);
                            Console.WriteLine("CEP: {0}", fornecedor[i].cep);
                            Console.WriteLine("Cidade: {0}", fornecedor[i].cidade);

                            Console.WriteLine("Pressione uma tecla para continuar!!");
                            Console.ReadKey();
                        }                                           //FIM IF

                        else
                        {                                           //INICIO ELSE
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Código não cadastrado!!");
                            Console.ForegroundColor = ConsoleColor.White;           //ELSE - FORNECEDOR NÃO CADASTRADO
                            Console.WriteLine("Pressione uma tecla para continuar!!");
                            Console.ReadKey();
                           
                        }                                           //FIM ELSE
                         break;

                    case 3:                                         //LISTAR
                        int j = 0;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Lista de fornecedores");

                        for (i = 0; i < fornecedor.Length; i++)         //INICIO LAÇO DE REPETIÇÃO
                        {
                            if (fornecedor[i].vago == 1)
                            {                                           //INICIO IF
                                Console.ForegroundColor = ConsoleColor.White;
                                
                                Console.WriteLine("\n\nCategoria:  {0}", fornecedor[i].categoria);
                                Console.WriteLine("Nome da empresa: {0}", fornecedor[i].empresa);
                                Console.WriteLine("CNPJ: {0}", fornecedor[i].cnpj);
                                Console.WriteLine("Telefone: {0}", fornecedor[i].telefone);
                                Console.WriteLine("Email: {0}", fornecedor[i].email);               //IF - LISTAGEM DE FORNECEDOR
                                Console.WriteLine("Endereço: {0}", fornecedor[i].endereco);
                                Console.WriteLine("Bairro: {0}", fornecedor[i].bairro);
                                Console.WriteLine("CEP: {0}", fornecedor[i].cep);
                                Console.WriteLine("Cidade: {0}", fornecedor[i].cidade);

                            }                                           //FIM IF

                            else
                            {                                           //INICIO ELSE
                                j = j + 1;                              //ELSE - SE NÃO ENCONTRADO, SOMA 1 AO J, PARA PASSAR PELA PROXIMA POSIÇÃO
                            }                                           //FIM ELSE
                 
                        }                                               //FIM LAÇO DE REPETIÇÃO

                        if (j == fornecedor.Length)
                        {                                               //INICIO IF
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nNenhum fornecedor cadastrado!!!");             //IF - FORNECEDOR NÃO CADASTRADO
                        }                                               //FIM IF

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nPressione uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 4:                                         //EXCLUSÃO

                        int escolha;                             //variavel para exclusão;
                        Console.WriteLine("Excluir fornecedor");
                        Console.Write("Digite o código do fornecedor: ");
                        i = int.Parse(Console.ReadLine()) - 1;

                        if (i < 0 || i > fornecedor.Length)
                        {                                       //INICIO IF
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Código inexistente");
                            Console.ForegroundColor = ConsoleColor.White;           //IF - FORNECEDOR NÃO CADASTRADO
                            Console.Write("Digite novamente o código do fornecedor: ");
                            i = int.Parse(Console.ReadLine()) - 1;
                        }                                       //FIM IF

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("Categoria:  {0}", fornecedor[i].categoria);
                        Console.WriteLine("Nome da empresa: {0}", fornecedor[i].empresa);
                        Console.WriteLine("CNPJ: {0}", fornecedor[i].cnpj);
                        Console.WriteLine("Telefone: {0}", fornecedor[i].telefone);
                        Console.WriteLine("Email: {0}", fornecedor[i].email);
                        Console.WriteLine("Endereço: {0}", fornecedor[i].endereco);             //LISTAGEM 
                        Console.WriteLine("Bairro: {0}", fornecedor[i].bairro);
                        Console.WriteLine("CEP: {0}", fornecedor[i].cep);
                        Console.WriteLine("Cidade: {0}", fornecedor[i].cidade);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nDeseja excluir este fornecedor?\n1 - Sim\n2 - Não"); //EXCLUSÃO
                        escolha = int.Parse(Console.ReadLine());

                        if(escolha==1)
                        {                                       //INICIO IF
                            fornecedor[i].categoria = null;
                            fornecedor[i].empresa = null;
                            fornecedor[i].cnpj = null;
                            fornecedor[i].telefone = null;
                            fornecedor[i].email = null;
                            fornecedor[i].endereco = null;                      //A EXCLUSÃO É CONCLUIDA E 
                            fornecedor[i].bairro = null;                        //A POSIÇÃO NOS VETORES É LIMPA
                            fornecedor[i].cep = null;
                            fornecedor[i].cidade = null;
                            fornecedor[i].vago = 0;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Exclusão concluida!!!");
                            Console.WriteLine("Pressione uma tecla para continuar");
                            Console.ReadKey();
                        }                                       //FIM IF

                        else
                        {                                       //INICIO ELSE
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Exclusão cancelada!!!");                     //EXCLUSÃO CANCELADA
                            Console.WriteLine("Pressione uma tecla para continuar!!");
                            Console.ReadKey();
                        }                                       // FIM ELSE
                        break;
                }                                       //Fim estrutura de escolha (Fornecedor)
            } while (op != 5);             //FIM LAÇO DE REPETIÇÃO - FORNECEDOR
        }                           //FIM PROCEDIMENTO - FORNECEDOR

        static void Produto(P[] produtos)               //INICIO PROCEDIMENTO - PRODUTO
        {  
            int op;
            
            do                                       //INICIO LAÇO DE REPETIÇÃO - PRODUTO
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("***Menu Produtos***");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("3 - Listar código dos produtos");                //MENU SECUNDARIO - PRODUTO
                Console.WriteLine("4 - Excluir");
                Console.WriteLine("5 - Voltar ao menu principal");
                Console.Write("Digite uma opção: ");
                bool validar = int.TryParse(Console.ReadLine(), out op);

                while (!validar)                                //VALIDAÇÃO - CASO SEJA DIGITADO ALGO DIFERENTE DE NUMEROS
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("***Menu Produtos***");
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Consultar");
                    Console.WriteLine("3 - Listar código dos produtos");
                    Console.WriteLine("4 - Excluir");
                    Console.WriteLine("5 - Voltar ao menu principal");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite novamente: ");
                    validar = int.TryParse(Console.ReadLine(), out op);
                }                                               //FIM VALIDAÇÃO - CASO SEJA DIGITADO ALGO DIFERENTE DE NUMEROS

                while (op < 1 || op > 5)                        //VALIDAÇÃO - CASO SEJA DIGITADO ALGO DIFERENTE DAS OPÇÕES EXISTENTE NO MENU
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("***Menu Produtos***");
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Consultar");
                    Console.WriteLine("3 - Listar código dos produtos");
                    Console.WriteLine("4 - Excluir");
                    Console.WriteLine("5 - Voltar ao menu principal");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite novamente: ");
                    validar = int.TryParse(Console.ReadLine(), out op);
                }                                               //FIM VALIDAÇÃO - CASO SEJA DIGITADO ALGO DIFERENTE DAS OPÇÕES EXISTENTE NO MENU

                switch (op)                                     //INICIO ESTRUTURA DE ESCOLHA 
                {          

                    case 1:                                     //CADASTRAR
                        int cheio = 0;
                        int i;
                        int pausa = 0;                          //VARIÁVEIS
                        int j = 0;

                        for (i = 0; i < produtos.Length; i++)                //INICIO LAÇO DE REPETIÇÃO 
                        {
                            if (produtos[i].vago == 0)          //INICIO IF - VAGO  
                            {
                                if (pausa == 0)                 //INICIO IF - PAUSA
                                {
                                    j = i;                                         //ESTRUTURA DE CONTROLE - CADASTRA UM PRODUTO POR VEZ
                                    pausa = 1;
                                }                               //FIM IF - PAUSA
                            }                                   //FIM IF VAGO

                            else                                //INICIO ELSE
                            {   
                                cheio = cheio + 1;                                 //VERIFICA SE TODAS AS POSIÇÕES ENTÃO PREENCIDAS
                            }                                 //FIM ELSE
                        }                                                    //FIM LAÇO DE REPETIÇÃO

                        if (cheio == produtos.Length)               //INICIO IF - CHEIO
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("ERRO!!!");
                            Console.WriteLine("Número maximo de cadastros alcançado!!!");
                            Console.WriteLine("Cadastro indisponivel no momento!!!");               //MENSAGEM DE ERRO
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pressione uma tecla para continuar");
                            Console.ReadKey();
                        }                                           //FIM IF - CHEIO 

                        else                                            //INICIO ELSE
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("Cadastro de produtos");
                            Console.Write("Insira a categoria: ");
                            produtos[j].categoria = Console.ReadLine();
                            Console.Write("Insira o produto: ");
                            produtos[j].produto = Console.ReadLine();                                           //ELSE - ENTRADA
                            Console.Write("Insira o tipo de venda do produto (kg,uni,L etc): ");
                            produtos[j].tipo = Console.ReadLine();
                            Console.Write("Insira preço do produto: ");
                            produtos[j].preco = float.Parse(Console.ReadLine());
                            produtos[j].vago = 1;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Cadastro concluido, o código deste produto é {0}!!", j+1);
                            Console.Write("Pressione qualquer tecla para continuar");
                            Console.ReadKey();
                        }                                               //FIM ELSE
                        break;

                    case 2:                                             //CONSULTAR
                        Console.Clear();

                        int cont = 0;                                   //VARIAVEIS
                        int codigo;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Consulta de produto");
                        Console.Write("Digite o código do produto: ");
                        codigo = int.Parse(Console.ReadLine())-1;

                        for (i = 0; i < produtos.Length; i++)                   //INICIO LAÇO DE REPETIÇÃO
                        {
                            if (i == codigo)                                //INICIO IF 
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("Categoria:  {0}", produtos[i].categoria);
                                Console.WriteLine("Produto: {0}", produtos[i].produto);
                                Console.WriteLine("Preço: {0:C}/{1}", produtos[i].preco,produtos[i].tipo);
                                
                                Console.WriteLine("Pressione uma tecla para continuar!!");
                                cont = 0;
                                Console.ReadKey(); break;
                            }                                               //FIM IF 

                            else                                        //INICIO ELSE
                            {
                                cont = 1;                       //VERIFICA SE O PRODUTO EXISTE
                            }                                           //FIM ELSE
                        }                                                       //FIM LAÇO DE REPETIÇÃO

                        if (cont == 1)                                  //INICIO IF
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Código inexistente");                                    //PRODUTO - NÃO EXISTE
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Pressione uma tecla para continuar");
                            Console.ReadKey();
                        }                                               //FIM IF
                        break;

                    case 3:                                             //LISTAGEM
                        int l=0;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Listagem de produtos cadastrados\n");

                        for(i=0;i<produtos.Length;i++)                      //INICIO LAÇO DE REPETIÇÃO
                        {
                            if(produtos[i].vago==1)                             //INICIO IF - VAGO
                            {
                                Console.WriteLine("\n\nProduto: {0}\nCódigo: {1}", produtos[i].produto, i+1);       //LISTAGEM DO PRODUTO
                            }                                                   //FIM IF - VAGO

                            else                                                //INICIO ELSE
                            {
                                l = l + 1;                                      //SOMA A L+1 CASO NAO EXISTA O PRODUTO
                            }                                                            //FIM ELSE
                        }                                                    //FIM LAÇO DE REPETIÇÃO

                        if(l==produtos.Length)                                 //INICIO IF - L
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nNenhum produto cadastrado");           //MENSAGEM - PRODUTO NÃO CADASTRADO
                        }                                                       //FIM IF - L

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nPressione uma tecla para continuar!!");
                        Console.ReadKey();

                        break;


                    case 4:                                         //EXCLUSÃO

                        int exclusao;
                        int k=0;
                        int indisponivel = 0;                           //VARIAVEIS
                        int codprod;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Exclusão de produto");
                        Console.Write("Insira o código do produto: ");
                        codprod = int.Parse(Console.ReadLine())-1;

                        for(i=0;i<produtos.Length;i++)                                      //INICIO LAÇO DE REPETIÇÃO
                        {
                            if(i==codprod)                                              //INICIO IF
                            {
                                k = i;
                            }                                                           //FIM IF

                            else                                                        //INICIO ELSE
                            {
                                indisponivel = indisponivel + 1;
                            }                                                           //FIM ELSE
                        }                                                                   //FIM LAÇO DE REPETIÇÃO

                        if(indisponivel==produtos.Length)                                       //INICIO IF
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Código inexistente!!!");                                 //PRODUTO - INEXISTENTE
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pressione uma tecla para continuar!!!");
                            Console.ReadKey();
                        }                                                                   //FIM IF

                        else                                                               //INICIO ELSE
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("Categoria:  {0}", produtos[k].categoria);
                            Console.WriteLine("Produto: {0}", produtos[k].produto);                 //LISTAGEM 
                            Console.WriteLine("Preço: {0}/{1}", produtos[k].preco,produtos[k].tipo);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Deseja excluir este produto?\n1 - Sim\n2 - Não");
                            exclusao = int.Parse(Console.ReadLine());

                            if(exclusao==1)                                     //INICIO IF - EXCLUSÃO
                            {
                                produtos[k].categoria = null;
                                produtos[k].produto = null;
                                produtos[k].preco = 0;
                                produtos[k].tipo = null;                                //ESCLUSÃO
                                produtos[k].codigo = null;                               //VETORES LIMPO
                                produtos[k].vago = 0;

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Produto excluido com sucesso!!");
                                Console.WriteLine("Pressione uma tecla para continuar!!!");
                                Console.ReadKey();
                            }                                               //FIM IF - EXCLUSÃO

                            else                                                //INICO ELSE
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Exclusão cancelada!!!");         //EXCLUSÃO CANCELADA 
                                Console.ReadKey();
                            }                                                      // FIM ELSE
                        }                                      //FIM ELSE
                        break;
                }                                           //FIM DA ESTRUTURA DE ESCOLHA - PRODUTO
            } while (op != 5);                      //FIM LAÇO DE REPETIÇÃO
        }                              //FIM PROCEDIMENTO - PRODUTO 

        static void Cliente(C[] clientes)               //INICIO PROCEDIMENTO - CLIENTE
        {
            int op;

            do                                      //INICIO LAÇO DE REPETIÇÃO
            {       
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("***Menu Clientes***");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("3 - Listar clientes");                                       //MENU SECUNDARIO - CLIENTES
                Console.WriteLine("4 - Excluir");
                Console.WriteLine("5 - Voltar ao menu principal");
                Console.Write("Digite uma opção: ");
                bool validar = int.TryParse(Console.ReadLine(), out op);

                while (!validar)                        //VALIDAÇÃO - CASO SEJA DIGITADO ALGO DIFERENTE DE NUMEROS
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***Menu Clientes***");
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Consultar");
                    Console.WriteLine("3 - Listar clientes");
                    Console.WriteLine("4 - Excluir");
                    Console.WriteLine("5 - Voltar ao menu principal");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite novamente: ");
                    validar = int.TryParse(Console.ReadLine(), out op);
                }                                                   //FIM VALIDAÇÃO - CASO SEJA DIGITADO ALGO DIFERENTE DE NUMEROS

                while (op < 1 || op > 5)                            //VALIDAÇÃO - CASO SEJA DIGITADO ALGO DIFERENTE DAS OPÇÕES EXISTENTE NO MENU
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***Menu Clientes***");
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Consultar");
                    Console.WriteLine("3 - Listar clientes");
                    Console.WriteLine("4 - Excluir");
                    Console.WriteLine("5 - Voltar ao menu principal");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite novamente: ");
                    validar = int.TryParse(Console.ReadLine(), out op);
                }                                                   //FIM VALIDAÇÃO - CASO SEJA DIGITADO ALGO DIFERENTE DAS OPÇÕES EXISTENTE NO MENU

                switch (op)                                     //INICIO ESTRUTURA DE ESCOLHA
                {           

                    case 1:                                     //CADASTRAR

                        int i;
                        int cont=0;
                        int pausa=0;                            //VARIAVEIS
                        int cheio=0;

                        for (i = 0; i < clientes.Length; i++)                   //INICIO AÇO DE REPETIÇÃO
                        {
                            if (clientes[i].vago == 0)                          //INICIO IF - VAGO
                            {
                                if (pausa == 0)                                 //INICIO IF -´PAUSA
                                {
                                    cont = i;                           //ESTRUTURA DE CONTROLE - CADASTRAR UM CIENTE POR VEZ
                                    pausa = 1;
                                }                                                //FIM IF - PAUSA
                            }                                                   //FIM IF - VAGO

                            else                                            //INICIO ELSE
                            {
                                cheio = cheio + 1;                      //VERIFICA SE TODAS AS POSIÇÕES ESTÃO PREENCHIDAS
                            }                                           //FIM ELSE
                        }                                       //FIM LAÇO DE REPETIÇÃO

                        if(cheio==clientes.Length)                                  //INICIO IF - CHEIO
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("ERRO!!!");
                            Console.WriteLine("Número maximo de cadastros alcançado!!!");
                            Console.WriteLine("Cadastro indisponivel no momento!!!");                       //MENSAGEM DE ERRO
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pressione uma tecla para continuar");
                            Console.ReadKey();
                        }                                                           //FIM IF - CHEIO

                        else                                                //INICIO ELSE
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("Cadastro de Clientes");
                            Console.Write("Insira o nome do cliente: ");
                            clientes[cont].nome = Console.ReadLine();
                            Console.Write("Insira o CPF: ");
                            clientes[cont].CPF = Console.ReadLine();
                            Console.Write("Insira o endereço: ");
                            clientes[cont].endereco = Console.ReadLine();                               //ELSE - ENTRADA
                            Console.Write("Insira o bairro: ");
                            clientes[cont].bairro = Console.ReadLine();
                            Console.Write("Insira o CEP: ");
                            clientes[cont].CEP = Console.ReadLine();
                            clientes[cont].vago = 1;
                            pausa = 0;

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Cadastro concluido, o código deste cliente é {0}!!", cont + 1);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Pressione qualquer tecla para continuar");
                            Console.ReadKey();
                        }                                                       //FIM ELSE                 
                        break;

                    case 2:                                                 //CONSULTAR

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Consulta de clientes");
                        Console.Write("Digite o código do cliente: ");
                        i = int.Parse(Console.ReadLine())-1;

                        if (i < 0 || i > clientes.Length)                                           //VERIFICA SE FOR DIGITADO UM CODIGO DIFERENTE DOS CADASTRADOS
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Código inexistente");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Digite novamente o código do cliente: ");
                            i = int.Parse(Console.ReadLine())-1;
                        }                                                                           //FIM VERIFICA SE FOR DIGITADO UM CODIGO DIFERENTE DOS CADASTRADOS

                        if(clientes[i].vago==0)                                             //INICIO IF - VAGO
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Código não cadastrado!!!");
                            Console.ForegroundColor = ConsoleColor.White;                                       //MENSAGEM DE ERRO - CLIENTE
                            Console.WriteLine("Pressione uma tecla para continuar");
                            Console.ReadKey();
                        }                                                                       //FIM IF - VAGO

                        else                                                        //INICIO ELSE
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Nome:  {0}", clientes[i].nome);
                            Console.WriteLine("CPF:  {0}", clientes[i].CPF);                            //LISTAGEM
                            Console.WriteLine("Endereço:  {0}", clientes[i].endereco);
                            Console.WriteLine("Bairro:  {0}", clientes[i].bairro);
                            Console.WriteLine("CEP:  {0}", clientes[i].CEP);

                            Console.WriteLine("Pressione uma tecla para continuar!!");
                            Console.ReadKey();
                        }                                                                       //FIM ELSE
                         break;

                    case 3:                                             //LISTAGEM

                        int j=0;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Lista de clientes");

                        for (i=0;i<clientes.Length;i++)                     //INICIO DO LAÇO DE REPETIÇÃO
                        {
                            if(clientes[i].vago==1)                     //INICIO DO IF
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\nCódigo do cliente: {0}", i + 1);
                                Console.WriteLine("Nome:  {0}", clientes[i].nome);
                                Console.WriteLine("CPF:  {0}", clientes[i].CPF);                        //LISTAGEM - PRODUTO
                                Console.WriteLine("Endereço:  {0}", clientes[i].endereco);
                                Console.WriteLine("Bairro:  {0}", clientes[i].bairro);
                                Console.WriteLine("CEP:  {0}", clientes[i].CEP);
                            }                                       //FIM DO IF

                            else                                    //INICIO DO ELSE
                            {
                                j = j + 1;                              //SE NÃO  CADASTRSADO, SOMA J+1
                            }                                       //FIM DO ELSE
                        }

                        if(j==clientes.Length)                                          //INICIO DO IF
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nNenhum cliente cadastrado!!!");        //CLIENTE NÃO CADASTRADO 
                        }                           //FIM DO IF

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nPressione uma tecla para continuar");
                        Console.ReadKey();
                        break;


                    case 4:                                             //EXCLUSÃO

                        int escolha;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Consulta de clientes");
                        Console.Write("Digite o código do cliente: ");
                        i = int.Parse(Console.ReadLine()) - 1;

                        if (i < 0 || i > clientes.Length)                                   //INICIO DO IF - VERIFICA SE O CODIGO EXISTE
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Código inexistente");
                            Console.ForegroundColor = ConsoleColor.White;                           //MENSAGEM DE ERRO - CODIGO INEXISTENTE
                            Console.Write("Digite novamente o código do cliente: ");
                            i = int.Parse(Console.ReadLine()) - 1;
                        }                                                                   //FIM DO IF

                        if (clientes[i].vago == 0)                              //INICIO DO IF - VAGO
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Código não cadastrado!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pressione uma tecla para continuar");
                            Console.ReadKey();
                        }                                               //FIM DO IF VAGO

                        else                                            //INICIO DO ELSE
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Nome:  {0}", clientes[i].nome);
                            Console.WriteLine("CPF:  {0}", clientes[i].CPF);                //LISTAGEM 
                            Console.WriteLine("Endereço:  {0}", clientes[i].endereco);
                            Console.WriteLine("Bairro:  {0}", clientes[i].bairro);
                            Console.WriteLine("CEP:  {0}", clientes[i].CEP);

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nDeseja excluir este cliente?\n1 - Sim\n2 - Não");
                            escolha = int.Parse(Console.ReadLine());
                            
                            if(escolha==1)                      //INICIO DO IF
                            {
                                clientes[i].nome = null;
                                clientes[i].CPF = null;
                                clientes[i].endereco = null;                //EXCLUSÃO
                                clientes[i].bairro = null;                  //VETORES LIMPOS
                                clientes[i].CEP = null;
                                clientes[i].vago = 0;

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Exclusão concluida!!");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Pressione uma tecla para continuar");
                                Console.ReadKey();
                            }                                       //FIM DO IF

                            else                                                    //INICIO DO ELSE
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Exclusão cancelada!!!");                     //EXCLUSÃO CANCELADA
                                Console.WriteLine("Pressione uma tecla para continuar");
                                Console.ReadKey();
                            }                                       //FIM DO ELSE
                        }                           //FIM ELSE
                   break;
                }                   //FIM ESTRUTURA DE ESCOLHA

            } while (op != 5);             //FIM ESTRUTURA DE REPETIÇÃO 
        }                              //FIM PROCEDIMENTO - CLIENTE

        static void Caixa(C[] clientes, P[] produtos, Compras[] compra)         //INICIO PROCEDIMENTO - CAIXA
        {
            int op;
            int cad;
            int quantidade;
            int escolha;
            int codcli;
            int codprod;
            float pre;                                      //VARIAVEIS
            float subtot = 0;
            int op2;
            int op3;
            double km;
            double prekm;
            double juros;
            double total;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Registro de compras");                                   //CLIENTE JA CADASTRADO
                Console.WriteLine("Cliente ja cadastrado?\n1 - Sim\n2 - Não");
                cad = int.Parse(Console.ReadLine());

                if (cad == 2)                               //INICIO DO IF
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Deseja cadastrar cliente?\n1 - Sim\n2 - Não");                                   //OPÇÃO DE CADASTRAR NOVO CLIENTE
                    escolha = int.Parse(Console.ReadLine());

                    if (escolha == 1)                   //INICIO DO IF
                    {
                        Cliente(clientes);
                    }                                   //FIM DO IF
                }                                               //FIM DO IF

                else                                                //INICIO DO ELSE - NOVO CADASTRO
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Insira o código do cliente: ");
                    codcli = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Cliente{0}", clientes[codcli].nome);
                }                                           //FIM DO ELSE - NOVO CADASTRO

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Inserir código de outro produto");
                Console.WriteLine("2 - Finalizar compra");                      //MENU SECUNDARIO
                Console.WriteLine("3 - Cancelar compra");
                Console.Write("Escolha uma opção: ");
                op = int.Parse(Console.ReadLine());

                for (int k = 0; k < 3; k++)                                     //INICIO LAÇO DE REPETIÇÃO
                {

                    for (int j = 0; j <3; j++)
                    {
                        if (op == 1)                                        //INICIO DO IF - OP 1
                        {
                            Console.Write("\nProduto: {0}||Preço: {1}/{2}||Quant: {3}\n\n", produtos[compra[k].codigo].produto, produtos[compra[k].codigo].preco, produtos[compra[k].codigo].tipo, compra[k].quant);
                            Console.Write("\nInsira o código do produto: ");
                            codprod = int.Parse(Console.ReadLine()) - 1;


                            for (int i = 0; i < 3; i++)               //INICIO DO LAÇO DE REPETIÇÃO
                            {
                                pre = 0;
                                if (codprod == i)                           //INICIO IF
                                {

                                    if (compra[i].vago == 0)                                        //INICIO IF
                                    {
                                        Console.Write("Digite a quantidade: ");
                                        compra[i].quant = int.Parse(Console.ReadLine());
                                        compra[i].codigo = codprod;
                                        compra[i].vago = 1;
                                        pre = compra[i].quant * produtos[i].preco;
                                        subtot = subtot + pre;

                                    }                                               //FIM IF

                                    else                                    //INICIO DO ELSE
                                    {
                                        Console.Write("Digite a quantidade: ");
                                        quantidade = int.Parse(Console.ReadLine());
                                        compra[i].quant = compra[i].quant + quantidade;
                                        pre = compra[i].quant * produtos[i].preco;
                                        subtot = subtot + pre;
                                    }                                          //FIM DO ELSE
                                }                                           //FIM DO IF - CODPROD
                            }                                            //FIM DO LAÇO DE REPETIÇÃO
                        }                                             //FIM IF - OP 1
                    }                                           //FIM DO LAÇO DE REPETIÇÃO
                }                                             //FIM DO LAÇO DE REPETIÇÃO

                    if (op == 2)                            //INICIO IF - FINALIZAR COMPRA
                    {
                        Console.Clear();
                        Console.WriteLine("Subtotal: {0:C}", subtot);
                        Console.WriteLine("Cliente deseja entrega a domicilio?\n1 - Sim\n2 - Não");
                        op2 = int.Parse(Console.ReadLine());

                        if (op2 == 2)                                   //INICIO IF - SEM ENTREGA A DOMICILIO
                        {
                            total = subtot;
                            Console.Clear();
                            Console.WriteLine("Total: {0:C}", total);
                            Console.WriteLine("Formas de pagamento\n1 - A vista\n2 - 2x c/ 5% acrés.\n3 - 3x c/ 10% acrés.");           //OPÇÕES DE PAGMENTO
                            op3 = int.Parse(Console.ReadLine());

                            if (op3 == 1)                       //INICIO IF - A VISTA
                            {
                                Console.Clear();
                                Console.WriteLine("Total:{0:C}");
                            }                       //FIM IF - A VISTA

                            else if (op3 == 2)                  //INICIO IF - 5% DE JUROS
                            {
                                juros = total * 0.05;
                                total = total + juros;
                                Console.Clear();
                                Console.WriteLine("Total: {0:C}", total);
                            }                                 //FIM IF - 5% DE JUROS

                            else                  //INICIO ELSE - 10% DE JUROS
                            {
                                    juros = total * 0.1;
                                    total = total + juros;
                                    Console.Clear();
                                    Console.WriteLine("Total: {0:C}", total);
                                    Console.WriteLine("Agradecemos a preferencia.\nCompra concluida!!!");
                                    Console.WriteLine("Pressione uma tecla para encerrar");
                                    Console.ReadKey();
                            }                           //FIM ELSE - 10% DE JUROS

                            Console.Clear();
                            Console.WriteLine("Valor Final: {0:C}", total);
                            Console.WriteLine("Agradecemos a preferencia.\nCompra concluida!!!");
                            Console.WriteLine("Pressione uma tecla para encerrar");
                            Console.ReadKey();
                        }                                   //FIM IF - SEM ENTREGA A DOMICILIO

                        else                                //INICIO ELSE - COM ENTREGA A DOMICILIO
                        {
                            total = subtot;
                            Console.Clear();
                            Console.WriteLine("Total: {0:C}", total);
                            Console.WriteLine("Formas de pagamento\n1 - A vista\n2 - 2x c/ 5% acrés.\n3 - 3x c/ 10% acrés.");
                            op3 = int.Parse(Console.ReadLine());

                            if (op3 == 1)                                 //INICIO IF - A VISTA
                            {
                                Console.Clear();
                                Console.WriteLine("Total:{0:C}");
                            }                                             //FIM IF - A VISTA

                            else if (op3 == 2)                                            //INICIO IF - 5% DE JUROS
                            {
                                juros = total * 0.05;
                                total = total + juros;
                                Console.Clear();
                                Console.WriteLine("Total: {0:C}", total);
                            }                                         //FIM IF - 5% DE JUROS

                            else                                        //INICIO ELSE - 10% DE JUROS
                            {
                                juros = total * 0.1;
                                total = total + juros;
                                Console.Clear();
                                Console.WriteLine("Total: {0:C}", total);
                            }                                           //FIM ELSE - 10% DE JUROS

                            if (subtot >= 100)                          //INICIO IF - ENTREGAS GRATUITA ACIMA DE 100 REAIS 
                            {
                                Console.Clear();
                                Console.WriteLine("Entrega gratuita!!!");
                                prekm = 0;
                                Console.WriteLine("Agradecemos a preferencia.\nCompra concluida!!!");
                                Console.WriteLine("Pressione uma tecla para encerrar");
                                Console.ReadKey();
                            }                                           //FIM IF - ENTREGAS GRATUITA ACIMA DE 100 REAIS

                            else
                            {                                           //INICIO ELSE - TARIFA DE ENTREGA
                                Console.Clear();
                                Console.WriteLine("Tarifa de entrega  R$2,50/Km");
                                Console.Write("Digite a distancia em km: ");
                                km = double.Parse(Console.ReadLine());
                                prekm = km * 2.50;
                            }                                           //FIM ELSE - TARIFA DE ENTREGA

                            total = total + prekm;
                            Console.Clear();
                            Console.WriteLine("Valor Final: {0:C}", total);
                            Console.WriteLine("Agradecemos a preferencia.\nCompra concluida!!!");                           //TOTAL=FRETE
                            Console.WriteLine("Pressione uma tecla para encerrar");
                            Console.ReadKey();
                        }
                    }

                    else if(op==3)
                    {                                                           //OPÇÃO DE EXCLUSÃO
                        for (int k = 0; k < compra.Length; k++)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\nProduto: {0}||Preço: {1}/{2}||Quant: {3}\n\n", produtos[compra[k].codigo].produto, produtos[compra[k].codigo].preco, produtos[compra[k].codigo].tipo, compra[k].quant);


                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nDeseja excluir esta compra?\n1 - Sim\n2 - Não");
                            escolha = int.Parse(Console.ReadLine());

                            if (escolha == 1)                      //INICIO DO IF
                            {
                                produtos[compra[k].codigo].produto = null;
                                produtos[compra[k].codigo].preco = 0;                           //EXCLUSÃO
                                produtos[compra[k].codigo].tipo = null;                         //VETORES LIMPO
                                compra[k].quant = 0;
                                subtot = 0;

                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Exclusão concluida!!");                              //EXCLUSÃO CONCLUIDA
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Pressione uma tecla para continuar");
                                    Console.ReadKey();
                            }                                       //FIM DO IF

                            else                                                    //INICIO DO ELSE
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Exclusão cancelada!!!");                     //EXCLUSÃO CANCELADA
                                Console.WriteLine("Pressione uma tecla para continuar");
                                Console.ReadKey();
                            }               //FIM ELSE
                         }           //FIM LAÇO DE REPETIÇÃO
                    }                   //FIM IF - EXCLUSÃO
            } while (op!=2);            //FIM LAÇO DE REPETIÇÃO                   
        }                                              //FIM DO PROCEDIMENTO - CAIXA
    }           //FIM CLASS PROGRAM
}           //FIM NAMESPACE

