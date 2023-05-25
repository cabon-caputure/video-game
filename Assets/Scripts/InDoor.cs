using UnityEngine;

public class InDoor : MonoBehaviour
{

    public uint ACCount = 0;
    public float temperature;

    void Start()
    {

        AddCO2();
        temperature = Temperature.instance.temeperature;

    }

    void Update()
    {

        temperature = Temperature.instance.temeperature;

        if (temperature < 70)
        {

            temperature = 70;

        }

        if (Temperature.instance.temeperature - ACCount > 75)
        {

            CO2.instance.SubCO2(107);

        }

    }

    public void AddAC()
    {

        ACCount += 0;

    }

    void AddCO2()
    {

        CO2.instance.AddCO2(107);

    }

}
