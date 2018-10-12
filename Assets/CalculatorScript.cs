using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour {

    public InputField inputField;

    public Text answer;

    public string input;

    char[] parsing;

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
        parsing = input.ToCharArray();

        //List<string> datalist = new List<string>();
        //datalist.AddRange(input.Select(c => c.ToString()));

        List<char> datalist = new List<char>();
        datalist.AddRange(input);



        answer.text = datalist[2].ToString();
        //answer.text = datalist.Count.ToString();
        //answer.text = ParseAndCalc(parsing);
    }

    public string ParseAndCalc(List<string> toParse)
    {
        List<char> result = new List<char>();


        int i = 0;
        while (char.IsDigit(toParse[i]))
        {
            result.Add(toParse[i]);
            i++;
        }



        return "Start - "+result.ToString()+"Con";
    }

    public static bool IsCharDigit(char c)
    {
        return ((c >= '0') && (c <= '9'));
    }
}
