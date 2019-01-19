using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resume : MonoBehaviour {

    public move saveLocation;
    public Button resumeBtn;

	// Use this for initialization
	void Start () {
        resumeBtn.onClick.AddListener(save);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void save()
    {
        for (int i = 0; i < saveLocation.arr1.Length; i++)
        {
            float x, y, z;
            x = saveLocation.arr1[i].transform.position.x;
            y = saveLocation.arr1[i].transform.position.y;
            z = saveLocation.arr1[i].transform.position.z;
            PlayerPrefs.SetFloat("shipx" + i.ToString(),x);
            PlayerPrefs.SetFloat("shipy" + i.ToString(), y);
            PlayerPrefs.SetFloat("shipz" + i.ToString(), z);
        }
        Debug.Log(" Positions Saved ");

    }
}
