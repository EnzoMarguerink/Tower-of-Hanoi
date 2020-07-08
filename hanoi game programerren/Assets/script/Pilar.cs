using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilar : MonoBehaviour
{
    private Stack<schijf> StickStack;
    public GameObject[] pilars;

    private void Start()
    {
        StickStack = new Stack<schijf>();
    }

    private void Update()
    {
    }

    private void OnMouseUp()
    {
        if (StickStack.Count > 0)
        {
            StickStack.Peek();
        }
        else
        {
            print("its empty brah");
        }
    }

    public void AddDisc(schijf s)
    {
        StickStack.Push(s);
    }

    public void RemoveDisc(schijf s)
    {
        StickStack.Pop();
    }

    public float AskWidth()
    {
        return transform.lossyScale.x;
    }

    public float AskHeight()
    {
        return transform.lossyScale.y;
    }
}