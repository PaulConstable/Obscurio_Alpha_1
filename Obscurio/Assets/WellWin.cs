using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WellWin : MonoBehaviour
{
    [SerializeField]
    private GameObject winText;

    BeanGuyTrigger myBeanGuyTrigger;

    public static bool youWin;

    // Use this for initialization
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        youWin = true;
        winText.SetActive(true);
        myBeanGuyTrigger.CanSpeechBubbleRemoved();
        SceneManager.UnloadSceneAsync("Well-Jump_Game");
        
 


    }
}
