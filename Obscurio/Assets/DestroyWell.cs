using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWell : MonoBehaviour
{

    public GameObject player;
    public GameObject platformPrefab;
    public GameObject platformPrefab2;
    public GameObject platformPrefab3;
    private GameObject myPlat;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
        Destroy(collision.gameObject);
    }

}
