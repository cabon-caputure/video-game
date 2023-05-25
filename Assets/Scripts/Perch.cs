using TMPro;
using UnityEngine;

public class Perch : MonoBehaviour
{

    public TMP_Text input;

    public void BUy()
    {

        if (Money.instance.money < 10000) { return; }

        InDoorManager.instance.indoors[int.Parse(input.text)].AddAC();
        Money.instance.money -= 10000;

    }

}
