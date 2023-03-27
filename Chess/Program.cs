using Chess;
using Chess.Pieces;

//Board currentBoard = new();
//VisualizerEngine.DisplayBoard(currentBoard.GetPieceLocations());

var webappbuildr = WebApplication.CreateBuilder(args);
var webApp = webappbuildr.Build();
webApp.MapGet("", () => "Running...");