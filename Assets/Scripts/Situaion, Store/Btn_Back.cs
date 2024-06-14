using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro ���̺귯�� �߰�

public class Btn_Back : MonoBehaviour
{
    public Button Btn_Day1Back;
    public Button Btn_Day2Back;
    public GameObject Day1;
    public GameObject Day2;
    public GameObject Day2_Unlock;

    // TextMeshPro ������Ʈ ����
    public TextMeshProUGUI totalPointText;

    public GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        // Day1Back ��ư�� ������ �߰�
        Btn_Day1Back.onClick.AddListener(OnDay1BackClicked);
        // Day2Back ��ư�� ������ �߰�
        Btn_Day2Back.onClick.AddListener(OnDay2BackClicked);
    }

    void OnDay1BackClicked()
    {
        // Day1 ������Ʈ�� ��Ȱ��ȭ
        Day1.SetActive(false);
        // Day2_Unlock ������Ʈ�� Ȱ��ȭ
        Day2_Unlock.SetActive(true);

        // GameManager�� sticker�� ������Ű�� ������Ʈ�� ���� �ؽ�Ʈ�� ǥ��
        gm.GetComponent<GameManager>().stickerUp();
        UpdateTotalPointText(gm.GetComponent<GameManager>().sticker);
    }

    void OnDay2BackClicked()
    {
        // Day2 ������Ʈ�� ��Ȱ��ȭ
        Day2.SetActive(false);

        // GameManager�� sticker�� ������Ű�� ������Ʈ�� ���� �ؽ�Ʈ�� ǥ��
        gm.GetComponent<GameManager>().stickerUp();
        UpdateTotalPointText(gm.GetComponent<GameManager>().sticker);
    }

    // totalPointText ������Ʈ �޼���
    void UpdateTotalPointText(int totalPoint)
    {
        totalPointText.text = totalPoint.ToString();
    }
}
