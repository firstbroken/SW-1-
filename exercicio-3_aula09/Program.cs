﻿namespace exe03;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica n1 = new ContratoPessoaFisica();
        ContratoPessoaJuridica n2 = new ContratoPessoaJuridica();

        n1.Email = "arthurgmari@gmail.com";
        n1.Nome = "Renan Ferreira";
        n1.Telefone = "(11) 945414300";
        n1.cpf = "123.456.789-00";
        n1.Idade = 16;
        n1.Prazo = 10;


        n2.Email = "luismetal@gmail.com";
        n2.Nome = "Luis";
        n2.Telefone = "(11) 920016390";
        n2.cnpj = "12.33545/00201-00";
        n2.ie = "123.345.678.91";
        n2.NomeEmpresa = "Metalsystem";
        n2.Prazo = 10;
        

        Console.WriteLine("os dados da Pessoa Física sao: " + n1.MostraDados());
        Console.WriteLine("os dados da Pessoa Jurídica sao: " + n2.MostraDados());
        Console.WriteLine("************************************");
        Console.WriteLine("O valor da prestação da Pessoa Física é de: " + n1.calcularPrestacao());
        Console.WriteLine("O valor da prestação da Pessoa Jurídica é de: " + n2.calcularPrestacao());
    }
}