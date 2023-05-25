using TMPro;
using UnityEngine;

public class Check : MonoBehaviour
{

    public TMP_Text temp;
    public TMP_Text input;

    public void chekc()
    {

        int num = int.Parse(input.text);
        temp.text = "Temperature: " + InDoorManager.instance.indoors[num].temperature.ToString();

    }

}
