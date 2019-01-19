using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play : MonoBehaviour {

   
    public GameObject PlaceShip;

    public Button playBtn;
    public Text pause;

	// Use this for initialization
	void Start () {
        playBtn.onClick.AddListener(playfunc);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void playfunc()
    {
       // se.gameObject.SetActive(true);
        pause.gameObject.SetActive(false);
        PlaceShip.gameObject.SetActive(true);
       // Questions.gameObject.SetActive(true);
    }
}
