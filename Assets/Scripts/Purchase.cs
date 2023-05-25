using UnityEngine;

public class Purchase : MonoBehaviour
{

    public Transform outdoor;
    public GameObject outdoorNew;
    public Transform indoor;
    public GameObject indoorNew;
    public static Purchase instance;

    void Awake()
    {

        instance = this;

    }

    public void PurchaseOutdoor()
    {

        if (Money.instance.money < 4500)
        {

            return;

        }

        GameObject purchase;
        purchase = Instantiate(outdoorNew, outdoor);
        Money.instance.money -= 4500;

    }

    public void PurchaseIndoor()
    {

        GameObject purchase;
        purchase = Instantiate(indoorNew, indoor);

    }

}
