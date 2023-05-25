using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{

    public TMP_Text moneyText;
    public static Money instance;
    public ulong money = 10000;
    public float time = 60;
    public uint CO2Intake = 10;

    void Awake()
    {

        instance = this;

    }

    void Update()
    {

        time -= Time.deltaTime;

        if (time <= 0)
        {

            time = 60;
            Donate(CO2Intake);

        }

        moneyText.text = "Money:\n" + money.ToString();

    }

    void Donate(uint CO2)
    {

        int addition = Random.Range((int) CO2 - 500, (int) CO2 + 500);
        addition /= 10;
        money += (ulong) addition;

    }

}
