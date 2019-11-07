namespace Algorithms.Problem.Medium
{
    /// <summary>
    /// Naive implementation as an example
    /// </summary>
    public class _079_WordSearch
    {
        int rowLength, columnLength, wordLength;
        bool[,] usedMask;

        public bool Exist(char[,] board, string word)
        {
            rowLength = board.GetLength(0);
            columnLength = board.GetLength(1);
            wordLength = word.Length;
            usedMask = new bool[rowLength, columnLength];

            int i, j;
            for (i = 0; i < rowLength; i++)
            for (j = 0; j < columnLength; j++)
                if (Exist(board, word, 0, i, j, usedMask))
                    return true;

            return false;
        }

        private bool Exist(char[,] board, string word, int index, int row, int column, bool[,] used)
        {
            if (board[row, column] != word[index] || used[row, column]) { return false; }

            used[row, column] = true;
            index++;

            if (index == wordLength) { return true; }

            if ((row + 1 < rowLength && Exist(board, word, index, row + 1, column, used)) ||
                (row > 0 && Exist(board, word, index, row - 1, column, used)) ||
                (column + 1 < columnLength && Exist(board, word, index, row, column + 1, used)) ||
                (column > 0 && Exist(board, word, index, row, column - 1, used)))
            {
                return true;
            }

            used[row, column] = false;
            return false;
        }
    }
}