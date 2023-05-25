using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDoorManager : MonoBehaviour
{

    public List<InDoor> indoors = new List<InDoor>();
    public static InDoorManager instance;
    public int ACIndex;
    public AddUI AC;
    public float timer = 3;

    void Awake()
    {

        instance = this;
        
    }

    void Update()
    {

        timer -= Time.deltaTime;

        if (timer < 0)
        {

            ACIndex = AC.element;

        }
        
    }

    public void SwapToAC()
    {

        UISwapper.instance.OnAC();

    }

    public void Back()
    {

        UISwapper.instance.ONHOMe();

    }

    public void AddInstance()
    {

        indoors.Add(new InDoor());

    }

}
