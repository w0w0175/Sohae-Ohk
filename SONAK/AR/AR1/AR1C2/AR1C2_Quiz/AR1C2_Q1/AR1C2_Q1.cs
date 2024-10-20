using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEngine.EventSystems.EventTrigger;

public class AR1C2_Q1 : MonoBehaviour
{
    public GameObject ClickBtnBox;
    public GameObject ClickOneBtn;

    public GameObject Q1NoticeBox;
    public EventTrigger Q1Notice;
    public Text Q1NoticeText;

    public GameObject Houses;

    private EventTrigger.Entry entry1;
    private EventTrigger.Entry entry2;

    void Start()
    {
        entry1 = new EventTrigger.Entry();
        entry1.eventID = EventTriggerType.PointerClick;

        entry2 = new EventTrigger.Entry();
        entry2.eventID = EventTriggerType.PointerClick;

        Q1NoticeText.text = "�˺긮�ư� 9��������\n������ ���� 8���� ���� �ִ�."
                            + "\n\n�߸��� ���� ã�ư� �Ҷ��� �ǿ��\n"
                            + "���� ��ġæ ������ ������ ����� �ֱ⿡,\n"
                            + "������ �ִ� ���� ���� ã�ư��� �Ѵ�.";

        Houses.SetActive(false);

        entry1.callback.RemoveAllListeners();
        entry1.callback.AddListener(NextNotice2);
        Q1Notice.triggers.Remove(entry1);
        Q1Notice.triggers.Add(entry1);
    }

    public void NextNotice1()
    {
        Q1NoticeText.text = "�˺긮�ư� 9��������\n������ ���� 8���� ���� �ִ�."
                            + "\n\n�߸��� ���� ã�ư� �Ҷ��� �ǿ��\n"
                            + "���� ��ġæ ������ ������ ����� �ֱ⿡,\n"
                            + "������ �ִ� ���� ���� ã�ư��� �Ѵ�.";

        Q1NoticeBox.SetActive(true);
        ClickBtnBox.SetActive(false);
        ClickOneBtn.SetActive(false);

        Houses.SetActive(false);

        entry2.callback.RemoveAllListeners();
        entry2.callback.AddListener(NextNotice3);
        Q1Notice.triggers.Remove(entry2);
        Q1Notice.triggers.Add(entry2);
    }

    void NextNotice2(BaseEventData p)
    {
        Q1NoticeText.text = "�˺긮�� ���� ���� �� ������ �ϳ� �ִ�.\n"
                            + "�� �������� ���� ������ ���̴�.\n\n"
                            + "�ʺ긮�� ���� ���� ��,\n���̶��� ã�� �ִ� ������\n"
                            + "����Ƽ�� ���۰��� �������� ��� �ִ�\n"
                            + "�ϼ����� ���� �ָ� ������ �ִ�.\n\n"
                            + "�� �ϼ����� ���� ������ ���� ���ʿ� ��ġ�� �ִ�.\n"
                            + "������ ������ �˺긮�� ���� �� ��° ���ϱ�?";

        //AR1C2_MoveManager.instance.Q1NextNotice2();
    }

    void NextNotice3(BaseEventData p)
    {
        Q1NoticeText.text = "�˺긮�� ���� ���� �� ������ �ϳ� �ִ�.\n"
                            + "�� �������� ���� ������ ���̴�.\n\n"
                            + "�ʺ긮�� ���� ���� ��,\n���̶��� ã�� �ִ� ������\n"
                            + "����Ƽ�� ���۰��� �������� ��� �ִ�\n"
                            + "�ϼ����� ���� �ָ� ������ �ִ�.\n\n"
                            + "�� �ϼ����� ���� ������ ���� ���ʿ� ��ġ�� �ִ�.\n"
                            + "������ ������ �˺긮�� ���� �� ��° ���ϱ�?";

        Q1NoticeBox.SetActive(true);
        ClickBtnBox.SetActive(false);
        ClickOneBtn.SetActive(false);

        Houses.SetActive(false);

        entry1.callback.RemoveAllListeners();
        entry1.callback.AddListener(Text1);
        Q1Notice.triggers.Remove(entry1);
        Q1Notice.triggers.Add(entry1);
    }

    void Text1(BaseEventData p)
    {
       // AR1C2_MoveManager.instance.Q1NextNotice2();
    }
}