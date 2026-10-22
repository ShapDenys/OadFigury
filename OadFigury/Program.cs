using OadFigury;

var figures = new List<Figure> { new Circle(1), new Rectangle(2, 3), new Triangle(3, 4, 5) };
foreach (var fig in figures)
{
    Console.WriteLine(fig.Description());
}