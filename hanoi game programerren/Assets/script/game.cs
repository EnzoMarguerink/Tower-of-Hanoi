using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    public int AmountOfDiscs = 5;
    public GameObject[] schijfArr;
    public GameObject[] pilarArr;
    public GameObject TemLoc;
    public GameObject DiskPrefab;

    private void Start()
    {
        CreateDisk();
    }

    private void Update()
    {
    }

    private void CreateDisk()
    {
        for (int i = 0; i < AmountOfDiscs; i++)
        {
            GameObject go = Instantiate(DiskPrefab);

            schijf SchijfScript = go.GetComponent<schijf>();

            go.name = "disc " + i;

            go.transform.localScale = new Vector3(6f - (i * 0.8f), 1, 1);

            schijfArr[i] = go;

            pilarArr[0].GetComponent<Pilar>().AddDisc(SchijfScript);
        }
    }
}