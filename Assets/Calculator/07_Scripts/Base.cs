using UnityEngine;

public class Base : MonoBehaviour
{
    protected virtual void Awake()
    {

    }
    protected virtual void Start()
    {
        Debug.Log("hello world");
    }

    protected virtual void Update()
    {
        
    }

    protected virtual void Print() { }
}
