using Chess;
using Chess.Pieces;

Board currentBoard = new();
IPiece rook = new Rook(1);
Coords rookPieceCoords = new Coords(1, 3);

currentBoard.AddPiece(rookPieceCoords, new Piece(rook, Colour.White, rookPieceCoords));
VisualizerEngine.DisplayBoard(currentBoard.GetPieceLocations());

//var webappbuildr = WebApplication.CreateBuilder(args);
//var webApp =  webappbuildr.Build();
//webApp.MapGet("", () => "Running...");
//