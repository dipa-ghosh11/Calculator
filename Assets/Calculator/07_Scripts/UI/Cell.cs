using Assets.Calculator._07_Scripts.Interfaces;
using UnityEngine;

public class Cell : MonoBehaviour,ICell
{
    public int Row { get; set; }
    public int Column { get; set; }
    public string Name { get; set; }
}
