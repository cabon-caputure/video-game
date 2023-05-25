using UnityEngine;
using TMPro;

public class Temperature : MonoBehaviour
{

    public static Temperature instance;
    public TMP_Text text;
    public float temeperature = 70;
    public bool canGrowOutside = true;
    public float outPerYear = 0;

    void Awake()
    {

        instance = this;

    }

    void Update()
    {

        text.text = "Temperature: " + temeperature.ToString();

        Year.instance.onYearChange += IncreaseTemperature;

        if (temeperature > 75)
        {

            canGrowOutside = false;

        }

        if (temeperature > 90)
        {

            Application.Quit();

        }
        
    }

    void IncreaseTemperature()
    {

        temeperature += (0.03f - outPerYear);

    }

}
