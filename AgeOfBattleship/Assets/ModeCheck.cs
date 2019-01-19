using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.Video;

public class ModeCheck : MonoBehaviour {

    public Button mov;
    public Button fire;
    public GameObject FireM;
    public GameObject MoveM;
    public Button hint;
    public Text hintNum;

    public static GameObject FM;
    public static GameObject MM;
    public GameObject QuestionsPrefab;

    int i;
    public Material hintMat;



   

    // Use this for initialization
    void Start () {

        FireM.SetActive(false);
        MoveM.SetActive(true);
        QuestionsPrefab.SetActive(false);
        FM = FireM;
        MM = MoveM;
        mov.onClick.AddListener(MoveMode);
        fire.onClick.AddListener(FireMode);
        hint.onClick.AddListener(getHint);


        //vid = vp.clip;

        if (Levels.level == 1)
        {
            i = 3;
            hintNum.text="3";
        }
        else if (Levels.level == 2)
        {
            i = 2;
            hintNum.text = "2";
        }
        else if (Levels.level == 3)
        {
            i = 1;
            hintNum.text = "1";
        }
    }

    void MoveMode()
    {
        //OnHide(FireM);
        //OnShow(MoveM);
        //FireM.GetComponent<MeshRenderer>().enabled = false;
        //MoveM.GetComponent<MeshRenderer>().enabled = true;
        FireM.SetActive(false);
        MoveM.SetActive(true);
        FM = FireM;
        MM = MoveM;
        QuestionsPrefab.SetActive(false);
    }

    void FireMode()
    {
        //OnHide(MoveM);
        //OnShow(FireM);
        //FireM.GetComponent<MeshRenderer>().enabled = true;
        //MoveM.GetComponent<MeshRenderer>().enabled = false;
        FireM.SetActive(true);
        MoveM.SetActive(false);
        FM = FireM;
        MM = MoveM;
    }

    void getHint()
    {

        Debug.Log("Hinteedd!!");
        if (i > 0)
        {
            GameObject h = FireM.transform.GetChild(autoP.hintRow[i]).GetChild(autoP.hintCol[i]).gameObject;
            h.GetComponent<Renderer>().material = hintMat;
            hintNum.text = "" + (i-1);

        }
        else{
            EditorUtility.DisplayDialog("NO MORE HINTS!", "You have used all your hints\n", "Okay");
        }
        i--;

    }


}
