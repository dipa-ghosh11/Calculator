using UnityEngine;

public class GridController
{
    private Cell _cell;
    private Transform _gridParent;
    private int _rowIndex;
    private int _columnIndex;

    public GridController(Cell cell, Transform gridParent, int rowIndex, int colIndex)
    {
        _cell = cell;
        _gridParent = gridParent;
        _rowIndex = rowIndex;
        _columnIndex = colIndex;

        CreateGrid();
    }

    private void CreateGrid()
    {
        for (int i = 0; i < _rowIndex; i++)
        {
            for(int j = 0; j < _columnIndex; j++)
            {
                var newCell=UnityEngine.GameObject.Instantiate(_cell, _gridParent);
                newCell.Row = i;
                newCell.Column = j;
                newCell.Name=newCell.gameObject.name=($"Cell_{i}_{j}");
            }
        }
    }
}
