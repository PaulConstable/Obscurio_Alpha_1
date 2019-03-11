using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyPadClick : MonoBehaviour
{

    [SerializeField] public string correctCode = "7845";
    [SerializeField] public GameObject[] buttons;
  
    public static string playerCode = "";

    public static int buttonsPressed = 0;

    [SerializeField] private Text KeypadCode;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerCode);
        KeypadCode.text = "Code: " + playerCode;
        if (buttonsPressed == 4)
        {
            if (playerCode == correctCode)
            {
                Debug.Log("Correct");
          
            }

            else
            {

                Debug.Log("Wrong");
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

    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
    }
}
