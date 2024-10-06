using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Projeto_Web_Lh_Pets_Alunos
{
    public class Banco
    {
        private List<Clientes> Lista = new List<Clientes>();

        public List<Clientes> GetLista()
        {
            return Lista;
        }

        public Banco()
        {
            // Dados simulados
            Lista.Add(
                new Clientes
                {
                    cpf_cnpj = "123.456.789-00",
                    nome = "Pedro da Silva",
                    endereco = "Rua Vergueiro 1234",
                    rg_ie = "4.567.890",
                    tipo = "f",
                    valor = 2500,
                    valor_imposto = 250,
                    total = 2750
                }
            );
            Lista.Add(
                new Clientes
                {
                    cpf_cnpj = "234.567.890-11",
                    nome = "Maria Pereira",
                    endereco = "Rua São Bento 345",
                    rg_ie = "5.678.901",
                    tipo = "f",
                    valor = 3000,
                    valor_imposto = 300,
                    total = 3300
                }
            );
            Lista.Add(
                new Clientes
                {
                    cpf_cnpj = "345.678.901-22",
                    nome = "Leonora Alvez",
                    endereco = "Rua Parati 654",
                    rg_ie = "6.789.012",
                    tipo = "f",
                    valor = 1500,
                    valor_imposto = 150,
                    total = 1650
                }
            );
            Lista.Add(
                new Clientes
                {
                    cpf_cnpj = "56.789.123/0001-00",
                    nome = "Virtual Tecnologia S/A",
                    endereco = "Av. Brasil 3456",
                    rg_ie = "567.890.123",
                    tipo = "j",
                    valor = 35000,
                    valor_imposto = 7000,
                    total = 42000
                }
            );
            Lista.Add(
                new Clientes
                {
                    cpf_cnpj = "67.890.234/0001-11",
                    nome = "J&M Associados Ltda.",
                    endereco = "Rua Paraná 765",
                    rg_ie = "678.901.234",
                    tipo = "j",
                    valor = 15000,
                    valor_imposto = 3000,
                    total = 18000
                }
            );
            Lista.Add(
                new Clientes
                {
                    cpf_cnpj = "89.012.345/0001-22",
                    nome = "Alvorada Empreendimentos S/A",
                    endereco = "Av. Constantino Alves 876",
                    rg_ie = "890.123.456",
                    tipo = "j",
                    valor = 50000,
                    valor_imposto = 10000,
                    total = 60000
                }
            );
        }

        public string GetListaString()
        {
            string enviar =
                "<!DOCTYPE html>\n<html>\n<head>\n<meta charset='utf-8' />\n<title>Cadastro de Clientes</title>\n</head>\n<body>";
            enviar +=
                "<b>   CPF / CNPJ    -      Nome    -    Endereço    -   RG / IE   -   Tipo  -   Valor   - Valor Imposto -   Total  </b>";

            int i = 0;
            string corFundo = "",
                corTexto = "";

            foreach (Clientes cli in GetLista())
            {
                if (i % 2 == 0)
                {
                    corFundo = "#6f47ff";
                    corTexto = "white";
                }
                else
                {
                    corFundo = "#ffffff";
                    corTexto = "#6f47ff";
                }
                i++;

                enviar +=
                    $"\n<br><div style='background-color:{corFundo};color:{corTexto};'>"
                    + $"{cli.cpf_cnpj} - {cli.nome} - {cli.endereco} - {cli.rg_ie} - {cli.tipo} - {cli.valor:C} - {cli.valor_imposto:C} - {cli.total:C}"
                    + "<br>"
                    + "</div>";
            }
            enviar += "</body>\n</html>";
            return enviar;
        }

        public void ImprimirListaConsole()
        {
            Console.WriteLine(
                "   CPF / CNPJ   -    Nome   -   Endereço   -   RG / IE  -  Tipo - Valor - Valor Imposto - Total"
            );

            foreach (Clientes cli in GetLista())
            {
                Console.WriteLine(
                    $"{cli.cpf_cnpj} - {cli.nome} - {cli.endereco} - {cli.rg_ie} - {cli.tipo} - {cli.valor:C} - {cli.valor_imposto:C} - {cli.total:C}"
                );
            }
        }
    }
}
