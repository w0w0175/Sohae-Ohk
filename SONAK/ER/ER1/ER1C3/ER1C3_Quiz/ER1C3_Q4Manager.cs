using UnityEngine;
using UnityEngine.UI;

public class ER1C3_Q4Manager : MonoBehaviour
{
    public static ER1C3_Q4Manager Instance;

    public Text Changenum;

    static int Num1 = 0;
    static int Num2 = 0;
    static int Num3 = 0;
    static int Num4 = 0;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        ResetGame();
    }
    public void ResetGame()
    {
        Num1 = 0;
        Num2 = 0;
        Num3 = 0;
        Num4 = 0;

        Changenum.text = "0";
    }
    public void ClickNum1()
    {
        switch (Num1)
        {
            case 0:
                Num1 += 1;
                Changenum.text = Num1.ToString();
                break;
            case 1:
                Num1 += 1;
                Changenum.text = Num1.ToString();
                break;
            case 2:
                Num1 += 1;
                Changenum.text = Num1.ToString();
                break;
            case 3:
                Num1 += 1;
                Changenum.text = Num1.ToString();
                break;
            case 4:
                Num1 += 1;
                Changenum.text = Num1.ToString();
                break;
            case 5:
                Num1 += 1;
                Changenum.text = Num1.ToString();
                break;
            case 6:
                Num1 += 1;
                Changenum.text = Num1.ToString();
                break;
            case 7:
                Num1 += 1;
                Changenum.text = Num1.ToString();
                break;
            case 8:
                Num1 += 1;
                Changenum.text = Num1.ToString();
                break;
            case 9:
                Num1 = 0;
                Changenum.text = Num1.ToString();
                break;
        }
    }
    public void ClickNum2()
    {
        switch (Num2)
        {
            case 0:
                Num2 += 1;
                Changenum.text = Num2.ToString();
                break;
            case 1:
                Num2 += 1;
                Changenum.text = Num2.ToString();
                break;
            case 2:
                Num2 += 1;
                Changenum.text = Num2.ToString();
                break;
            case 3:
                Num2 += 1;
                Changenum.text = Num2.ToString();
                break;
            case 4:
                Num2 += 1;
                Changenum.text = Num2.ToString();
                break;
            case 5:
                Num2 += 1;
                Changenum.text = Num2.ToString();
                break;
            case 6:
                Num2 += 1;
                Changenum.text = Num2.ToString();
                break;
            case 7:
                Num2 += 1;
                Changenum.text = Num2.ToString();
                break;
            case 8:
                Num2 += 1;
                Changenum.text = Num2.ToString();
                break;
            case 9:
                Num2 = 0;
                Changenum.text = Num2.ToString();
                break;
        }
    }
    public void ClickNum3()
    {
        switch (Num3)
        {
            case 0:
                Num3 += 1;
                Changenum.text = Num3.ToString();
                break;
            case 1:
                Num3 += 1;
                Changenum.text = Num3.ToString();
                break;
            case 2:
                Num3 += 1;
                Changenum.text = Num3.ToString();
                break;
            case 3:
                Num3 += 1;
                Changenum.text = Num3.ToString();
                break;
            case 4:
                Num3 += 1;
                Changenum.text = Num3.ToString();
                break;
            case 5:
                Num3 += 1;
                Changenum.text = Num3.ToString();
                break;
            case 6:
                Num3 += 1;
                Changenum.text = Num3.ToString();
                break;
            case 7:
                Num3 += 1;
                Changenum.text = Num3.ToString();
                break;
            case 8:
                Num3 += 1;
                Changenum.text = Num3.ToString();
                break;
            case 9:
                Num3 = 0;
                Changenum.text = Num3.ToString();
                break;
        }
    }
    public void ClickNum4()
    {
        switch (Num4)
        {
            case 0:
                Num4 += 1;
                Changenum.text = Num4.ToString();
                break;
            case 1:
                Num4 += 1;
                Changenum.text = Num4.ToString();
                break;
            case 2:
                Num4 += 1;
                Changenum.text = Num4.ToString();
                break;
            case 3:
                Num4 += 1;
                Changenum.text = Num4.ToString();
                break;
            case 4:
                Num4 += 1;
                Changenum.text = Num4.ToString();
                break;
            case 5:
                Num4 += 1;
                Changenum.text = Num4.ToString();
                break;
            case 6:
                Num4 += 1;
                Changenum.text = Num4.ToString();
                break;
            case 7:
                Num4 += 1;
                Changenum.text = Num4.ToString();
                break;
            case 8:
                Num4 += 1;
                Changenum.text = Num4.ToString();
                break;
            case 9:
                Num4 = 0;
                Changenum.text = Num4.ToString();
                break;
        }
    }
}
