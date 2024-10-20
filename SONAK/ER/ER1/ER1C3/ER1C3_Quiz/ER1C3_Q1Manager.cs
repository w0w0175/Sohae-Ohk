using UnityEngine;
using UnityEngine.UI;

public class ER1C3_Q1Manager : MonoBehaviour
{
    public static ER1C3_Q1Manager Instance;
    
    public Text text_1;

    static int Q1_1 = 0;
    static int Q1_2 = 0;
    static int Q1_3 = 0;
    static int Q1_4 = 0;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        ResetGame();
    }

    public void ResetGame()
    {
        text_1.text = "A";
        Q1_1 = 0; Q1_2 = 0; Q1_3 = 0; Q1_4 = 0;
    }
    public void ClickQ1_1()
    {
        switch (Q1_1)
        {
            case 0:
                Q1_1 += 1;
                text_1.text = "C";
                break;
            case 1:
                Q1_1 += 1;
                text_1.text = "E";
                break;
            case 2:
                Q1_1 += 1;
                text_1.text = "F";
                break;
            case 3:
                Q1_1 += 1;
                text_1.text = "H";
                break;
            case 4:
                Q1_1 += 1;
                text_1.text = "L";
                break;
            case 5:
                Q1_1 += 1;
                text_1.text = "M";
                break;
            case 6:
                Q1_1 += 1;
                text_1.text = "Q";
                break;
            case 7:
                Q1_1 += 1;
                text_1.text = "S";
                break;
            case 8:
                Q1_1 += 1;
                text_1.text = "V";
                break;
            case 9:
                Q1_1 += 1;
                text_1.text = "Z";
                break;
            case 10:
                Q1_1 = 0;
                text_1.text = "A";
                break;
        }
    }
    public void ClickQ1_2()
    {
        switch (Q1_2)
        {
            case 0:
                Q1_2 += 1;
                text_1.text = "C";
                break;
            case 1:
                Q1_2 += 1;
                text_1.text = "E";
                break;
            case 2:
                Q1_2 += 1;
                text_1.text = "F";
                break;
            case 3:
                Q1_2 += 1;
                text_1.text = "H";
                break;
            case 4:
                Q1_2 += 1;
                text_1.text = "L";
                break;
            case 5:
                Q1_2 += 1;
                text_1.text = "M";
                break;
            case 6:
                Q1_2 += 1;
                text_1.text = "Q";
                break;
            case 7:
                Q1_2 += 1;
                text_1.text = "S";
                break;
            case 8:
                Q1_2 += 1;
                text_1.text = "V";
                break;
            case 9:
                Q1_2 += 1;
                text_1.text = "Z";
                break;
            case 10:
                Q1_2 = 0;
                text_1.text = "A";
                break;
        }
    }
    public void ClickQ1_3()
    {
        switch (Q1_3)
        {
            case 0:
                Q1_3 += 1;
                text_1.text = "C";
                break;
            case 1:
                Q1_3 += 1;
                text_1.text = "E";
                break;
            case 2:
                Q1_3 += 1;
                text_1.text = "F";
                break;
            case 3:
                Q1_3 += 1;
                text_1.text = "H";
                break;
            case 4:
                Q1_3 += 1;
                text_1.text = "L";
                break;
            case 5:
                Q1_3 += 1;
                text_1.text = "M";
                break;
            case 6:
                Q1_3 += 1;
                text_1.text = "Q";
                break;
            case 7:
                Q1_3 += 1;
                text_1.text = "S";
                break;
            case 8:
                Q1_3 += 1;
                text_1.text = "V";
                break;
            case 9:
                Q1_3 += 1;
                text_1.text = "Z";
                break;
            case 10:
                Q1_3 = 0;
                text_1.text = "A";
                break;
        }
    }
    public void ClickQ1_4()
    {
        switch (Q1_4)
        {
            case 0:
                Q1_4 += 1;
                text_1.text = "C";
                break;
            case 1:
                Q1_4 += 1;
                text_1.text = "E";
                break;
            case 2:
                Q1_4 += 1;
                text_1.text = "F";
                break;
            case 3:
                Q1_4 += 1;
                text_1.text = "H";
                break;
            case 4:
                Q1_4 += 1;
                text_1.text = "L";
                break;
            case 5:
                Q1_4 += 1;
                text_1.text = "M";
                break;
            case 6:
                Q1_4 += 1;
                text_1.text = "Q";
                break;
            case 7:
                Q1_4 += 1;
                text_1.text = "S";
                break;
            case 8:
                Q1_4 += 1;
                text_1.text = "V";
                break;
            case 9:
                Q1_4 += 1;
                text_1.text = "Z";
                break;
            case 10:
                Q1_4 = 0;
                text_1.text = "A";
                break;
        }
    }
}
