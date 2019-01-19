using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class move : MonoBehaviour {

	public KeyCode ship;
	public KeyCode button;
	public KeyCode Right;
	public KeyCode Left;
	public KeyCode Down;
	public KeyCode Up;

	public static GameObject []arr;
    public static int[] health;

    public GameObject[] arr1;
    public  int[] health1;

    int i;
	float speed = 1.0f;


	void Start()
	{
		i = -1;
        arr = arr1;
        health = health1;
	}
		

	void Update(){
		
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out hit))
		{
			if (Input.GetKeyDown (ship)) 
			{
				i = i + 1;
				if (i >= 5)
					i = 0;
			}

			if (Input.GetKeyDown(button))
			{
				//Debug.Log (i);
				//s.position = hit.point;
				arr1[i].transform.position = hit.point;
                arr = arr1;

            }
			if (Input.GetKeyDown (Right)) 
			{
				arr1[i].transform.position -= Vector3.right * speed * Time.deltaTime;
                arr = arr1;
            }
			if (Input.GetKeyDown (Left)) 
			{
				arr1[i].transform.position -= Vector3.left * speed * Time.deltaTime;
                arr = arr1;
            }
			if (Input.GetKeyDown (Up)) 
			{
				arr1[i].transform.position += Vector3.up * speed * Time.deltaTime;
                arr = arr1;
            }
			if (Input.GetKeyDown (Down)) 
			{
				arr1[i].transform.position += Vector3.down * speed * Time.deltaTime;
                arr = arr1;
            }
		}
	}
}
