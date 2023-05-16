using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField InputField1;
    public InputField InputField2;
    public InputField Result;

    private float _value1;
    private float _value2;

    private bool TryParseValues()
    {
        if (InputField1.text == "")
        {
            Result.text = "Value1 не заполнено";
            return false;
        }
        else if (InputField2.text == "")
        {
            Result.text = "Value2 не заполнено";
            return false;
        }

        _value1 = float.Parse(InputField1.text);
        _value2 = float.Parse(InputField2.text);

        return true;
    }
    public void ClickPlus ()
    {
        if(!TryParseValues())
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
        else if (_value2 > 0)
        {
            ShowResult(_value1 / _value2);
        }
        else
        {
            Result.text = "ƒеление на 0 невозможно";
        }
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
     private void ShowResult(float result)
    {
        Result.text = "Result: " + result.ToString();
    }
}