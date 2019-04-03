using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class KeyPadClick : MonoBehaviour
{

    [SerializeField] public string correctCode = "835";
    [SerializeField] public GameObject[] buttons;
  
    public static string playerCode = "";

    public static int buttonsPressed = 0;

    LoadingInsideHouse myloadinginsidehouse;

    public GameObject clickObject;
    public AudioSource clickAudio;

    public GameObject wrongObject;
    public AudioSource wrongAudio;


    [SerializeField] private Text KeypadCode;
    // Use this for initialization
    void Start()
    {
        myloadinginsidehouse = FindObjectOfType<LoadingInsideHouse>();

        clickAudio = clickObject.GetComponent<AudioSource>();
        wrongAudio = wrongObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        

        Debug.Log(playerCode);
        KeypadCode.text = "Code: " + playerCode;
        if (buttonsPressed == 3)
        {
            if (playerCode == correctCode)
            {
                Debug.Log("Correct");
                SceneManager.LoadScene("InsideHAG");
          
            }

            else
            {

                Debug.Log("Wrong");
                buttonsPressed = 0;
                playerCode = "";
                wrongAudio.Play();
      

            }
        }
    }

    

    void OnMouseUp()
    {
        if (buttonsPressed < 3)
        {
            playerCode += gameObject.name;
            buttonsPressed += 1;
            clickAudio.Play();
        }
        if (gameObject.name == "Reset")
        {
            playerCode = "";
            buttonsPressed = 0;
            clickAudio.Play();
        }
        if(gameObject.name == "Leave")
        {
            myloadinginsidehouse.LeftKeypad();
            SceneManager.UnloadSceneAsync("KeypadGame");
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
