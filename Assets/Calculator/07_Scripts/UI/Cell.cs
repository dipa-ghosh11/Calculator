using Assets.Calculator._07_Scripts.Interfaces;
using UnityEngine;

public class Cell : MonoBehaviour,ICell
{
    public int Row { get; set; }
    public int Column { get; set; }
    public string Name { get; set; }

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public float GetDistance(float cellSpaceOffset)
    {
        return spriteRenderer.bounds.size.x + cellSpaceOffset;
    }
}
