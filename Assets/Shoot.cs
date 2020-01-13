using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject BulletPrefab;
    float time = 0f;
    public float destroyTime = 3f;
    public AudioClip ShotSound;
    AudioSource audiosource;
    // Use this for initialization
    void Start () {
        audiosource = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update () {
        time += Time.deltaTime;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if(time > 0.5f){
                Instantiate(BulletPrefab, this.transform.position, this.transform.rotation);
                time = 0;
                audiosource.PlayOneShot(ShotSound,2f);
            }

        }
    }
}


