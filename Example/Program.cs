using FigureCalculator;
using FigureCalculator.Core.Abstraction;
using FigureCalculator.Core.FigureType;
using Spectre.Console;

namespace Example;

public class Program
{
    private enum FigureType
    {
        Triangle,
        Circle
    }

    public static void Main()
    {
        var figure = AnsiConsole.Prompt(
            new SelectionPrompt<FigureType>()
                .Title("Выберите [green]фигуру[/] для вычисления площади")
                .PageSize(10)
                .MoreChoicesText("[grey](Кнопки вверх и вниз для навигации)[/]")
                .AddChoices(new List<FigureType> { FigureType.Triangle, FigureType.Circle }));

        Figure figureObject = figure switch
        {
            FigureType.Triangle => GetUserTriangle(),
            FigureType.Circle => GetUserCircle(),
            _ => throw new ArgumentException("Не выбран тип фигуры!"),
        };

        AreaCalculator.CalculateArea(figureObject, out var result);
        PrintResult(figure.ToString(), result);
    }

    private static void PrintResult(string figure, double result)
    {
        var table = new Table();

        table.AddColumn("Фигура");
        table.AddColumn("Площадь");

        table.AddRow($"{figure}", $"[green]{result}[/]");

        AnsiConsole.Write(table);
    }

    private static Circle GetUserCircle()
    {
        var r = AnsiConsole.Ask<double>("Введите [green]радуис[/] окружности: ");
        return new Circle(r);
    }

    private static Triangle GetUserTriangle()
    {
        AnsiConsole.Markup("Введите [green]значения 3 сторон[/] треугольника:\n");
        var sideA = AnsiConsole.Ask<double>("Введите значение[green] стороны А[/]: ");
        var sideB = AnsiConsole.Ask<double>("Введите значение[green] стороны B[/]: ");
        var sideC = AnsiConsole.Ask<double>("Введите значение[green] стороны C[/]: ");
        return new Triangle(sideA, sideB, sideC);
    }
}