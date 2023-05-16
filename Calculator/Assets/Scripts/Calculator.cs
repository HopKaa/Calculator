using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField Value_1;
    public InputField Value_2;
    public InputField Result;

    public void Clickplus ()
    {
        
        float num1 = float.Parse(Value_1.text);
        float num2 = float.Parse(Value_2.text);
       
        float result = 0;

        //if ( Value_1.text == "")
        //{
        //    Result.text = "Value_1 не заполнено";
        //}
        //else if (Value_2.text == "")
        //{
        //   Result.text = "Value_2 не заполнено";
        //}
        //else
        //{
        //    result = num1 + num2;
        //    Result.text = "Result: " + result.ToString();
        //}
        result = num1 + num2;
        Result.text = "Result: " + result.ToString();

    }
    public void Clickminus()
    {

        float num1 = float.Parse(Value_1.text);
        float num2 = float.Parse(Value_2.text);

        float result = 0;
        result = num1 - num2;

        Result.text = "Result: " + result.ToString();

    }

    public void Clickmulti()
    {

        float num1 = float.Parse(Value_1.text);
        float num2 = float.Parse(Value_2.text);

        float result = 0;
        result = num1 * num2;

        Result.text = "Result: " + result.ToString();

    }

    public void Clickdivisi()
    {

        float num1 = float.Parse(Value_1.text);
        float num2 = float.Parse(Value_2.text);

        float result = 0;
        result = num1 / num2;
        if (num2 > 0)
        {
            result = num1 / num2;
            Result.text = "Result: " + result.ToString();
        }
        else
        {
            Result.text = "ƒеление на 0 невозможно";
        }
        

    }

    public void ClickMin()
    {

        float num1 = float.Parse(Value_1.text);
        float num2 = float.Parse(Value_2.text);

        float result = 0;
        result = Mathf.Min(num1, num2);

        Result.text = "Result: " + result.ToString();

    }

    public void ClickMax()
    {

        float num1 = float.Parse(Value_1.text);
        float num2 = float.Parse(Value_2.text);

        float result = 0;
        result = Mathf.Max(num1, num2);
      
        Result.text = "Result: " + result.ToString();

    }

    public void ClickDegree()
    {

        float num1 = float.Parse(Value_1.text);
        float num2 = float.Parse(Value_2.text);

        float result = 0;
        result = Mathf.Pow(num1, num2);

        Result.text = "Result: " + result.ToString();

    }
}
