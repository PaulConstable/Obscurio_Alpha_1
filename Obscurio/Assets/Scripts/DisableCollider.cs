using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCollider : MonoBehaviour {

    [SerializeField] Collider2D Collider;
    [SerializeField] GameObject Collider2;
    private bool Hide = false;
    // Use this for initialization
    void Start () {
        Collider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Hide == true)
        {

           


        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Destroy(Collider2);
        Collider.enabled = false;
    }

}
