using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddUI : MonoBehaviour
{

    public int element;

    void Start()
    {

        element = UISwapper.instance.AddUI(gameObject);
        Debug.Log(element);
        
    }

}
