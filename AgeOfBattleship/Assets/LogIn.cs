using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using UnityEngine.UI;

public class LogIn : MonoBehaviour {
	public InputField uName;
	public InputField Pass;
	public Button logIn;
	public Button register;
	public Image Success;
	public Image Fail;
	//public GameObject WW1;
    public GameObject lvl;
    public GameObject login;
	MySqlConnection connection;
    //public GameObject canvas;

	// Use this for initialization
	void Start () {
		
		string database_connection = "server = localhost;" + "uid = root;" + "pwd =;" + "database = Battleship;";
		try{
			
			connection = new MySqlConnection (database_connection);

			Debug.Log("Successful");
		}
		catch(Exception error){
			Debug.Log ("error");
		}
		logIn.onClick.AddListener (Login);
		register.onClick.AddListener (Register);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Login()
	{
		connection.Open();
		string query = "SELECT * FROM User WHERE Name = '"+uName.text+"' AND Password = '"+Pass.text+"'";
		//Debug.Log (query);

		// This is your data adapter that understands SQL databases:
		MySqlCommand cmd = new MySqlCommand(query, connection);

		// This is your table to hold the result set:
		MySqlDataReader dataReader = cmd.ExecuteReader();

		if (dataReader.HasRows) {
			Fail.gameObject.SetActive (false);
			Debug.Log ("Logged In");
			Success.gameObject.SetActive (true);
            /*StartScreen.gameObject.SetActive (false);
			se.gameObject.SetActive (true);
			moveMode.gameObject.SetActive (true);
			fireMode.gameObject.SetActive (true);
			hth.gameObject.SetActive (true);
			PlaceShip.gameObject.SetActive (true);*/
            //WW1.gameObject.SetActive(true);
            lvl.gameObject.SetActive(true);
            login.gameObject.SetActive(false);
            //canvas.gameObject.SetActive(false);
        }
		else 
		{
			Debug.Log ("Not Logged In");
			Fail.gameObject.SetActive (true);
		}
		connection.Close ();
	}

	void Register()
	{
		connection.Open();
        Debug.Log("register");
		string query = "INSERT INTO `User` (`Name`, `Password`) VALUES ('"+uName.text+"', '"+Pass.text+"')";
		MySqlCommand cmd = new MySqlCommand(query, connection);
		MySqlDataReader dataReader = cmd.ExecuteReader();
		Success.gameObject.SetActive(true);
        /*StartScreen.gameObject.SetActive (false);
		se.gameObject.SetActive (true);
		moveMode.gameObject.SetActive (true);
		fireMode.gameObject.SetActive (true);
		hth.gameObject.SetActive (true);
		PlaceShip.gameObject.SetActive (true);*/
        //WW1.gameObject.SetActive(true);
        lvl.gameObject.SetActive(true);
        login.gameObject.SetActive(false);
        //canvas.gameObject.SetActive(false);
        connection.Close();

	}
}
