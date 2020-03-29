// Timer para MicroProjeto do Curso de Jogos Digitais
// Referência: https://www.youtube.com/watch?v=bcvLM_riVuw

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

	Image timeBar;
	public float maxTime = 5.0f;
	float timeLeft;
	public GameObject timesUpText;

    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);
        timeBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft>0) {
        	timeLeft -= Time.deltaTime;
        	timeBar.fillAmount = timeLeft / maxTime;
        } else {
        	timesUpText.SetActive(true);
        }
    }
}
