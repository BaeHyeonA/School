using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Btn_StoreItem : MonoBehaviour
{
    // ������Ʈ ���� ����
    public GameObject ClassItem;
    public GameObject Character;
    public GameObject AllItem;

    // ��ư ������Ʈ ���� ����
    public Button ClassroomButton;
    public Button CharacterButton;
    public Button Btn_Store;
    public Button Btn_Close;

    void Start()
    {
        ClassItem.SetActive(false);
        Character.SetActive(true);
        AllItem.SetActive(false);

        ClassroomButton.onClick.AddListener(() => ActivateObject(ClassItem));
        CharacterButton.onClick.AddListener(() => ActivateObject(Character));
        Btn_Store.onClick.AddListener(() => ActivateAllItems());
        Btn_Close.onClick.AddListener(() => DeactivateAllItems());
    }

    void ActivateObject(GameObject obj)
    {
        ClassItem.SetActive(obj == ClassItem);
        Character.SetActive(obj == Character);

        obj.SetActive(true);
    }

    void ActivateAllItems()
    {
        AllItem.SetActive(true);
        Character.SetActive(true); // �⺻������ ĳ���� ������ Ȱ��ȭ
    }

    void DeactivateAllItems()
    {
        AllItem.SetActive(false);
        Character.SetActive(false);
        ClassItem.SetActive(false); // ClassItem ��Ȱ��ȭ �߰�
    }
}
