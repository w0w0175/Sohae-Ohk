using UnityEngine;

public class ER1C2_TreeManager : MonoBehaviour
{
    public static ER1C2_TreeManager Instance;

    public GameObject Tree1;
    public GameObject Tree2;
    public GameObject Tree3;
    public GameObject Tree4;

    bool tree1 = false;
    bool tree2 = false;
    bool tree3 = false;
    bool tree4 = false;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    void Update()
    {
        if (Tree1.activeSelf == false && Tree2.activeSelf == false && Tree3.activeSelf == false && Tree4.activeSelf == false)
        {
            if (tree4)
            {
                ER1C2_MoveManager.Instance.TreeSuccess();
            }
            else
            {
                ER1C2_MoveManager.Instance.TreeFail();
            }
        }
    }
    public void ClickTree1()
    {
        if (tree2 == false && tree3 == false && tree4 == false)
        {
            Tree1.SetActive(false);
            tree1 = true;
        }
        else
        {
            Tree1.SetActive(false);
            tree1 = false;
        }
    }
    public void ClickTree2()
    {
        if (tree1)
        {
            Tree2.SetActive(false);
            tree2 = true;
        }
        else
        {
            Tree2.SetActive(false);
            tree2 = false;
        }
    }
    public void ClickTree3()
    {
        if (tree2)
        {
            Tree3.SetActive(false);
            tree3 = true;
        }
        else
        {
            Tree3.SetActive(false);
            tree3 = false;
        }
    }
    public void ClickTree4()
    {
        if (tree3)
        {
            Tree4.SetActive(false);
            tree4 = true;
        }
        else
        {
            Tree4.SetActive(false);
            tree4 = false;
        }
    }
    public void ResetGame()
    {
        Tree1.SetActive(true);
        Tree2.SetActive(true);
        Tree3.SetActive(true);
        Tree4.SetActive(true);

        tree1 = false;
        tree2 = false;
        tree3 = false;
        tree4 = false;
    }
}
