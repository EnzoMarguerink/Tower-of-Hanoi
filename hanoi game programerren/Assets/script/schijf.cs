using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schijf : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
    }

    private void OnMouseDown()
    {
    }

    private float AskWidth()
    {
        return transform.lossyScale.x;
    }

    private float AskHeight()
    {
        return transform.lossyScale.y;
    }
}