using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour {

    public InputField inputField;

    public Text answer;

    public string input;

	// Use this for initialization
	void Start () {
        answer.text = "";
		
	}
	
	public void GetInput()
    {
        input = inputField.text;
    }

    public void Calculate()
    {
        answer.text = input;
    }
}
