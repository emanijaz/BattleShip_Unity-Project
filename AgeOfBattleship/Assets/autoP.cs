using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoP : MonoBehaviour {

    // Use this for initialization
    public static int[] hintRow=new int[5];
    public static int[] hintCol=new int[5];
    public static int[][] AutoGrid;
	void Start() {

        AutoGrid =GenerateGrid();
	}


    int[][] GenerateGrid()
    {
        int r; int c; int health;
        int[][] arr = new int[12][];
        for (int i = 0; i < 12; i++)
            arr[i] = new int[12];
        for (int i = 0; i < 12; i++)
            for (int j = 0; j < 12; j++)
                arr[i][j] = 0;
        for (int m = 0; m < 5; m++)
        {
            r = Random.Range(0, 12);
            c = Random.Range(0, 12);
            health = Random.Range(1, 5);
            arr[r][c] = health;
            hintRow[m] = r;
            hintCol[m] = c;
            Debug.Log("row " + r);
            Debug.Log("col " + c);
            Debug.Log(arr[r][c]);
        }
        return arr;
    }
}
