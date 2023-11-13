using System;


public interface IEnergia
{
    void composicao();
}

public interface IRevestimento
 {
    void composicao();
 }   

public class energiaBaseTerran:IEnergia
{
    public void composicao()
    {
        Console.WriteLine("Energia mecânica Sustentável.");
    }
}

public class revestimentoBaseTerran:IRevestimento
{
    public void composicao()
    {
        Console.WriteLine("Revestimento na coloração verde.");
    }
}

public class revestimentoBasePross:IRevestimento
{
    public void composicao()
        {
            Console.WriteLine("Revestimento na cor azul.");
        }
    
}

public class energiaBasePross:IEnergia
{
    public void composicao()
    {
        Console.WriteLine("Energia suficientemente abastecida.");
    }
}

public class revestimentoBaseZerg:IRevestimento
{
    public void composicao()
    {
        Console.WriteLine("Revestimento na cor vermelha.");
    }
}

public class energiaBaseZerg:IEnergia
{
    public void composicao()
    {
        Console.WriteLine("Energia residual pronta.");
    }
}

public interface IFabricarBases
{
  void CriarBases();
}

public class fabricarBaseTerran:IFabricarBases 
{
    public fabricarBaseTerran()
    {
        CriarBases();
    }

    public void CriarBases()
    {
        Console.WriteLine("Bases Terranianas criadas com sucesso.");

        revestimentoBaseTerran revestimento = new revestimentoBaseTerran();
        revestimento.composicao();

        energiaBaseTerran energia = new energiaBaseTerran();
        energia.composicao();

    }
}

public class fabricarBasePross:IFabricarBases 
{
    public fabricarBasePross()
    {
        CriarBases();
    }

    public void CriarBases()
    {
        Console.WriteLine("Bases Pross's criadas com sucesso.");

        revestimentoBasePross revestimento = new revestimentoBasePross();
        revestimento.composicao();

        energiaBasePross energia = new energiaBasePross();
        energia.composicao();

    }
}


public class fabricarBaseZerg:IFabricarBases 
{
    public fabricarBaseZerg()
    {
        CriarBases();
    }

    public void CriarBases()
    {
        Console.WriteLine("Bases Zerg's criadas com sucesso.");

        revestimentoBaseZerg revestimento = new revestimentoBaseZerg();
        revestimento.composicao();

        energiaBaseZerg energia = new energiaBaseZerg();
        energia.composicao();

    }
}


class abstFact
{
static void Main(string[] args)
{

    IFabricarBases fabrica;
    Console.WriteLine("         1-Terran| 2-Pross| 3-Zerg");

    switch(Console.ReadLine())
    {
        case "1": fabrica=new fabricarBaseTerran();
          break;

          case "2": fabrica=new fabricarBasePross();
          break;

          case "3": fabrica=new fabricarBaseZerg();
          break;
    }
    Console.ReadLine();
}

}

