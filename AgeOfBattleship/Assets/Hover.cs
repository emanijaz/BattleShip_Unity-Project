using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {


	public Text mytext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerEnter (PointerEventData eventData)
	{
		mytext.text = "Fire";

	}
	public void OnPointerExit (PointerEventData eventData)
	{
		mytext.text = "";
	}


}
