using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Fire : MonoBehaviour {

    public Material changeMat;
    private Material initMat;
    Transform t;
    //public Material notWater;
    // Use this for initialization
    Renderer rend;
    bool enter = false;


    void Start () {
        rend = GetComponent<Renderer>();
        initMat = rend.material;
        t = this.transform;

	}

    private void OnMouseEnter()
    {
         enter = true;
         rend.material = changeMat;
        
    }

    private void OnMouseExit()
    {
        enter = false;
        rend.material = initMat;
    }

    //private void OnMouseDown()
    //{
    //    if(autoP.AutoGrid[Mathf.RoundToInt(t.localPosition.x)][Mathf.RoundToInt(t.localPosition.z)]==1)
    //    {

    //    }
    //    else
    //    {
    //        EditorUtility.DisplayDialog("FIRE","You hit at a wrong spot","OK");
    //    }
    //}
}
