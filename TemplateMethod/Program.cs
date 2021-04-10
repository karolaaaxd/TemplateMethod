using System;

namespace TemplateMethod

{
    class Program
    {
        abstract class Chleb
    {
        public abstract void Mieszaj();

        public abstract void Upiecz();

        public virtual void Ukroj()
        {
            Console.WriteLine("Ukroj " + GetType().Name + " Chleb!");
        }
        public void Make()
        {
           Mieszaj();
           Upiecz();
           Ukroj();
        }
    }

    class Pelnoziarnisty : Chleb
    {
        public override void Mieszaj()
        {
            Console.WriteLine("Zbieranie skladnikow na pelnoziarnisty chleb");
        }

        public override void Upiecz()
        {
            Console.WriteLine("Pieczenie chleba (30 minut)");
        }
    }

    class Ziarnisty : Chleb
    {
        public override void Mieszaj()
        {
            Console.WriteLine("Zbieranie skladnikow na ziarnisty chleb");
        }

        public override void Upiecz()
        {
            Console.WriteLine("Pieczenie chleba (20 minut)");
        }
    }

    class Pszenny : Chleb
    {
        public override void Mieszaj()
        {
            Console.WriteLine("Zbieranie skladnikow na pszenny chleb");
        }

        public override void Upiecz()
        {
            Console.WriteLine("Pieczenie chleba (15 minut)");
        }
    }
 

    static void Main(string[] args)
    {
        Ziarnisty ziarnisty = new Ziarnisty();
        ziarnisty.Make();

        Pszenny pszenny = new Pszenny();
        pszenny.Make();

        Pelnoziarnisty pelnoziarnisty = new Pelnoziarnisty();
        pelnoziarnisty.Make();

        Console.ReadKey();
    }

    }
}
