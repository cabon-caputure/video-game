using System;
using UnityEngine;
using TMPro;

public class Year : MonoBehaviour
{

    public static Year instance;
    public uint year;
    public TMP_Text text;
    public float timer;

    void Awake()
    {

        instance = this;

    }

    void Update()
    {

        timer -= Time.deltaTime;

        if (timer <= 0)
        {

            timer = 300;
            Year.instance.YearChange();
            text.text = "Year: " + year.ToString();

        }
        
    }

    public event Action onYearChange;
    public void YearChange()
    {

        if (onYearChange != null)
        {

            onYearChange();

        }

    }

}
