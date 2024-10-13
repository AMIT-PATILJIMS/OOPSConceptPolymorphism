namespace OOPSConceptPolymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape obj = new Triangle();

            obj.Draw();
            /*
             * It will print
             * Performing base class drawing tasks
             */

            /*
             * Reason : In the derived class we are using "new" keyword
             */

        }
    }

    public class Shape
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

    public class Triangle : Shape
    {
        public new void Draw()
        {
            // Code to draw a triangle...
            Console.WriteLine("Drawing a triangle");
            //base.Draw();
        }
    }
}
