using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField _inputField1;
    [SerializeField] private InputField _inputField2;
    [SerializeField] private InputField _result;


    private float _value1;
    private float _value2;


    public void ClickPlus()
    {
        if (!TryParseValues())
        {
            return;
        }

        ShowResult(_value1 + _value2);
    }
    public void ClickMinus()
    {
        if (!TryParseValues())
        {
            return;
        }

        ShowResult(_value1 - _value2);
    }

    public void ClickMultiplication()
    {
        if (!TryParseValues())
        {
            return;
        }

        ShowResult(_value1 * _value2);
    }

    public void ClickDivisi()
    {
        if (!TryParseValues())
        {
            return;
        }

        if (_value2 == 0)
        {
            _result.text = "ƒеление на 0 невозможно";
            return;
        }

        ShowResult(_value1 / _value2);
    }

    public void ClickMinimum()
    {
        if (!TryParseValues())
        {
            return;
        }

        ShowResult(Mathf.Min(_value1, _value2));
    }

    public void ClickMaximum()
    {
        if (!TryParseValues())
        {
            return;
        }

        ShowResult(Mathf.Max(_value1, _value2));
    }

    public void ClickDegree()
    {
        if (!TryParseValues())
        {
            return;
        }

        ShowResult(Mathf.Pow(_value1, _value2));
    }

    private bool TryParseValues()
    {
        if (_inputField1.text == "")
        {
            _result.text = "Value1 не заполнено";
            return false;
        }

        if (_inputField2.text == "")
        {
            _result.text = "Value2 не заполнено";
            return false;
        }

        _value1 = float.Parse(_inputField1.text);
        _value2 = float.Parse(_inputField2.text);

        return true;
    }

    private void ShowResult(float result)
    {
        _result.text = "Result: " + result.ToString();
    }
}