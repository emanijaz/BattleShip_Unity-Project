using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class controlTutorial : MonoBehaviour {
    public VideoPlayer vp;
    public Button tutorial;
    public GameObject lvls;
    public GameObject videoCan;
    // Use this for initialization
    void Start () {
        tutorial.onClick.AddListener(playTutorial);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void playTutorial()
    {
        Debug.Log("play");
        lvls.SetActive(true);
        videoCan.SetActive(false);
        vp.Stop();
    }
}
