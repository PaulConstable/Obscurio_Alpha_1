using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingLightGame : MonoBehaviour
{
    public bool lightgameCompleted;
    public bool lightGameLoaded;
    [SerializeField] public GameObject EButton;
    [SerializeField] public GameObject overlay;
    [SerializeField] public GameObject blocker;

    public void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" && lightgameCompleted == false)
        {
            EButton.SetActive(true);
        }

        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && lightgameCompleted == false && lightGameLoaded == false)
        {
            SceneManager.LoadScene("Light-Game", LoadSceneMode.Additive);
            lightGameLoaded = true;


        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && lightgameCompleted == false)
        {
            EButton.SetActive(false);
        }
    }

    public void CompleteGame()
    {
        SceneManager.UnloadSceneAsync("Light-Game");
        overlay.SetActive(false);
        EButton.SetActive(false);
        lightgameCompleted = true;
        blocker.SetActive(false);
    }


}
