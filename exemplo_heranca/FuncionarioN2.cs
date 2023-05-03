namespace exemplo_heranca;
class FuncionarioN2:Funcionario
{
    public int idade {get;set;}
    public override double Lucro(){
        return base.Lucro()*0.02;
    }


}