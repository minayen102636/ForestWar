using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
	int time_int = 30;
    public Text time_UI;
    // Start is called before the first frame update
    void Start()
    {
    	InvokeRepeating("timer", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void timer(){
    	time_int -= 1;
    	time_UI.text = time_int + "";
    	if(time_int == 0){
    		time_UI.text = "Game\nOver";
    		CancelInvoke("timer");
            Time.timeScale = 0f;
    	}
    }
}
