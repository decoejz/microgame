using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class croissant : MonoBehaviour
{

    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        int level = gameManager.GetComponent<GameManager>().level();
        if (level==1) {
            gameObject.transform.position = new Vector3(1.79f,-4f,0.0f);
        } else if(level==2) {
    		gameObject.transform.position = new Vector3(2.29f,-4f,0.0f);
    	} else if(level==3) {
    		gameObject.transform.position = new Vector3(2.79f,-4f,0.0f);
    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
