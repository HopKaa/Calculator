using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    /*[SerializeField] private InputField _inputField1;
    [SerializeField] private InputField _inputField2;
    [SerializeField] private InputField _result;*/


    //[SerializeField] private InputField _inputField;
    [SerializeField] private Text _Text;


    private float _value1;
    private float _value2;
    private string _operation;


    public void ClickNumber(int value)
    {
        Debug.Log($" check value: {value}");
        _Text.text += $"{value}";
        if (_value1 == 0)
        {
            _value1 += value;
        }
        else
        {
            _value2 += value;
        }    
    }
    public void ClickOperation(string value)
    {
        Debug.Log($" ClickOperation value: {value}");
        _operation += value;
        _Text.text += $"{value}";
    }

    public void ClickEqual(string value)
    {
        Debug.Log($" ClickEqual value: {value}");
        if (_value1 != 0 && _value2 != 0 && string.IsNullOrEmpty(_operation))
        {
            switch (_operation)
            {
                case "+":
                    ShowResult(_value1 + _value2);
                    break;
                case "-":
                    ShowResult(_value1 - _value2);
                    break;
                case "*":
                    ShowResult(_value1 * _value2);
                    break;
                case "/":
                    ShowResult(_value1 / _value2);
                    break;
                case "min":
                    ShowResult(Mathf.Min(_value1, _value2));
                    break;
                case "max":
                    ShowResult(Mathf.Max(_value1, _value2));
                    break;
                case "^":
                    ShowResult(Mathf.Pow(_value1, _value2));
                    break;
            }
        }
    }


    private void ShowResult(float result)
    {
        _Text.text = "Result: " + result.ToString();
    }
}