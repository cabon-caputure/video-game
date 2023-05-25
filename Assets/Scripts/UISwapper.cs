using UnityEngine;
using System.Collections.Generic;

public class UISwapper : MonoBehaviour
{

    public static UISwapper instance;
    public List<GameObject> uis = new List<GameObject>();
    public int index = 0;

    void Awake()
    {

        instance = this;
        
    }

    public int AddUI(GameObject ui)
    {

        uis.Add(ui);
        index++;

        Debug.Log("Added Gameobject");

        return index;

    }

    public void TurnOn(int num)
    {

        foreach(GameObject ui in uis)
        {

            ui.SetActive(false);

        }

        uis[num].SetActive(true);

    }

}
