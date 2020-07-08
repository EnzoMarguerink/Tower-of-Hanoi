using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Disc selectedDisc;

    public Stick[] sticks = new Stick[3];
    public Disc[] discs = new Disc[5];
    //public SceneManager endscene;

    private void Start()
    {
        for (int i = discs.Length - 1; i >= 0; i--)
        {
            sticks[0].stack.Push(discs[i]);
        }
    }

    public void Update()
    {
        if (sticks[2].stack.Count == 5)
        {
            //SceneManager.LoadScene(2);
        }
    }

    public void PickADisc(Disc _disc)
    {
        if (selectedDisc == null)
        {
            if (GetStick(_disc).stack.Peek().discID == _disc.discID)
            {
                selectedDisc = GetStick(_disc).stack.Peek();
                GetStick(_disc).stack.Pop();
                _disc.transform.position = transform.position;
                Debug.Log("Pick");
            }
        }
    }

    public void PlaceDisc(Stick _stick)
    {
        if (selectedDisc != null)
        {
            if (_stick.stack.Count == 0)
            {
                selectedDisc.transform.position = new Vector3(_stick.transform.position.x, _stick.stack.Count - 2.5f, 0);
                _stick.stack.Push(selectedDisc);
                selectedDisc = null;
                Debug.Log("Place");
            }
            else if (_stick.stack.Peek().discID > selectedDisc.discID)
            {
                selectedDisc.transform.position = new Vector3(_stick.transform.position.x, _stick.stack.Count - 2.5f, 0);
                _stick.stack.Push(selectedDisc);
                selectedDisc = null;
                Debug.Log("Place");
            }
        }
    }

    public Stick GetStick(Disc _disc)
    {
        for (int i = 0; i < sticks.Length; i++)
        {
            if (sticks[i].stack.Contains(_disc))
            {
                return sticks[i];
            }
        }

        return null;
    }
}