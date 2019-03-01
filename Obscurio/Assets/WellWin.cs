using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WellWin : MonoBehaviour
{
    [SerializeField]
    private GameObject winText;

    public static bool youWin;

    // Use this for initialization
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        youWin = true;
        winText.SetActive(true);
        SceneManager.UnloadSceneAsync("Well-Jump_Game");
 


    }
}
