namespace exercicio_aula09;
class Program
{
    static void Main(string[] args)
    {
    
        Cao luiz = new Cao();
        Gato Lucas = new Gato();
        Homem Pietro = new Homem();

        Console.WriteLine("Eu chamei o Homem e ele falou:" + Pietro.Fala());
        Console.WriteLine("Eu chamei o Gato e ele falou:" + Lucas.Fala());
        Console.WriteLine("Eu chamei o Câo e ele falou:" + luiz.Fala());

    }
}
