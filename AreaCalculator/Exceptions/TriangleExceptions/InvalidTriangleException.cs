namespace FigureCalculator.Exceptions.TriangleExceptions;

public class InvalidTriangleException : Exception
{
    public InvalidTriangleException() : base("Недопустимый треугольник. Условие существования не выполняется.")
    {
    }

    public InvalidTriangleException(string message) : base(message)
    {
    }

    public InvalidTriangleException(string message, Exception innerException) : base(message, innerException)
    {
    }
}