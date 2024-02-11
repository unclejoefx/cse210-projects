class Program
{
    static void Main(string[] args)
    {
        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Grey", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Cyan", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Purple", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {

            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }

}