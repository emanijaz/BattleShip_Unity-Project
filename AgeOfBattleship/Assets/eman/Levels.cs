using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class Levels : MonoBehaviour {

	public Button easy, medium, hard;
	public GameObject ww1;
    public GameObject ww2;
    public GameObject lvls;
    public GameObject videoCan;

    public static int level;

    public GameObject panel;

    //public GameObject ww2;
    //public GameObject lvls;
    //public GameObject canvas;
    // Use this for initialization
    public VideoPlayer vp;
    public VideoClip vid;
    public Button tutorial;

    int press = 0;

    void Start () {

        //canvas.SetActive(false);
		Button easy_button = easy.GetComponent<Button> ();
		Button med_button = medium.GetComponent<Button> ();
		Button hard_button = hard.GetComponent<Button> ();
		easy_button.onClick.AddListener(func1);
		med_button.onClick.AddListener(func2);
		hard_button.onClick.AddListener(func3);
        tutorial.onClick.AddListener(playTutorial);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
	public void func1()  // take to scene where user choose between wwI or wwII
	{
        level = 1;
        ww1.SetActive(true);
        ww2.SetActive(true);
        lvls.gameObject.SetActive(false);
        //Debug.Log("go to ships");
	}
    public void func2()  // take to scene where user choose between wwI or wwII
    {
        level = 2;
        ww1.SetActive(true);
        ww2.SetActive(true);
        lvls.gameObject.SetActive(false);
        //Debug.Log("go to ships");
    }
    public void func3()  // take to scene where user choose between wwI or wwII
    {
        level = 3;
        ww1.SetActive(true);
        ww2.SetActive(true);
        lvls.gameObject.SetActive(false);
        //Debug.Log("go to ships");
    }

    void playTutorial()
    {
        Debug.Log("play");
      
            panel.SetActive(false);
            videoCan.SetActive(true);
            vp.Play();

    }
}
