namespace exercicio_2_aula09;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica CPF = new ContratoPessoaFisica();
        ContratoPessoaJuridica CNPJ = new ContratoPessoaJuridica();

        CPF.Nome = "Renan";
        CPF.Email = "renanferreirasilva14@gmail.com";
        CPF.Telefone = "11 945414300";
        CPF.CPF = "505-880-808-02";
        CPF.Idade = 17;


        CNPJ.Nome = "Renan";
        CNPJ.Email = "renanferreirasilva14@gmail.com";
        CNPJ.Telefone = "11 945414300";
        CNPJ.CNPJ = "XX.XXX.XXX/0001-XX";
        CNPJ.IE = "SP";
        CNPJ.NomeEmpresa = "SIm";

        Console.WriteLine("  Nome: " + CPF.Nome + "  renanferreirasilva14@gmail.com" + CPF.Email + "  11 945414300" + CPF.Telefone + "  505-880-808-02" + CPF.CPF + 17 + CPF.Idade);
        Console.WriteLine("  Pessoa Juridica? Aqui está" + CNPJ.MostraDados());
    }
}
