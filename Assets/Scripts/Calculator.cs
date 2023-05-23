using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    [SerializeField] private Text _text;


    private float _value1;
    private float _value2;
    private string _operation;


    public void ClickNumber(int value)
    {
        Debug.Log($" check value: {value}");
        _text.text += $"{value}";
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
        _text.text += $"{value}";
    }

    public void ClickEqual(string value)
    {
        Debug.Log($" ClickEqual value: {value}");
        if (!string.IsNullOrEmpty(_operation))
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
                    if (_value2 != 0)
                    {
                        ShowResult(_value1 / _value2);
                    }

                    if (_value2 == 0)
                    {
                        _text.text = "Деление на 0 невозможно";
                    }
                    break;

                case "log2":
                    ShowResult(Mathf.Log(_value1));
                    break;
                case "log10":
                    ShowResult(Mathf.Log10(_value1));
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
                case "cot":
                    if (Mathf.Tan(_value1) != 0)
                    {
                        ShowResult(1 / Mathf.Tan(_value1));
                    }

                    if (Mathf.Tan(_value1) == 0)
                    {
                        ShowResult(0);
                    }
                    ShowResult(1 / Mathf.Tan(_value1));
                    break;
                case "sin":
                    ShowResult(Mathf.Sin(_value1));
                    break;
                case "pi":
                    ShowResult(Mathf.PI);
                    break;
                case "izi":
                    string result = "";
                    for (; _value1 % 2 == 0; _text.text += $"{result}")
                    {
                        _value1 = _value1 / 2;
                        ShowResultIzi(2);
                    }

                    for (; _value1 % 3 == 0; _text.text += $"{result}")
                    {
                        _value1 = _value1 / 3;
                        ShowResultIzi(3);
                    }

                    for (; _value1 % 5 == 0; _text.text += $"{result}")
                    {
                        _value1 = _value1 / 5;
                        ShowResultIzi(5);
                    }

                    for (; _value1 % 7 == 0; _text.text += $"{result}")
                    {
                        _value1 = _value1 / 7;
                        ShowResultIzi(7);
                    }

                    for (; _value1 % 11 == 0; _text.text += $"{result}")
                    {
                        _value1 = _value1 / 11;
                        ShowResultIzi(11);
                    }
                    break;
                default:
                    break;
            }
        }
    }

    public void ClickClear()
    {
        _text.text = "";
    }

    private void ShowResult(float result)
    {
        _text.text = "Result: " + result.ToString();
    }
    private void ShowResultIzi(float result)
    {
        _text.text += $"{result}";
    }
}