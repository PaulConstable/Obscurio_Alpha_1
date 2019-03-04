using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    private void Start()
    {
        var randomInt = Random.Range(0, 4);

        if (randomInt == 0)
        {
            transform.Rotate(0f, 0f, 90f);
        }

        else if (randomInt == 1)
        {
            transform.Rotate(0f, 0f, 180f);
        }

        else if (randomInt == 2)
        {
            transform.Rotate(0f, 0f, 270f);
        }

        else
        {
            transform.Rotate(0f, 0f, 0f);
        }

        Debug.Log(randomInt);
    }
}