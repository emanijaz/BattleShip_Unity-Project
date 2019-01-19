using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuScript {


    [MenuItem("Tools/Assign Question Text")]

    public static void AssignTileMaterial()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        GameObject se = Resources.Load<GameObject>("SE");

        foreach (GameObject t in tiles)
        {
            t.GetComponent<FireOpp>().SE = se;
        }
    }
}
