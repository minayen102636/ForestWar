using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour {
    public float speed = 100f;

    // Use this for initialization
    void Start () {
            Destroy(gameObject, 3.0f);
        
    }
    
    // Update is called once per frame
    void Update () {
        this.transform.Translate(new Vector3( 0, 0, speed));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            GameObject.Find("GameManager").GetComponent<gameManager>().addScore(100);
        }
    }
    
}


