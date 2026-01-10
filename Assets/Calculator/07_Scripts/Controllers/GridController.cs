using System.Collections.Generic;
using UnityEngine;

public class GridController
{
    private Cell _cell;
    private Transform _gridParent;
    private int _rowIndex;
    private int _columnIndex;
    private float _cellSpacing;
    private float xPos;
    private float yPos;
    private Cell newCell;


    public Dictionary<Vector2Int, Cell> gridCells = new();

    public GridController(Cell cell, Transform gridParent, int rowIndex, int colIndex, float cellSpacing)
    {
        _cell = cell;
        _gridParent = gridParent;
        _rowIndex = rowIndex;
        _columnIndex = colIndex;
        _cellSpacing = cellSpacing;

        CreateGrid();
    }

    private void CreateGrid()
    {
        for (int i = 0; i < _rowIndex; i++)
        {
            for(int j = 0; j < _columnIndex; j++)
            {
                newCell=UnityEngine.GameObject.Instantiate(_cell, _gridParent);
                gridCells.Add(new Vector2Int(i, j), newCell);
                newCell.Row = i;
                newCell.Column = j;
                newCell.Name=newCell.gameObject.name=($"Cell_{i}_{j}");
                newCell.transform.localPosition=new Vector2(xPos, yPos);
                xPos+=newCell.GetDistance(_cellSpacing);
            }
            xPos = 0;
            yPos -= newCell.GetDistance(_cellSpacing);
        }
    }
}
