using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro ���̺귯�� �߰�

public class BuyItem : MonoBehaviour
{
    // ������ ��ư
    public Button Btn_Item;
    public Button Btn_Close;

    // TextMeshPro ������Ʈ ����
    public TextMeshProUGUI totalPointText;

    // ����Ʈ ����
    public int totalPoint;

    // ��ư ������Ʈ ����
    // ĳ����
    public Button btnHat;
    public Button btnRibbon;
    public Button btnCandy;
    public Button btnChocolate;
    public Button btnGlass;
    public Button btnHair;

    //����
    public Button btnPlant;
    public Button btnFish;
    public Button btnBook;
    public Button btnClock;
    public Button btnPicture;
    public Button btnBoard;

    // �̹��� ���� ��� ��ư
    public Button item1;
    public Button item2;
    public Button item3;
    public Button item4;
    public Button item5;
    public Button item6;
    public Button item7;
    public Button item8;
    public Button item9;
    public Button item10;
    public Button item11;
    public Button item12;

    // Warning ������Ʈ ����
    public GameObject warningObject;

    // ������ ���� (������ �̸�, �ʿ� ����Ʈ)
    public struct ItemInfo
    {
        public string itemName;
        public int requiredPoint;
        public Sprite itemSprite; // �̹��� �߰�
        public Button itemButton;
    }

    // ������ ���� ���
    public List<ItemInfo> itemInfoList = new List<ItemInfo>();

    // ItemBox ���� ������Ʈ ����
    public GameObject itemBox;

    // Ŭ���� ��ư ���� ��� ����Ʈ
    private List<ItemInfo> clickedItems = new List<ItemInfo>();

    void Start()
    {
        // ������ �ڽ� ��Ȱ��ȭ
        itemBox.SetActive(false);
        warningObject.SetActive(false);


    //아이템 정보 초기화 (ItemInfo에 버튼 참조 추가)
    itemInfoList.Add(new ItemInfo { itemName = "모자", requiredPoint = 3, itemSprite = hatSprite, itemButton = btnHat });
    itemInfoList.Add(new ItemInfo { itemName = "리본", requiredPoint = 3, itemSprite = ribbonSprite, itemButton = btnRibbon });
    itemInfoList.Add(new ItemInfo { itemName = "사탕", requiredPoint = 1, itemSprite = candySprite, itemButton = btnCandy });
    itemInfoList.Add(new ItemInfo { itemName = "초콜릿", requiredPoint = 2, itemSprite = chocolateSprite, itemButton = btnChocolate });
    itemInfoList.Add(new ItemInfo { itemName = "안경", requiredPoint = 3, itemSprite = glassSprite, itemButton = btnGlass });
    itemInfoList.Add(new ItemInfo { itemName = "머리핀", requiredPoint = 3, itemSprite = hairSprite, itemButton = btnHair });

    //가구
    itemInfoList.Add(new ItemInfo { itemName = "화분", requiredPoint = 3, itemSprite = plantSprite, itemButton = btnPlant });
    itemInfoList.Add(new ItemInfo { itemName = "어항", requiredPoint = 3, itemSprite = fishSprite, itemButton = btnFish });
    itemInfoList.Add(new ItemInfo { itemName = "책상", requiredPoint = 5, itemSprite = bookSprite, itemButton = btnBook });
    itemInfoList.Add(new ItemInfo { itemName = "시계", requiredPoint = 2, itemSprite = clockSprite, itemButton = btnClock });
    itemInfoList.Add(new ItemInfo { itemName = "그림", requiredPoint = 3, itemSprite = pictureSprite, itemButton = btnPicture });
    itemInfoList.Add(new ItemInfo { itemName = "게시판", requiredPoint = 5, itemSprite = boardSprite, itemButton = btnBoard });

        // ���� �������� totalPointText�� ������Ʈ�մϴ�.
        UpdateText();

        // ��ư �̺�Ʈ ����
        // ĳ����
        btnHat.onClick.AddListener(() => Buy(itemInfoList[0]));
        btnRibbon.onClick.AddListener(() => Buy(itemInfoList[1]));
        btnCandy.onClick.AddListener(() => Buy(itemInfoList[2]));
        btnChocolate.onClick.AddListener(() => Buy(itemInfoList[3]));
        btnGlass.onClick.AddListener(() => Buy(itemInfoList[4]));
        btnHair.onClick.AddListener(() => Buy(itemInfoList[5]));

        //����
        btnPlant.onClick.AddListener(() => Buy(itemInfoList[6]));
        btnFish.onClick.AddListener(() => Buy(itemInfoList[7]));
        btnBook.onClick.AddListener(() => Buy(itemInfoList[8]));
        btnClock.onClick.AddListener(() => Buy(itemInfoList[9]));
        btnPicture.onClick.AddListener(() => Buy(itemInfoList[10]));
        btnBoard.onClick.AddListener(() => Buy(itemInfoList[11]));

        // Btn_Item ��ư �̺�Ʈ ����
        Btn_Item.onClick.AddListener(ActivateItemBox);
        Btn_Close.onClick.AddListener(DeActivateItemBox);
    }

    void ActivateItemBox()
    {
        itemBox.SetActive(true);
    }

    void DeActivateItemBox()
    {
        itemBox.SetActive(false);
    }

    public Sprite purchasedSprite; // 구매 완료 스프라이트를 여기서 할당

    void Buy(ItemInfo itemInfo)
    {
        int remainingPoint = GameManager.Instance.sticker - itemInfo.requiredPoint;

        if (remainingPoint >= 0)
        {
            totalPoint = remainingPoint;
            UpdateText();

            // 스티커 차감
            GameManager.Instance.sticker -= itemInfo.requiredPoint;
            UpdateTotalPointText(GameManager.Instance.sticker);

            clickedItems.Add(itemInfo);
            UpdateItemImages();

            // 구매된 버튼 이미지 변경 및 상호작용 비활성화
            itemInfo.itemButton.image.sprite = purchasedSprite;
            itemInfo.itemButton.interactable = false;

            // 자식 요소 비활성화
            foreach (Transform child in itemInfo.itemButton.transform)
            {
                child.gameObject.SetActive(false);
            }
        }
        else
        {
            StartCoroutine(ShowWarningMessage());
        }
    }



    void UpdateTotalPointText(int totalPoint)
    {
        totalPointText.text = totalPoint.ToString();
    }


    void UpdateItemImages()
    {
        // ��ư ������ ���� �̹��� ����
        if (clickedItems.Count > 0) item1.image.sprite = clickedItems[0].itemSprite;
        if (clickedItems.Count > 1) item2.image.sprite = clickedItems[1].itemSprite;
        if (clickedItems.Count > 2) item3.image.sprite = clickedItems[2].itemSprite;
        if (clickedItems.Count > 3) item4.image.sprite = clickedItems[3].itemSprite;
        if (clickedItems.Count > 4) item5.image.sprite = clickedItems[4].itemSprite;
        if (clickedItems.Count > 5) item6.image.sprite = clickedItems[5].itemSprite;
        if (clickedItems.Count > 6) item7.image.sprite = clickedItems[6].itemSprite;
        if (clickedItems.Count > 7) item8.image.sprite = clickedItems[7].itemSprite;
        if (clickedItems.Count > 8) item9.image.sprite = clickedItems[8].itemSprite;
        if (clickedItems.Count > 9) item10.image.sprite = clickedItems[9].itemSprite;
        if (clickedItems.Count > 10) item11.image.sprite = clickedItems[10].itemSprite;
        if (clickedItems.Count > 11) item12.image.sprite = clickedItems[11].itemSprite;
    }

    IEnumerator ShowWarningMessage()
    {
        warningObject.SetActive(true); // Warning ������Ʈ Ȱ��ȭ
        yield return new WaitForSeconds(2.0f); // 2�� ���
        warningObject.SetActive(false); // Warning ������Ʈ ��Ȱ��ȭ
    }

    void UpdateText()
    {
        totalPointText.text = totalPoint.ToString();
    }

    // �ν����Ϳ��� �Ҵ��� Sprite �ʵ�
    public Sprite hatSprite;
    public Sprite ribbonSprite;
    public Sprite plantSprite;
    public Sprite fishSprite;
    public Sprite bookSprite;
    public Sprite glassSprite;
    public Sprite hairSprite;
    public Sprite clockSprite;
    public Sprite pictureSprite;
    public Sprite boardSprite;
    public Sprite candySprite;
    public Sprite chocolateSprite;
}