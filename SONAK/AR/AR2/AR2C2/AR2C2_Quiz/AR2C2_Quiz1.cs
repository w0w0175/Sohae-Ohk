using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AR2C2_Quiz1 : MonoBehaviour
{
    public Text Changenum;

    int Num = 0;
    void OnEnable()
    {
        Num = 0;
        Changenum.text = "0";
    }
    public void ClickNums()
    {
        if (gameObject.name == "AR2C2_1_1")
        {
            switch (Num)
            {
                case 0:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 1:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 2:
                    Num  = 0;
                    Changenum.text = Num.ToString();
                    break;
            }
        }
        else if (gameObject.name == "AR2C2_1_3")
        {
            switch (Num)
            {
                case 0:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 1:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 2:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 3:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 4:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 5:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 6:
                    Num =0;
                    Changenum.text = Num.ToString();
                    break;
            }
        }
        else
        {
            switch (Num)
            {
                case 0:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 1:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 2:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 3:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 4:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 5:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 6:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 7:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 8:
                    Num += 1;
                    Changenum.text = Num.ToString();
                    break;
                case 9:
                    Num = 0;
                    Changenum.text = Num.ToString();
                    break;
            }
        }
    }
}
