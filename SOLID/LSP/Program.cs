class Program
{
   
       static void Main(string[] args)
    {
        Console.WriteLine("");
        Shape[] shapes = new Shape[2];
        shapes[0] = new Rectangle(20, 40);
        shapes[1] = new Square(10);

        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine($"Area of shape : {shapes[i].Area()}");
        }
    }
    
Console.WriteLine("");
}
