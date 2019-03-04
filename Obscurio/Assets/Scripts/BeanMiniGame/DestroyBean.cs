using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBean : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D bean)
    {
        if (bean.gameObject.tag == "Black")
        {
            Destroy(bean.gameObject);
        }

        else if (bean.gameObject.tag == "Red")
        {
            Destroy(bean.gameObject);
        }

        else if (bean.gameObject.tag == "Gold")
        {
            Destroy(bean.gameObject);
        }
    }
}
