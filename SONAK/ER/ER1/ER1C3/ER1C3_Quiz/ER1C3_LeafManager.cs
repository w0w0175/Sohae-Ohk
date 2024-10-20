using UnityEngine;
using UnityEngine.UI;

public class ER1C3_LeafManager : MonoBehaviour
{
    public static ER1C3_LeafManager Instance;
    
    public Text Answer;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    public void Click1()
    {
        Answer.text = "1";
    }
    public void Click2()
    {
        Answer.text = "2";
    }
    public void Click3()
    {
        Answer.text = "3";
    }
    public void Click4()
    {
        Answer.text = "4";
    }
    public void Click5()
    {
        Answer.text = "5";
    }
    public void Click6()
    {
        Answer.text = "6";
    }
    public void Click7()
    {
        Answer.text = "7";
    }
    public void Click8()
    {
        Answer.text = "8";
    }
    public void Click9()
    {
        Answer.text = "9";
    }
}
