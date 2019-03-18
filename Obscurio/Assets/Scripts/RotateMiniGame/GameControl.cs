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

	// Use this for initialization
	void Start () {
        winText.SetActive(false);
        youWin = false;
        myBeanStalkTrigger = FindObjectOfType<BeanStalkTrigger>();
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();
        myPuzzleGame = FindObjectOfType<PuzzleGame>();
        
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
                medals[2].SetActive(true);
            }
            if(myPuzzleGame.timeTaken < 70)
            {
                medals[1].SetActive(true);
            }
            if(myPuzzleGame.timeTaken >= 70)
            {
                medals[0].SetActive(true);
            }
            
        } 

            
        if(isOutroScene == true && Input.GetMouseButtonDown(0))
        {
            youWin = true;
            winText.SetActive(true);
            myBeanStalkTrigger.SetBeanState3();

            myBeanGuyTrigger.Potions();
            SceneManager.UnloadSceneAsync("Puzzle-Game");
        }
                
                
                
    } 
}

