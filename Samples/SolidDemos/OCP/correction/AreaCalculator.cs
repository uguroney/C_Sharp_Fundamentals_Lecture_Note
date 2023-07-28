namespace OCP.correction;

internal class AreaCalculator
{
    public double CalculateArea(Shape shape)
    {
        if(shape is null)
            throw new ArgumentNullException(nameof(shape));
        return shape.Area();
    }
}
