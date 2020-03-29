using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninja : MonoBehaviour
{

    public GameObject steam;
    public GameObject gameManager;
    public Sprite m_Sprite;

    // Start is called before the first frame update
    void Start()
    {
        gameManager.GetComponent<GameManager>().pass = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<SpriteRenderer>().sprite = m_Sprite;
        }   
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "steam")
        {
            if(this.GetComponent<SpriteRenderer>().sprite != m_Sprite){
                gameManager.GetComponent<GameManager>().pass = false;
            }
            
        }
    }
}
