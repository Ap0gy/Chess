using Chess.Pieces;

namespace Chess;

public delegate Coords DirectionChange(Coords coord);


/* 
For both - and + operators:
North & South = x , y (operator)
East & West = x (operator) , y
NorthEast & SouthWest = x (operator), y (reverse operator)
NorthWest & SouthEast = x (operator), y (operator)
*/
