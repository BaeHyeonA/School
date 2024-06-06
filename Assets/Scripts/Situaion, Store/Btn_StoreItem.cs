using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Btn_StoreItem : MonoBehaviour
{
    // 오브젝트 참조 변수
    public GameObject ClassItem;
    public GameObject Character;
    public GameObject AllItem;

    // 버튼 오브젝트 참조 변수
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
        Character.SetActive(true); // 기본적으로 캐릭터 아이템 활성화
    }

    void DeactivateAllItems()
    {
        AllItem.SetActive(false);
        Character.SetActive(false);
        ClassItem.SetActive(false); // ClassItem 비활성화 추가
    }
}
