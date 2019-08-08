using DLLFigureAbstractArea.Entities.Enums;
using System.Text;
using System.Globalization;

namespace DLLFigureAbstractArea.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {

        }

        protected Shape(Color color)
        {
            Color = color;
        }

        abstract public double Area();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"SHAPE AREAS: ");
            sb.AppendLine(Area().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
