using OadFigury;

var figures = new List<Figure> { new Circle(1), new Rectangle(2, 3), new Triangle(3, 4, 5) };
foreach (var fig in figures)
{
    Console.WriteLine(fig.Description());
}

Console.WriteLine("================================================================");

Drawing drawing = new();

drawing.Add(new Circle(2));
drawing.Add(new Rectangle(4, 5));
drawing.Add(new Triangle(3, 4, 5));

Console.WriteLine($"Suma pól: {Math.Round(drawing.SumAreas(), 2)}");

Figure? largestFigure = drawing.Largest();

if (largestFigure != null)
    Console.WriteLine($"Największa figura: {largestFigure.Description()}");
else
    Console.WriteLine("Rysunek nie zawiera figur.");

Drawing empty = new();
Console.WriteLine(empty.Largest() == null
    ? "Brak figur w pustym rysunku."
    : "Znaleziono figurę.");

Console.WriteLine("================================================================");

var animals = new List<Animal> { new Dog(), new Dog() };
foreach (var animal in animals)
{
    Console.WriteLine(animal.Bark());
}