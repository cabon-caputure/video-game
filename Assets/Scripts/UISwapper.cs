using UnityEngine;
using System.Collections.Generic;

public class UISwapper : MonoBehaviour
{

    public static UISwapper instance;
    public List<GameObject> uis = new List<GameObject>();
    public int index = 0;
    public GameObject ac;
    public GameObject home;

    void Awake()
    {

        instance = this;
        
    }

    public int AddUI(GameObject ui)
    {

        uis.Add(ui);
        index++;

        Debug.Log("Added Gameobject" + index);

        return index;

    }

    public void OnAC()
    {

        home.SetActive(false);
        ac.SetActive(true);

    }

    public void ONHOMe()
    {

        home.SetActive(true);
        ac.SetActive(false);

    }

    public void TurnOn(int num)
    {

        foreach(GameObject ui in uis)
        {

            ui.SetActive(false);
            Debug.Log(ui);

        }

        uis[num].SetActive(true);

    }

}
