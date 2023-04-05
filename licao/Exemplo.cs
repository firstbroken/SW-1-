namespace licao;
class Exemplo
{
    //ATRIBUTOS
   public string nome="";
   public int idade0;
   public bool vacinado=false;

    //MÉTODOS
    public void mostramsg(){
        Console.WriteLine("oieeee 2F");
    }

    public void pegaNome(string texto){
        Console.WriteLine("Oieee: " + texto);
    }

    public string mensagem(){
        return "Devolvendo um texto";
    }

    public int somar(int a, int b){
        return a+b; 
    }
        
}   