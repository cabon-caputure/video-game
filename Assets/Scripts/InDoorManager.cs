using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDoorManager : MonoBehaviour
{

    public List<InDoor> indoors = new List<InDoor>();
    public static InDoorManager instance;

    void Awake()
    {

        instance = this;
        
    }

    public void AddInstance()
    {

        indoors.Add(new InDoor());

    }

}
