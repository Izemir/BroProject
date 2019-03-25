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
        answer.color = new Color(0, 0, 0);

        List<char> datalist = new List<char>();
        datalist.AddRange(input);

        Tester test = new Tester();

        Parser parser = new Parser();

        Calculator calculator = new Calculator();

        test.startTest(datalist);

        if (test.hasErrors())
        {
            answer.text = test.getMessage();
            answer.color = new Color(255, 0, 0);
        }
        else
        {
            parser.parse(datalist);

            List<object> parsedData = parser.getParsedList();

            calculator.calculate(parsedData);

            if (calculator.hasErrors())
            {
                answer.text = calculator.getMessage();
                answer.color = new Color(255, 0, 0);
            }
            else
            {

                answer.text = calculator.getResult();
                
            }


        }
    
    }

    

    
}
