using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WellWin : MonoBehaviour
{
    [SerializeField]
    private GameObject winText;

    BeanGuyTrigger myBeanGuyTrigger;
    BeanStalkTrigger myBeanStalkTrigger;
    WellGameTrigger myWellGameTrigger;


    [SerializeField] public GameObject outro;
    [SerializeField] public GameObject[] medals;
    public bool introActive;

    public static bool youWin;
    public float time = 0f;

    public GameObject goldMedObject;
    public AudioSource goldMedAudio;

    public GameObject silverMedObject;
    public AudioSource silverMedAudio;

    public GameObject bronzeMedObject;
    public AudioSource bronzeMedAudio;

    public bool medalwon;

    MedalManager myMedalManager;

    // Use this for initialization
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();
        myBeanStalkTrigger = FindObjectOfType<BeanStalkTrigger>();
        myWellGameTrigger = FindObjectOfType<WellGameTrigger>();

        bronzeMedAudio = bronzeMedObject.GetComponent<AudioSource>();
        silverMedAudio = silverMedObject.GetComponent<AudioSource>();
        goldMedAudio = goldMedObject.GetComponent<AudioSource>();

        myMedalManager = FindObjectOfType<MedalManager>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(introActive == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.UnloadSceneAsync("Well-Jump_Game");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        youWin = true;
        winText.SetActive(true);
        myBeanGuyTrigger.CanSpeechBubbleRemoved();
        myBeanGuyTrigger.DisplayCan();
        myBeanGuyTrigger.returnState();
        myBeanStalkTrigger.SetBeanState2();
        myWellGameTrigger.RemoveButton();
        introActive = true;

        outro.SetActive(true);
        if(time <= 15 && medalwon == false)
        {
            medals[2].SetActive(true);
            goldMedAudio.Play();
            medalwon = true;
            myMedalManager.SetWellGold();
        }
        if(time <=30 && medalwon == false)
        {
            medals[1].SetActive(true);
            silverMedAudio.Play();
            medalwon = true;
            myMedalManager.SetWellSilver();
        }
        if(time > 30 && medalwon == false)
        {
            medals[0].SetActive(true);
            bronzeMedAudio.Play();
            medalwon = true;
            myMedalManager.SetWellBronze();
        }

        
        
 


    }
}
