using MRK.Library;

namespace MKR.Console;

using System;

class Program
{
    private readonly IFileService _fileService;
    private readonly IPositionConverter _positionConverter;
    private readonly IKnightMoveCalculator _knightMoveCalculator;

    public Program(IFileService fileService, IPositionConverter positionConverter, IKnightMoveCalculator knightMoveCalculator)
    {
        _fileService = fileService;
        _positionConverter = positionConverter;
        _knightMoveCalculator = knightMoveCalculator;
    }

    static void Main(string[] args)
    {
        var fileService = new FileService();
        var converter = new PositionConverter();
        var calculator = new KnightMoveCalculator();

        var program = new Program(fileService, converter, calculator);
        program.Run();
    }

    public void Run()
    {
        string inputFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\INPUT.txt");
        string outputFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\OUTPUT.txt");

        try
        {
            var input = _fileService.ReadInput(inputFilePath);
            var startCoordinates = _positionConverter.Convert(input[0]);
            var endCoordinates = _positionConverter.Convert(input[1]);
            var result = _knightMoveCalculator.GetMinimumMoves(startCoordinates, endCoordinates);
            Console.WriteLine($"result: {result}");
            _fileService.WriteOutput(outputFilePath, result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
