using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellLose : MonoBehaviour {

    [SerializeField]
    private GameObject loseText;

    public static bool youLose;

    // Use this for initialization
    void Start()
    {
        loseText.SetActive(false);
        youLose = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
        youLose = true;
        loseText.SetActive(true);
    }
}
