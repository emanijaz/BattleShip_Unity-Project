using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resumeGame : MonoBehaviour {

    public move resumeLocation;
    public Button resumeGameBtn;

	// Use this for initialization
	void Start () {
        resumeGameBtn.onClick.AddListener(resume);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void resume()
    {
        for (int i = 0; i < resumeLocation.arr1.Length; i++)
        {
            Vector3 temp = resumeLocation.arr1[i].transform.position;
            temp.x = PlayerPrefs.GetFloat("shipx" + i.ToString());
            temp.y = PlayerPrefs.GetFloat("shipy" + i.ToString());
            temp.z = PlayerPrefs.GetFloat("shipz" + i.ToString());
            resumeLocation.arr1[i].transform.position = temp;
            /*resumeLocation.arr1[i].transform.position.x = PlayerPrefs.GetFloat("shipx" + i.ToString());
            resumeLocation.arr1[i].transform.position.y = PlayerPrefs.GetFloat("shipy" + i.ToString());
            resumeLocation.arr1[i].transform.position.z = PlayerPrefs.GetFloat("shipz" + i.ToString());*/
        }
        Debug.Log("Game Resumed");
    }
}
