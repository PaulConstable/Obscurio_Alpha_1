using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadClick : MonoBehaviour
{

    [SerializeField] public  string correctCode = "7845";
    public static string playerCode = "";

    public static int buttonsPressed = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerCode);

        if (buttonsPressed == 4)
        {
            if (playerCode == correctCode)
            {
                Debug.Log("Correct");
            }

            else
            {

                buttonsPressed = 0;
                playerCode = "";
            }
        }
    }


    void OnMouseUp()
    {
        if (buttonsPressed < 4)
        {
            playerCode += gameObject.name;
            buttonsPressed += 1;
        }
        if (gameObject.name == "Reset")
        {
            playerCode = "";
            buttonsPressed = 0;
        }
    }
}
