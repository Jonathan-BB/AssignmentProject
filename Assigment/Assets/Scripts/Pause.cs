using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    
    public bool paused;
    void Start () { 
    paused = false;
        
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0)) {
            paused = !paused;
        }
        if (paused) {  
            Time.timeScale = 0;

        }
        
        else if (!paused) {
            Time.timeScale = 1;
        }

    }
}
