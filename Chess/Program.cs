using Chess;

Board.CreateBoard();





var webappbuildr = WebApplication.CreateBuilder(args);
var webApp =  webappbuildr.Build();
webApp.MapGet("", () => "Hello Alex");
webApp.Run(); 