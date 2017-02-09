using System;

namespace LandmineChess
{
    public class Board
    {
        private char[][] _grid;
        private int _size;

        public Board(int size)
        {
            _size = size;

            _grid = new char[_size][];

            for (int x = 0; x < _size; x++)
            {
                _grid[x] = new char[_size];

                for (int y = 0; y < _size; y++)
                {
                    _grid[x][y] = Icon.Empty;
                }
            }

            _grid[0][0] = Icon.Player;
        }

        public Position GetPlayerPosition()
        {
            for (int x = 0; x < _size; x++)
            {
                for (int y = 0; y < _size; y++)
                {
                    if (_grid[x][y] == Icon.Player)
                    {
                        return new Position(x, y);
                    }
                }
            }
            throw new Exception("Cannot find player - problem!");
        }

        public char GetCharacterAtPosition(Position position)
        {
            return _grid[position.X][position.Y];
        }
    }
}
