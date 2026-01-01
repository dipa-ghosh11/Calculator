using UnityEngine;

public class GameManager : Base
{
    [Header("Grid Settings")]
    [SerializeField] Cell cell;
    [SerializeField] Transform gridParent;
    [SerializeField] int rowIndex;
    [SerializeField] int colIndex;


    [Header("Controllers")]
    public GridController gridController;


    protected override void Awake()
    {
        Initialize();
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {

    }

    private void Initialize()
    {
        gridController = new(cell,gridParent, rowIndex, colIndex);
    }
}

