using UnityEngine;

public class OutDoor : MonoBehaviour
{

    void Update()
    {

        Year.instance.onYearChange += AddCO2;
        
    }

    void AddCO2()
    {

        CO2.instance.AddCO2(107);

    }

}
