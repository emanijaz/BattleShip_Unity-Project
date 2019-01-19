using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select_ship : MonoBehaviour {

	public Button btn1, btn2, btn3, btn4, btn5, Select;
	public int click_btn1 = 0;
	public int click_btn2 = 0;
	public int click_btn3 = 0;
	public int click_btn4 = 0;
	public int click_btn5 = 0;
	public Text msg;
	//public GameObject SEGame;
	public GameObject current;
    public GameObject startingScene;
    public GameObject game;

    public int ships_count=0;
	// Use this for initialization
	void Start () {
		Button b1 = btn1.GetComponent<Button> ();
		Button b2 = btn2.GetComponent<Button> ();
		Button b3 = btn3.GetComponent<Button> ();
		Button b4 = btn4.GetComponent<Button> ();
		Button b5 = btn5.GetComponent<Button> ();
		Button d = Select.GetComponent<Button> ();

		msg.text = "";

		b1.onClick.AddListener (onClickButton1);
		b2.onClick.AddListener (onClickButton2);
		b3.onClick.AddListener (onClickButton3);
		b4.onClick.AddListener (onClickButton4);
		b5.onClick.AddListener (onClickButton5);
		d.onClick.AddListener (onClickButtonSelect);
        startingScene.gameObject.SetActive(false);


    }
	

	public void onClickButtonSelect(){
		

		if (ships_count < 3) { // error
	
			msg.text= "MUST SELECT MORE THAN THREE SHIPS!";
			click_btn1 = 0;
			click_btn2 = 0;
			click_btn3 = 0;
			click_btn4 = 0;
			click_btn5 = 0;

			current.gameObject.SetActive (true);
		} 
		else 
		{
	
			msg.text = " SHIPS SELECTED!";
			Debug.Log ("prefab is active true");
			Debug.Log ("current is active false");
            game.gameObject.SetActive (true);
			current.gameObject.SetActive (false);

		}


	
	}
	public void onClickButton1(){
		

		msg.text = "";
		if (click_btn1 == 0) {
			click_btn1 = 1;
			ships_count += 1;  // select button
			btn1.GetComponent<Image> ().color = Color.blue;
		}
		else {
			click_btn1 = 0;
			ships_count -= 1; // deselect button 
			btn1.GetComponent<Image> ().color = Color.white;
		}


	}
	public void onClickButton2(){
		
		msg.text = "";
		if (click_btn2 == 0) {
			click_btn2 = 1;
			ships_count += 1;
			btn2.GetComponent<Image> ().color = Color.blue;
		}
		else {
			click_btn2 = 0;
			ships_count -= 1;
			btn2.GetComponent<Image> ().color = Color.white;
		}
	}
	public void onClickButton3(){
		
		msg.text = "";
		if (click_btn3 == 0) {
			click_btn3 = 1;
			ships_count += 1;
			btn3.GetComponent<Image> ().color = Color.blue;
		}
		else {
			click_btn3 = 0;
			ships_count -= 1;
			btn3.GetComponent<Image> ().color = Color.white;
		}
	}
	public void onClickButton4(){
		
		msg.text = "";
		if (click_btn4 == 0) {
			click_btn4 = 1;
			ships_count += 1;
			btn4.GetComponent<Image> ().color = Color.blue;
		}
		else {
			click_btn4 = 0;
			ships_count -= 1;
			btn4.GetComponent<Image> ().color = Color.white;
		}
	}
	public void onClickButton5(){

		msg.text = "";
		if (click_btn5 == 0) {
			click_btn5 = 1;
			ships_count += 1;
			btn5.GetComponent<Image> ().color = Color.blue;
		}
		else {
			click_btn5 = 0;
			ships_count -= 1;
			btn5.GetComponent<Image> ().color = Color.white;
		}
	}
}

