using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour {

    public GameObject se;
    public GameObject PlaceShip;
    public GameObject Questions;
    public Button pauseBtn;
    public Text pausetext;
    

	// Use this for initialization
	void Start () {
        pausetext.gameObject.SetActive(false);
        pauseBtn.onClick.AddListener(pauseFunc);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void pauseFunc()
    {
       // se.gameObject.SetActive(false);
        pausetext.gameObject.SetActive(true);
        PlaceShip.gameObject.SetActive(false);
       // Questions.gameObject.SetActive(false);
    }
}

