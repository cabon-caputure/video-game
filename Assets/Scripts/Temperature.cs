using UnityEngine;

public class Temperature : MonoBehaviour
{

    public static Temperature instance;
    public float temeperature = 70;
    public bool canGrowOutside = true;
    public float outPerYear = 0;

    void Update()
    {

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
