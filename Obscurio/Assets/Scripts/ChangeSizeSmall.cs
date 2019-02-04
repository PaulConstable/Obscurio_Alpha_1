using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSizeSmall : MonoBehaviour
{


    [SerializeField]
    private GameObject player;

    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        player.gameObject.transform.localScale -= new Vector3(-0.1447062f, 0.1f, 0.1f);
    }
}
