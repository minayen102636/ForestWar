using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
	public GameObject Cat;
	float time = 0f;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreatCat",1,1);
    }

    public void CreatCat(){
    	int CatNum;
    	CatNum = Random.Range(0,2);

    	if(time > 1f){
    	for (int i = 0; i < CatNum; i++){
    		float x;
    		float z;
    		x = Random.Range(-20, 20);
    		z = Random.Range(-20, 20);
    		Instantiate(Cat, new Vector3(x, 8, z), Quaternion.identity );
    	}
    	time = 0f;
   		 }

    }


    // Update is called once per frame
    void Update()
    {
    	
        time += Time.deltaTime;
  
    }
}
