using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    [SerializeField] private Text _text;


    private float _valueCurrent;
    private float _valuePrevios;
    private char _lastOperation;

    public void ClickNumber(int value)
    {
        Debug.Log($" check value: {value}");
        _text.text += $"{value}";
        _valueCurrent = _valueCurrent * 10 + value;
    }
    private Dictionary<char, Func<float, float, float>> _operations;

    private void Awake()
    {
        _operations = new Dictionary<char, Func<float, float, float>>()
        {
            { '+', (a, b) => a + b },
            { '-', (a, b) => a - b },
            { '*', (a, b) => a * b },
            { '/', (a, b) => a / b },
            { '^', Mathf.Pow },
        };
    }
    public void ClickPlus()
    {
        ClickEqual();
        _lastOperation = '+';
        UpdateText("+");
    }
    
    public void ClickMinus()
    {
        ClickEqual();
        _lastOperation = '-';
        UpdateText("-");
    }

    public void ClickMultiplication()
    {
        ClickEqual();
        _lastOperation = '*';
        UpdateText("*");
    }

    public void ClickDivisin()
    {
        if (_valueCurrent == 0)
        {
            ClickEqual();
            _lastOperation = '/';
        }
        else
        {
            _text.text = "division by 0 is not possible";
        }
        UpdateText("/");
    }

    public void ClickDegree()
    {
        ClickEqual();
        _lastOperation = '^';
        UpdateText("^");
    }

    public void ClickLog2()
    {
        ClickEqual();
        float result = Mathf.Log(_valueCurrent);
        ShowResult(result);
        _valuePrevios = result;
        _valueCurrent = 0;
    }

    public void ClickLog10()
    {
        ClickEqual();
        float result = Mathf.Log10(_valueCurrent);
        ShowResult(result);
        _valuePrevios = result;
        _valueCurrent = 0;
    }

    public void ClickMinimum()
    {
        ClickEqual();
        float result = Mathf.Min(_valuePrevios, _valueCurrent);
        ShowResult(result);
        _valuePrevios = result;
        _valueCurrent = 0;
    }

    public void ClickMaximum()
    {
        ClickEqual();
        float result = Mathf.Max(_valuePrevios, _valueCurrent);
        ShowResult(result);
        _valuePrevios = result;
        _valueCurrent = 0;
    }

    public void ClickCot()
    {
        ClickEqual();
        float result = 1f / Mathf.Tan(_valueCurrent);
        ShowResult(result);
        _valuePrevios = result;
        _valueCurrent = 0;
    }

    public void ClickSin()
    {
        ClickEqual();
        float result = Mathf.Sin(_valueCurrent);
        ShowResult(result);
        _valuePrevios = result;
        _valueCurrent = 0;
    }

    public void ClickPI()
    {
        ClickEqual();
        ShowResult(Mathf.PI);
        _valuePrevios = Mathf.PI;
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

    public void ClickEqual()
    {

        if (_lastOperation != '\0')
        {
            if (_operations.TryGetValue(_lastOperation, out Func<float, float, float> operation))
            {
                float result = operation(_valuePrevios, _valueCurrent);
                ShowResult(result);
                _lastOperation = '\0';
            }
            else
            {
                Debug.LogError($"Unknown operation: {_lastOperation}");
            }
        }
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
        _valuePrevios = result;
        _valueCurrent = 0;
    }
}
