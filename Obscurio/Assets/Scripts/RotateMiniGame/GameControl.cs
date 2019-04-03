using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour {

    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    [SerializeField] public GameObject Outroscene;
    public bool isOutroScene;
    [SerializeField] public GameObject[] medals;
    

    public static bool youWin;

    BeanStalkTrigger myBeanStalkTrigger;
    BeanGuyTrigger myBeanGuyTrigger;
    PuzzleGame myPuzzleGame;

    public GameObject goldMedObject;
    public AudioSource goldMedAudio;

    public GameObject silverMedObject;
    public AudioSource silverMedAudio;

    public GameObject bronzeMedObject;
    public AudioSource bronzeMedAudio;

    MedalManager myMedalManager;

    // Use this for initialization
    void Start () {
        winText.SetActive(false);
        youWin = false;
        myBeanStalkTrigger = FindObjectOfType<BeanStalkTrigger>();
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();
        myPuzzleGame = FindObjectOfType<PuzzleGame>();

        bronzeMedAudio = bronzeMedObject.GetComponent<AudioSource>();
        silverMedAudio = silverMedObject.GetComponent<AudioSource>();
        goldMedAudio = goldMedObject.GetComponent<AudioSource>();

        myMedalManager = FindObjectOfType<MedalManager>();

    }


    // Update is called once per frame
    private void Update()
    {
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0 &&
            pictures[6].rotation.z == 0 &&
            pictures[7].rotation.z == 0 &&
            pictures[8].rotation.z == 0 &&
            pictures[9].rotation.z == 0 &&
            pictures[10].rotation.z == 0 &&
            pictures[11].rotation.z == 0 &&
            pictures[12].rotation.z == 0 &&
            pictures[13].rotation.z == 0 &&
            pictures[14].rotation.z == 0 &&
            pictures[15].rotation.z == 0 )
        {
            Outroscene.SetActive(true);
            isOutroScene = true;
            if(myPuzzleGame.timeTaken < 40)
            {
                goldMedAudio.Play();
                medals[2].SetActive(true);
                myMedalManager.SetSquareGold();
                
            }
            if(myPuzzleGame.timeTaken > 40 && myPuzzleGame.timeTaken < 70)
            {
                silverMedAudio.Play();
                medals[1].SetActive(true);
                myMedalManager.SetSquareSilver();
                
            }
            if(myPuzzleGame.timeTaken >= 70)
            {
                bronzeMedAudio.Play();
                medals[0].SetActive(true);
                myMedalManager.SetSquareBronze();
                
            }
            
        } 

            
        if(isOutroScene == true && Input.GetKeyDown(KeyCode.E))
        {
            youWin = true;
            winText.SetActive(true);
            myBeanStalkTrigger.SetBeanState3();

            myBeanGuyTrigger.Potions();
            SceneManager.UnloadSceneAsync("Puzzle-Game");
        }
                
                
                
    } 
}

