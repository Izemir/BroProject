using Assets;
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
        List<char> datalist = new List<char>();
        datalist.AddRange(input);

        Tester test = new Tester();

        Parser parser = new Parser();

        Calculator calculator = new Calculator();

        test.startTest(datalist);

        if (test.hasErrors())
        {
            answer.text = test.getMessage();           
        }
        else
        {
            parser.parse(datalist);

            List<object> parsedData = parser.getParsedList();

            calculator.calculate(parsedData);

            if (calculator.hasErrors())
            {
                answer.text = calculator.getMessage();
                
            }
            else
            {

                answer.text = calculator.getResult();
                
            }


        }
    
    }

    public string ParseAndCalc(char[] toParse)
    {
        List<char> result = new List<char>();

        
        int i = 0;
        while (char.IsDigit(toParse[i]))
        {
            result.Add(toParse[i]);
            i++;
        }
        


        return "Start - "+result.ToString()+"-Con";
    }

    public static bool IsCharDigit(char c)
    {
        return ((c >= '0') && (c <= '9'));
    }
}
