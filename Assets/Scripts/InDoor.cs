using UnityEngine;

public class InDoor : MonoBehaviour
{

    void Start()
    {

        AddCO2();

    }

    void Update()
    {

        Year.instance.onYearChange += AddCO2;

    }

    void AddCO2()
    {

        CO2.instance.AddCO2(107);

    }

}
