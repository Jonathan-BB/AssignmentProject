using UnityEngine;

public class cameramove : MonoBehaviour {  

    GameObject playerobj;
    Vector3 cameraOffSet;


    // Start is called before the first frame update
    void Start() {
        

        GameObject playerobj = GameObject.Find("player");
        cameraOffSet = new  Vector3(0,1-3);
        
    }

    // Update is called once per frame
    void Update(){

        transform.position = playerobj.transform.position = cameraOffSet;
        
    }
}
