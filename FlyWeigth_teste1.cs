using System;
using System.Dynamic;



public abstract class Tartaruga
{
    protected string condicao;//protected simboliza que apenas essa classe e as que a herdarem teram acesso a essa variavel;
    protected string acao;
    public string cor{get;set;}//nesse contexto get set servem como ler uma declaração sobre essa variavel e então defini-lô como parte da mesma.

    public abstract void Mostra(string cor);//Metodo que servira posteriormente(Assim que for sobrescrito) para mostrar as caracteristicas das tartarugas na tela.
}

public class Vermelha:Tartaruga
{
    public Vermelha()//Construtor que iniciara as variaveis.
    {
        this.condicao=" tartaruga dentro do casco.";//o This foi usado e deve ser usado sempre que uma variavel de outra classe tiver seu valor "alterado".
        this.acao=" Rodando no chão.\nCor:";
    }
    public override void Mostra(string qualcor)//O parametro qualcor é uma variavel, criada neste instante, que posteriormente poderá ser declara, no Main, como cor.Vide o exemplo a seguir: tartaruga.Mostra(cor);
    {
        this.cor=qualcor;
        Console.WriteLine(condicao+ acao+ cor.ToUpper());
    }


}

public class Amarela:Tartaruga
{
    public Amarela()
    {
        this.condicao=" tartaruga parada.";
        this.acao=" esperando.\nCor:";
    }
    public override void Mostra(string qualcor)
    {
        this.cor=qualcor;
        Console.WriteLine(condicao+ acao+ cor.ToUpper());
    }


}

public class Azul:Tartaruga
{
    public Azul()
    {
        this.condicao=" tartaruga em pé.";
        this.acao=" Perseguindo o player.\nCor: ";
    }
    public override void Mostra(string qualcor)
    {
        this.cor=qualcor;
        Console.WriteLine(condicao+ acao+ cor.ToUpper());
    }


}

public class FlyWheight
{
    private Dictionary<string, Tartaruga> lista_de_tartarugas=new Dictionary<string, Tartaruga>();//Semelhante a criação de classes e listas, porém, devemos declarar o modificador de acesso antes.

    public Tartaruga GetTartaruga(string cor)//A classe tartaruga foi evoca e então criamos um metodo GetTartaruga com o parametro cor. Acredito se tratar de uma variavel diferente da outra já declarada.
    {
        Tartaruga t=null;// criamos uma variavel na classe tartaruga cujo valor é nulo.
        if(lista_de_tartarugas.ContainsKey(cor))//Dictionary<Tkey,Tvalue>.ContainsKey(string)=> Declaramos um dicionario cujo o Tkey é uma string e o ContainsKey referencia que a key na verdade é cor.Se o dicionario possuir cor ele é verdade e portanto t=Dictionary;
        {
            t= lista_de_tartarugas[cor];
        }
        else{

            switch(cor)
            {
                case "Azul": t=new Azul(); break;
                case "Vermelha": t=new Vermelha(); break;
                case "Amarela": t=new Amarela(); break;
            }
            lista_de_tartarugas.Add(cor,t);
        }
        return t;
    }
}

class A1
{
    static void Main(string[] args)
    {
        FlyWheight flyWheight=new FlyWheight();
        string cor=string.Empty;

        Tartaruga tartaruga;

        while(true)//Enquanto o dicionario for True essa linha é executada ou seja o valor declarado pelo usuario no console.ReadLine logo abaixo deve estar de acordo com o parametro cor.
        {
            Console.WriteLine();
            Console.WriteLine("Qual tartaruga enviar para a tela: ");
            cor = Console.ReadLine();

            tartaruga = flyWheight.GetTartaruga(cor);//tartaruga ocupa o mesmo espaço na memoria que flyWeight.GetTartaruga(cor) e portanto são iguais.
            tartaruga.Mostra(cor);

            Console.WriteLine();
            Console.WriteLine("--------------");
        }

        
    }
}

