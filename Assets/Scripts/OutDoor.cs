using UnityEngine;

public class OutDoor : MonoBehaviour
{

    void Start()
    {

        AddCO2();
        
    }

    void Update()
    {

        if (!Temperature.instance.canGrowOutside)
        {

            CO2.instance.SubCO2(107);

        }

    }

    void AddCO2()
    {

        CO2.instance.AddCO2(107);

    }

}
