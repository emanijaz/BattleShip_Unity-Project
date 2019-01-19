using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour {
	public Button WW1, WW2;
    public GameObject ww1Ships;
    public GameObject ww2Ships;
    //public static GameObject SEGame1;
    public GameObject game1;
    //public static GameObject SEGame2;
    public GameObject game2;



    // Use this for initialization
    void Start () {
        //SEGame1 = game1;
        //SEGame1 = game1;
        Button ww1 = WW1.GetComponent<Button> ();
		Button ww2 = WW2.GetComponent<Button> ();
        //.onClick.AddListener (delegate{changeScene("ww1_selectShips");});
        //ww2.onClick.AddListener (delegate{changeScene("ww2_selectShips");});
        ww1.onClick.AddListener(chooseww1Ships);
        ww2.onClick.AddListener(chooseww2Ships);
        ww1Ships.gameObject.SetActive(false);
        ww2Ships.gameObject.SetActive(false);
        game1.SetActive(false);
        game2.SetActive(false);


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void chooseww1Ships()
    {
        ww1Ships.SetActive(true);
        this.gameObject.SetActive(false);

    }

    public void chooseww2Ships()
    {
        ww2Ships.SetActive(true);
        this.gameObject.SetActive(false);

    }

    public void changeScene(string scene_name)
	{
	//	Application.LoadLevel(scene_name);
	//	Debug.Log("sceneName to load: " + scene_name);
		SceneManager.LoadScene(scene_name);
	}
}
