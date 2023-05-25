using TMPro;
using UnityEngine;

public class CO2 : MonoBehaviour
{

    public static CO2 instance;
    public TMP_Text text;
    uint CO2Intake;

    void Awake()
    {

        instance = this;

    }

    void Update()
    {

        uint take = CO2Intake / 100000000;
        take = (uint) Mathf.Round(take);
        Temperature.instance.outPerYear = take * 0.01f;

        text.text = "Carbon Sequestered:\n" + CO2Intake.ToString();
        Money.instance.CO2Intake = CO2Intake;

    }

    public void AddCO2(uint CO2)
    {

        CO2Intake += CO2;

    }

}