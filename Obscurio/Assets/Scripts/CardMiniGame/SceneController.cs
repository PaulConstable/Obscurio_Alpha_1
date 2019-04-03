using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public const int gridRows = 3;
    public const int gridCols = 4;
    public const float offsetX = 2f;
    public const float offsetY = 3f;

    [SerializeField] private MainCard originalCard;
    [SerializeField] private Sprite[] images;
    [SerializeField] public GameObject IntroText;
    [SerializeField] public GameObject IntroMedals;
    [SerializeField] public GameObject[] medals;

    WitchTrigger mywitchTrigger;
    public int noOfClicks;

    public GameObject flipObject;
    public AudioSource flipAudio;

    public GameObject goldMedObject;
    public AudioSource goldMedAudio;

    public GameObject silverMedObject;
    public AudioSource silverMedAudio;

    public GameObject bronzeMedObject;
    public AudioSource bronzeMedAudio;

    private void Start()
    {
        mywitchTrigger = FindObjectOfType<WitchTrigger>();
        flipAudio = flipObject.GetComponent<AudioSource>();

        bronzeMedAudio = bronzeMedObject.GetComponent<AudioSource>();
        silverMedAudio = silverMedObject.GetComponent<AudioSource>();
        goldMedAudio = goldMedObject.GetComponent<AudioSource>();

        Vector3 startPos = originalCard.transform.position;

        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        numbers = ShuffleArray(numbers);

        for (int i =0; i < gridCols; i++)
        {
            for(int j =0; j < gridRows; j++)
            {
                MainCard card;
                if (i==0 && j==0)
                {
                    card = originalCard;
                }
                else
                {
                    card = Instantiate(originalCard) as MainCard;
                }

                int index = j * gridCols + i;
                int id = numbers[index];
                card.ChangeSprite(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = (offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }


    }

    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for(int i =0; i<newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    //-------------------------------------------------

    private MainCard _firstRevealed;
    private MainCard _secondRevealed;

    private int _score = 0;
    //[SerializeField] private TextMesh scoreLabel;

    public bool canReveal
    {
        get { return _secondRevealed == null; }
    }

    public void CardRevealed(MainCard card)
    {
        if (_firstRevealed == null)
        {
            _firstRevealed = card;
            flipAudio.Play();
        }
        else
        {
            _secondRevealed = card;
            StartCoroutine(CheckMatch());
            noOfClicks++;
            flipAudio.Play();
            Debug.Log(noOfClicks);
        }
    }

    private IEnumerator CheckMatch()
    {
        if (_firstRevealed.id == _secondRevealed.id)
        {
            _score++;
            //scoreLabel.text = "Score: " + _score;
            if(_score == 6)
            {
                
                
                IntroText.SetActive(false);
                IntroMedals.SetActive(false);
                if(noOfClicks <=10)
                {
                    medals[0].SetActive(true);
                    goldMedAudio.Play();
                }
                if(noOfClicks <=15 && noOfClicks > 10)
                {
                    medals[1].SetActive(true);
                    silverMedAudio.Play();
                }
                if(noOfClicks > 15)
                {
                    medals[2].SetActive(true);
                    bronzeMedAudio.Play();
                }
                
            }
        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            _firstRevealed.Unreveal();
            _secondRevealed.Unreveal();
        }

        _firstRevealed = null;
        _secondRevealed = null;

    }

    public void Update()
    {
        if(_score == 6 && Input.GetKeyDown(KeyCode.E))
        {
            mywitchTrigger.CompleteCardGame();
            SceneManager.UnloadSceneAsync("CardGame2");
        }
    }


}
