Battleship Field Validator (C#)
This repository contains a C# solution that validates a 10x10 Battleship game field according to the classic game rules. The validator checks whether the field has the correct number and arrangement of ships, ensuring no overlapping or diagonal contact between them.

- Features
Validates the number of ships:
1 Battleship (size 4)
2 Cruisers (size 3)
3 Destroyers (size 2)
4 Submarines (size 1)

Ensures ships are placed only horizontally or vertically
Prevents ships from touching each other, including diagonally
Efficient scanning and marking of ship parts
Easy to test with 2D integer arrays (int[,])

-Technologies Used
Language: C#

Environment: .NET / Visual Studio / Codewars

-Files
BattleshipField.cs — Main logic for validating the battlefield grid

How to Use
Call the static method:
bool isValid = BattleshipField.ValidateBattlefield(field);

field should be a 10x10 int[,] array where:

1 = part of a ship
0 = water

The method returns true if the field is valid, otherwise false.
