using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess; // declarations only
	int maxGuessesAllowed = 10;
	
//public variable of type text with a capital T
//command single quote to search automatically
	public Text text;

	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	
	void StartGame () {
	//declare and initialize
		max = 1000;
		min = 1;
		NextGuess();
	
	
	}
	
	//inserting here to avoid closing brackets
	public void GuessHigher(){
		min = guess;
		NextGuess ();
	
	}	
	
	public void GuessLower(){
		max = guess;
		NextGuess ();
	
	}
	
	void NextGuess () {
		guess = Random.Range (min, max+1);//needs to know to be 1 more than we potentially want
		//attribute of text type
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed -1;
		if(maxGuessesAllowed <= 0){
			Application.LoadLevel ("Win");
		}
	}	
	
	// Update is called once per frame
	//void Update () {} bye because empty
	
}
