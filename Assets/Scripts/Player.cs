using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.02f;
    public GameObject croissant;
    public GameObject gameManager;

    private bool inicio = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inicio){
            inicio = false;
            gameManager.GetComponent<GameManager>().pass = false;
        }
        float dh = Input.GetAxis("Horizontal");
        if ((gameObject.transform.position.x > -5.3 || dh > 0) &&
            (gameObject.transform.position.x < 2.444118 || dh < 0))
        {
            gameObject.transform.position += Vector3.right * dh * speed;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Croissant")
        {
            gameManager.GetComponent<GameManager>().pass = true;
            Destroy(other.gameObject);
        }
    }
}
