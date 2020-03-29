using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steam : MonoBehaviour
{

    public GameObject gameManager;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        int level = gameManager.GetComponent<GameManager>().level();
        speed = 4; 
        if(level==2) {
            speed = 8;
    	} else if(level==3) {
            speed = 10;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    
}
