using System;
using System.Collections.Generic;
using System.Text;

namespace OadFigury
{
    public class Drawing
    {
        private readonly List<Figure> figures = new();

        public void Add(Figure f) => figures.Add(f);

        public double SumAreas()
        {
            return figures.Sum(f => f.Area());
        }

        public Figure? Largest()
        {
            return figures.OrderByDescending(f => f.Area()).FirstOrDefault();
        }
    }
}
