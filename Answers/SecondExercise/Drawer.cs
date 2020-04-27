using System;

namespace Answers
{
    //alinea c
    [AttributeUsage(AttributeTargets.Class)]
    public class Stuck : Attribute
    {

    }

    //alinea f
    public class StuckException : Exception { }



    //alinea a, interface que verifica se um objeto corta e é afiado
    public interface IIsSharp
    {
        void Cut();
        //nivel de afiado de 1 a 3
        int Sharpness { get;}
    }

    //alinea b, classe que identifica uma faca
    public class Knife : IIsSharp
    {
        private int sharpness = 3;
        int IIsSharp.Sharpness { get => sharpness; }

        public void Cut()
        {
            if (sharpness == 1) Console.WriteLine("Não corta mais, precisa de ser afiada");
            else if (sharpness > 1)
            {
                sharpness--;
                Console.WriteLine("Cortou");
            }
        }

        public void Sharping()
        {
            if (sharpness < 3)
            {
                sharpness++;
                Console.WriteLine("Afiando...");
            }
            else if (sharpness == 3) Console.WriteLine("Afiada ao máximo");
        }


        
    }

    //alinea d
    #region utensilios
    public class Scissors : IIsSharp
    {
        private int sharpness = 3;
        int IIsSharp.Sharpness { get => sharpness; }

        public void Cut()
        {
            if (sharpness == 1) Console.WriteLine("Não corta mais, precisa de ser afiada");
            else if (sharpness > 1)
            {
                sharpness--;
                Console.WriteLine("Cortou");
            }
        }

        public void Sharping()
        {
            if (sharpness < 3)
            {
                sharpness++;
                Console.WriteLine("Afiando...");
            }
            else if (sharpness == 3) Console.WriteLine("Afiada ao máximo");
        }



    }
    public class Sword : IIsSharp
    {
        private int sharpness = 3;
        int IIsSharp.Sharpness { get => sharpness; }

        public void Cut()
        {
            if (sharpness == 1) Console.WriteLine("Não corta mais, precisa de ser afiada");
            else if (sharpness > 1)
            {
                sharpness--;
                Console.WriteLine("Cortou");
            }
        }

        public void Sharping()
        {
            if (sharpness < 3)
            {
                sharpness++;
                Console.WriteLine("Afiando...");
            }
            else if (sharpness == 3) Console.WriteLine("Afiada ao máximo");
        }



    }
    public class Saw : IIsSharp
    {
        private int sharpness = 3;
        int IIsSharp.Sharpness { get => sharpness; }

        public void Cut()
        {
            if (sharpness == 1) Console.WriteLine("Não corta mais, precisa de ser afiada");
            else if (sharpness > 1)
            {
                sharpness--;
                Console.WriteLine("Cortou");
            }
        }

        public void Sharping()
        {
            if (sharpness < 3)
            {
                sharpness++;
                Console.WriteLine("Afiando...");
            }
            else if (sharpness == 3) Console.WriteLine("Afiada ao máximo");
        }


        
    }
    public class Fork { }
    public class Spoon { }
    public class Spork { }
    public class Sticks { }

    #endregion

    //alinea f
    //public int RandomNr (int min, int max)
    //{
    //    Random rnd = new Random();
    //    return rnd.Next(min, max);
    //}

    [Stuck]
    public class Drawer
    {
      //if (Random().rnd)
    }
}
