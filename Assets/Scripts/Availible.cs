using TMPro;
using UnityEngine;

public class Availible : MonoBehaviour
{

    public TMP_Text text;

    private void OnEnable()
    {
        text.text = "0-" + InDoorManager.instance.indoors.ToArray().Length.ToString();
    }

}
