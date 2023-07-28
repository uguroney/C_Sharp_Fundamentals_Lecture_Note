namespace OCP.violation;

internal class AreaCalculator
{
    public double CalculateArea(Shape shape)
    {
        if(shape == null)
        {
            throw new ArgumentNullException(nameof(shape));
        }

        if (shape is Rectangle)
        {
            var rectangle = shape as Rectangle;
            if(rectangle == null) throw new ArgumentException("Cannot cast shape to rectangle");          
            return rectangle.Width * rectangle.Height;
        }
        else if (shape is Circle)
        {
            var circle = shape as Circle;
            if(circle == null) throw new ArgumentException("Cannot cast shape to circle");
            return Math.PI * circle.Radius * circle.Radius;
        }
        else
        {
            throw new ArgumentException("Shape type not supported.");
        }
    }
}
