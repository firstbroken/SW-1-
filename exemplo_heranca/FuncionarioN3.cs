namespace exemplo_heranca;
class FuncionarioN3:Funcionario
{
    public int idade {get;set;}
    public override double Lucro(){
        return base.Lucro()*0.03;
    }


}