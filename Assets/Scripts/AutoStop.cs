using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoStop : MonoBehaviour
{

    public float timer = 3;

    private void Update()
    {

        timer -= Time.deltaTime;

        if (timer < 0)
        {

            gameObject.SetActive(false);

        }

    }

}
