using Chess;
using Chess.Pieces;

Board currentBoard = new();
Bishop bishopWhite1 = new(Colour.White, new Coords(2, 2));
Bishop bishopBlack2 = new(Colour.Black, new Coords(5, 5));
currentBoard.AddPiece(bishopWhite1.position, bishopWhite1);
currentBoard.AddPiece(bishopBlack2.position, bishopBlack2);
VisualizerEngine.DisplayPieces(currentBoard.GetPieceLocations());
Console.WriteLine();
VisualizerEngine.DisplayPieceAndPossibleMoves(MoveValidator.GetLegalMoves(currentBoard, bishopWhite1), bishopWhite1.position);

var webappbuildr = WebApplication.CreateBuilder(args);
var webApp = webappbuildr.Build();
webApp.MapGet("", () => "Running...");
//webApp.Run();