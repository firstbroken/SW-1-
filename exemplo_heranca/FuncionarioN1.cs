namespace exemplo_heranca;
class FuncionarioN1:Funcionario
{
    public int idade {get;set;}
    public override double Lucro(){
        return base.Lucro()*0.01;
    }


}