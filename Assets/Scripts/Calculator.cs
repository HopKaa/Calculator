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
        _text.text += $"{value}";
    }

    public void ClickPlus()
    {
        ShowResult(_value1 + _value2);
        UpdateText("+");
    }

    public void ClickMinus()
    {
        ShowResult(_value1 - _value2);
        UpdateText("-");
    }

    public void ClickMultiplication()
    {
        ShowResult(_value1 * _value2);
        UpdateText("*");
    }

    public void ClickDivisin()
    {
        if (_value2 != 0)
        {
            ShowResult(_value1 / _value2);
        }

        if (_value2 == 0)
        {
            _text.text = "division by 0 is not possible";
        }
        UpdateText("/");
    }

    public void ClickDegree()
    {
        ShowResult(Mathf.Pow(_value1, _value2));
        UpdateText("^");
    }

    public void ClickLog2()
    {
        ShowResult(Mathf.Log(_value1));
        UpdateText("log2");
    }

    public void ClickLog10()
    {
        ShowResult(Mathf.Log10(_value1));
        UpdateText("log10");
    }

    public void ClickMinimum()
    {
        ShowResult(Mathf.Min(_value1, _value2));
        UpdateText("min");
    }

    public void ClickMaximum()
    {
        ShowResult(Mathf.Max(_value1, _value2));
        UpdateText("max");
    }

    public void ClickCot()
    {
        if (Mathf.Tan(_value1) != 0)
        {
            ShowResult(1 / Mathf.Tan(_value1));
        }

        if (Mathf.Tan(_value1) == 0)
        {
            ShowResult(0);
        }
        ShowResult(1 / Mathf.Tan(_value1));
        UpdateText("cot");
    }

    public void ClickSin()
    {
        ShowResult(Mathf.Sin(_value1));
        UpdateText("sin");
    }

    public void ClickPI()
    {
        ShowResult(Mathf.PI);
        UpdateText("");
    }
    public void OnCalculateClick()
    {
        int n = int.Parse(_text.text);
        string result = "Prime factors of a number " + n + ": ";

        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                result += i + " ";
                n /= i;
            }
        }

        _text.text = result;
    }
    public void ClickEqual(string operation)
    {
       _text.text += $"{operation}"; 
    }

    public void ClickClear()
    {
        _text.text = "";
    }
    private void UpdateText(string operation)
    {
        _text.text += $"{operation}";
    }
    private void ShowResult(float result)
    {
        _text.text = result.ToString();
    }

   
}