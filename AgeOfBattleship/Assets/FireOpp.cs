using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class FireOpp : MonoBehaviour
{
    public Text hth;
    public Material changeMat;
    public Text questionText;
    public Button button1;
    public Button button2;
    public Text buttontext1;
    public Text buttontext2;
    public Text Result;
    public GameObject place;
    public GameObject SE;
    public GameObject QuestionsPrefab;
    //public Button opp;
    static System.Random rnd = new System.Random();
    int randomNum; // = rnd.Next(0, 6); //to choose number between 1 and 5
    private Material initMat;
    public static int turn = 1;
    Transform t;
    int pow;

    public Text score;
    int scoreCount = 0;

    float timer = 0f;
    
    Renderer rend;
    bool enter = false;
    int flag1 = 0; //for opp
    int flag2 = 0; //for user


    /*public GameObject FireM;
    public GameObject MoveM;*/

    int count = 0; //number of user ships destroyed

    List<string> qlist = new List<string>(new string[] { "Which country made the first declaration of war?",
        "In what city was Archduke Franz Ferdinand assassinated?",
        "At the beginning of World War I, Bosnia-Herzegovina was part of?",
        "Germany’s attack upon which country directly provoked Britain to go to war?",
        "Which Russian general lost the Battle of the Masurian Lakes?"});



    void Start()
    {
        score.text = "Score : "+scoreCount;
        /*button1 = GameObject.FindWithTag("Buuton1").GetComponent<Button>();
        buttontext1 = button1.GetComponentInChildren<Text>();
        button2 = GameObject.FindWithTag("Buuton2").GetComponent<Button>();
        buttontext2 = button2.GetComponentInChildren<Text>();
        questionText = GameObject.FindWithTag("QText").GetComponent<Text>();
        SE = GameObject.FindWithTag("se");
        place = GameObject.FindWithTag("Place");
        QuestionsPrefab = GameObject.FindWithTag("QPrefab");
        Result = GameObject.FindWithTag("result").GetComponent<Text>();*/
       // QuestionsPrefab.SetActive(false);

        rend = GetComponent<Renderer>();
        //place.gameObject.SetActive(false);

        initMat = rend.material;
        t = this.transform;
        button1.onClick.AddListener(Buttonfunc1);
        button2.onClick.AddListener(Buttonfunc2);
        //opp.onClick.AddListener(opponent);
        

    }
    private void Update()
    {
        timer += Time.deltaTime;

    }

    public void Buttonfunc1(){
        Result.gameObject.SetActive(true);
        if (randomNum == 1)
        {
            if (buttontext1.text == "Hungary"){
                Result.text = "Correct";
                EditorUtility.DisplayDialog("Congratulations!", "You chose the correct answer.", "Yay");
                scoreCount += 10;
                score.text = "Score : " + scoreCount;
                opponent();
            }
            else{
                Result.text = "InCorrect";
                EditorUtility.DisplayDialog("Oh no!", "You chose the wrong answer.", "Okay");
                opponent();
            }
            randomNum = 0;
        }
        else if (randomNum == 2)
        {
            if (buttontext1.text == "Sarajevoa")
            {
                Result.text = "Correct";
                EditorUtility.DisplayDialog("Congratulations!", "You chose the correct answer.", "Yay");
                scoreCount += 10;
                score.text = "Score : " + scoreCount;
                opponent();
            }
            else{
                Result.text = "InCorrect";
                EditorUtility.DisplayDialog("Oh no!", "You chose the wrong answer.", "Okay");
                opponent();
            }
            randomNum = 0;
        }
        else if (randomNum == 3)
        {
            if (buttontext1.text == "Hungary")
            {
                Result.text = "Correct";
                EditorUtility.DisplayDialog("Congratulations!", "You chose the correct answer.", "Yay");
                scoreCount += 10;
                score.text = "Score : " + scoreCount;
                opponent();
            }
            else{
                Result.text = "InCorrect";
                EditorUtility.DisplayDialog("Oh no!", "You chose the wrong answer.", "Okay");
                opponent();
            }
            randomNum = 0;
        }
        else if (randomNum == 4)
        {
            if (buttontext1.text == "Belgium")
            {
                Result.text = "Correct";
                EditorUtility.DisplayDialog("Congratulations!", "You chose the correct answer.", "Yay");
                scoreCount += 10;
                score.text = "Score : " + scoreCount;
                opponent();
            }
            else{
                Result.text = "InCorrect";
                EditorUtility.DisplayDialog("Oh no!", "You chose the wrong answer.", "Okay");
                opponent();
            }
            randomNum = 0;
        }
        else if (randomNum == 5)
        {
            if (buttontext1.text == "Rennenkempf")
            {
                Result.text = "Correct";
                EditorUtility.DisplayDialog("Congratulations!", "You chose the correct answer.", "Yay");
                scoreCount += 10;
                score.text = "Score : " + scoreCount;
                opponent();
            }
            else{
                Result.text = "InCorrect";
                EditorUtility.DisplayDialog("Oh no!", "You chose the wrong answer.", "Okay");
                opponent();
            }
            randomNum = 0;
        }
       /*if (SE != null)
            SE.gameObject.SetActive(true);
        if (place != null)
            place.gameObject.SetActive(true);*/

        QuestionsPrefab.gameObject.SetActive(false);
       //opponent();
    }
    public void Buttonfunc2()
    {
        if (randomNum == 1)
        {
            if (buttontext2.text == "Hungary")
            {
                Result.text = "Correct";
                EditorUtility.DisplayDialog("Congratulations!", "You chose the correct answer.", "Yay");
                scoreCount += 10;
                score.text = "Score : " + scoreCount;
                opponent();
            }
            else
            {
                Result.text = "InCorrect";
                EditorUtility.DisplayDialog("Oh no!", "You chose the wrong answer.", "Okay");
                opponent();
            }
            randomNum = 0;
        }
        else if (randomNum == 2)
        {
            if (buttontext2.text == "Sarajevoa")
            {
                Result.text = "Correct";
                EditorUtility.DisplayDialog("Congratulations!", "You chose the correct answer.", "Yay");
                scoreCount += 10;
                score.text = "Score : " + scoreCount;
                opponent();
            }
            else
            {
                Result.text = "InCorrect";
                EditorUtility.DisplayDialog("Oh no!", "You chose the wrong answer.", "Okay");
                opponent();
            }
            randomNum = 0;
        }
        else if (randomNum == 3)
        {
            if (buttontext2.text == "Hungary")
            {
                Result.text = "Correct";
                EditorUtility.DisplayDialog("Congratulations!", "You chose the correct answer.", "Yay");
                scoreCount += 10;
                score.text = "Score : " + scoreCount;
                opponent();
            }
            else
            {
                Result.text = "InCorrect";
                EditorUtility.DisplayDialog("Oh no!", "You chose the wrong answer.", "Okay");
                opponent();
            }
            randomNum = 0;
        }
        else if (randomNum == 4)
        {
            if (buttontext2.text == "Belgium")
            {
                Result.text = "Correct";
                EditorUtility.DisplayDialog("Congratulations!", "You chose the correct answer.", "Yay");
                scoreCount += 10;
                score.text = "Score : " + scoreCount;
                opponent();
            }
            else
            {
                Result.text = "InCorrect";
                EditorUtility.DisplayDialog("Oh no!", "You chose the wrong answer.", "Okay");
                opponent();
            }
            randomNum = 0;
        }
        else if (randomNum == 5)
        {
            if (buttontext2.text == "Rennenkempf")
            {
                Result.text = "Correct";
                EditorUtility.DisplayDialog("Congratulations!", "You chose the correct answer.", "Yay");
                scoreCount += 10;
                score.text = "Score : " + scoreCount;
                opponent();
            }
            else
            {
                Result.text = "InCorrect";
                EditorUtility.DisplayDialog("Oh no!", "You chose the wrong answer.", "Okay");
                opponent();

            }
            randomNum = 0;
        }
        /*if (SE != null)
            SE.gameObject.SetActive(true);
        if (place != null)
            place.gameObject.SetActive(true);*/

        QuestionsPrefab.gameObject.SetActive(false);
        //opponent();
    }


    private void OnMouseEnter()
    {
        //if (turn == 1)
        //{
            enter = true;
            rend.material = changeMat;
        //}

    }

    private void OnMouseExit()
    {
        //if (turn == 1)
        //{
            enter = false;
            rend.material = initMat;
        //}
    }

    void checkWinner()
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                if (autoP.AutoGrid[i][j] != 0)
                {
                    flag1 = 1;
                    break;
                }
            }
            if (flag1 == 1)
                break;

        }
        if (flag1 == 0)
        {
            EditorUtility.DisplayDialog("WINNER", "You destroyed all of opponent's ships!", "OK");
        }
        flag1 = 0;
    }

    private void OnMouseDown()
    {
        Debug.Log("inmouse down");
        if (SE != null)
            SE.gameObject.SetActive(false);
        if (place != null)
            place.gameObject.SetActive(false);


        randomNum = rnd.Next(0, 6);
        Debug.Log("Random: " + randomNum);
        if (randomNum == 1)
        {
            questionText.text = "Which country made the first declaration of war?";
            buttontext1.text = "Hungary";
            buttontext2.text = "Russia";
        }
        else if (randomNum == 2)
        {
            questionText.text = "In what city was Archduke Franz Ferdinand assassinated?";
            buttontext1.text = "Vienna";
            buttontext2.text = "Sarajevo";
        }
        else if (randomNum == 3)
        {
            questionText.text = "At the beginning of World War I, Bosnia-Herzegovina was part of?";
            buttontext1.text = "Hungary";
            buttontext2.text = "Croatia";
        }
        else if (randomNum == 4)
        {
            questionText.text = "Germany’s attack upon which country directly provoked Britain to go to war?";
            buttontext1.text = "Holland";
            buttontext2.text = "Belgium";
        }
        else if (randomNum == 5)
        {
            questionText.text = "Which Russian general lost the Battle of the Masurian Lakes?";
            buttontext1.text = "Rennenkempf";
            buttontext2.text = "Kornilov";
        }

        //------
        Debug.Log("heerreeee");
        pow = move.health[0] + move.health[1] + move.health[2] + move.health[3];
        hth.text = "Health : " + pow.ToString();
        if (turn == 1)
        {
            
            if (autoP.AutoGrid[Mathf.RoundToInt(t.localPosition.z)][Mathf.RoundToInt(t.localPosition.x)] == 0)
            {
                //string question = qlist[0];

                //if (SE != null)
                    //SE.gameObject.SetActive(false);
                //if(place != null)
                    //place.gameObject.SetActive(false);


                EditorUtility.DisplayDialog("FIRE", "You hit at a wrong spot.\n" , "Okay");
                /*place.gameObject.SetActive(false);
                SE.gameObject.SetActive(false);
                QuestionsPrefab.gameObject.SetActive(true);*/
                opponent();
            }
            else
            {
                //string question = qlist[0];
                autoP.AutoGrid[Mathf.RoundToInt(t.localPosition.z)][Mathf.RoundToInt(t.localPosition.x)]--;

                //EditorUtility.DisplayDialog("FIRE", "You hit at a correct spot", "Answer Question");
                QuestionsPrefab.gameObject.SetActive(true);
                //opponent();
            }
            Debug.Log("checkwineer k andr");
            checkWinner();
            Debug.Log("checkwinner k bhr");
            //turn = 0;
        }

        //Byee byeee ishuuuu! :D 




        //---------
        //opponent();

    }

    public void opponent(){
        int r = Random.Range(0, 12);
        int c = Random.Range(0, 12);
        int s;
        int foundShip = 0;
        for (s = 0; s < 4; s++)
        {
            if (Mathf.RoundToInt(move.arr[s].transform.localPosition.z) == r && Mathf.RoundToInt(move.arr[s].transform.localPosition.x) == c)
            {
                foundShip = 1;
                break;
            }
        }
        if (foundShip == 1)
        {
            EditorUtility.DisplayDialog("FIRE", "The opponent hit your ship", "OK");
            if (move.health[s] == 0)
            {
                Destroy(move.arr[s]);

            }
            else
                move.health[s]--;
        }
        else
            EditorUtility.DisplayDialog("FIRE", "The opponent missed", "OK");

        pow = move.health[0] + move.health[1] + move.health[2] + move.health[3];
        hth.text = "Health : " + pow.ToString();

        for (int k = 0; k < 4; k++)
        {
            if (move.health[k] == 0)
            {
                count++;
            }
        }
        if (count == 4)
        {
            EditorUtility.DisplayDialog("LOSER", "Opponent destroyed all your ships!", "OK");
        }

        Debug.Log("opponent done!");
        ModeCheck.FM.SetActive(false);
        ModeCheck.MM.SetActive(true);

        turn = 1;
    }

}
