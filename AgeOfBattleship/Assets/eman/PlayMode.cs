using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayMode : MonoBehaviour {

	// Use this for initialization

	public Button go_to_playmode;
	public GameObject obj;

	void Start () {

		Button Playmode =go_to_playmode.GetComponent<Button> ();
		Playmode.onClick.AddListener(changeScene);
	}

	// Update is called once per frame
	void Update () {

	}
	public void changeScene()
	{
		Debug.Log ("in play mode chnage scene");;
		obj.SetActive(true);

	}
}
