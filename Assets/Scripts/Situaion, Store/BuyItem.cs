using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro 라이브러리 추가

public class BuyItem : MonoBehaviour
{
    // 아이템 버튼
    public Button Btn_Item;
    public Button Btn_Close;

    // TextMeshPro 오브젝트 참조
    public TextMeshProUGUI totalPointText;

    // 게임 매니저
    public GameManager gameManager;

    // 포인트 변수
    public int totalPoint;

    // 버튼 오브젝트 참조
    // 캐릭터
    public Button btnHat;
    public Button btnRibbon;
    public Button btnCandy;
    public Button btnChocolate;
    public Button btnGlass;
    public Button btnHair;

    //교실
    public Button btnPlant;
    public Button btnFish;
    public Button btnBook;
    public Button btnClock;
    public Button btnPicture;
    public Button btnBoard;

    // 이미지 변경 대상 버튼
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

    // Warning 오브젝트 참조
    public GameObject warningObject;

    // 아이템 정보 (아이템 이름, 필요 포인트)
    public struct ItemInfo
    {
        public string itemName;
        public int requiredPoint;
        public Sprite itemSprite; // 이미지 추가
    }

    // 아이템 정보 목록
    public List<ItemInfo> itemInfoList = new List<ItemInfo>();

    // ItemBox 게임 오브젝트 참조
    public GameObject itemBox;

    // 클릭된 버튼 순서 기록 리스트
    private List<ItemInfo> clickedItems = new List<ItemInfo>();

    void Start()
    {
        // GameManager 인스턴스에 대한 참조 가져오기
        gameManager = GameManager.Instance;

        // 아이템 박스 비활성화
        itemBox.SetActive(false);
        warningObject.SetActive(false);


        // 아이템 정보 설정
        //캐릭터
        itemInfoList.Add(new ItemInfo { itemName = "모자", requiredPoint = 3, itemSprite = hatSprite });
        itemInfoList.Add(new ItemInfo { itemName = "리본", requiredPoint = 3, itemSprite = ribbonSprite });
        itemInfoList.Add(new ItemInfo { itemName = "사탕", requiredPoint = 1, itemSprite = candySprite });
        itemInfoList.Add(new ItemInfo { itemName = "초콜릿", requiredPoint = 2, itemSprite = chocolateSprite });
        itemInfoList.Add(new ItemInfo { itemName = "안경", requiredPoint = 3, itemSprite = glassSprite });
        itemInfoList.Add(new ItemInfo { itemName = "머리띠", requiredPoint = 3, itemSprite = hairSprite });

        //교실
        itemInfoList.Add(new ItemInfo { itemName = "화분", requiredPoint = 3, itemSprite = plantSprite });
        itemInfoList.Add(new ItemInfo { itemName = "물고기", requiredPoint = 3, itemSprite = fishSprite });
        itemInfoList.Add(new ItemInfo { itemName = "책장", requiredPoint = 5, itemSprite = bookSprite });
        itemInfoList.Add(new ItemInfo { itemName = "시계", requiredPoint = 2, itemSprite = clockSprite });
        itemInfoList.Add(new ItemInfo { itemName = "액자", requiredPoint = 3, itemSprite = pictureSprite });
        itemInfoList.Add(new ItemInfo { itemName = "칠판", requiredPoint = 5, itemSprite = boardSprite });

        // 시작 시점에서 totalPointText를 업데이트합니다.
        UpdateText();

        // 버튼 이벤트 설정
        // 캐릭터
        btnHat.onClick.AddListener(() => Buy(itemInfoList[0]));
        btnRibbon.onClick.AddListener(() => Buy(itemInfoList[1]));
        btnCandy.onClick.AddListener(() => Buy(itemInfoList[2]));
        btnChocolate.onClick.AddListener(() => Buy(itemInfoList[3]));
        btnGlass.onClick.AddListener(() => Buy(itemInfoList[4]));
        btnHair.onClick.AddListener(() => Buy(itemInfoList[5]));

        //교실
        btnPlant.onClick.AddListener(() => Buy(itemInfoList[6]));
        btnFish.onClick.AddListener(() => Buy(itemInfoList[7]));
        btnBook.onClick.AddListener(() => Buy(itemInfoList[8]));
        btnClock.onClick.AddListener(() => Buy(itemInfoList[9]));
        btnPicture.onClick.AddListener(() => Buy(itemInfoList[10]));
        btnBoard.onClick.AddListener(() => Buy(itemInfoList[11]));

        // Btn_Item 버튼 이벤트 설정
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

    void Buy(ItemInfo itemInfo)
    {
        int remainingPoint = gameManager.sticker - itemInfo.requiredPoint;

        if (remainingPoint >= 0)
        {
            print("넘음");
            totalPoint = remainingPoint;
            UpdateText();

            // 스티커 감소
            gameManager.sticker -= itemInfo.requiredPoint;
            UpdateTotalPointText(gameManager.sticker);

            clickedItems.Add(itemInfo);
            UpdateItemImages();
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
        // 버튼 순서에 따라 이미지 변경
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
        warningObject.SetActive(true); // Warning 오브젝트 활성화
        yield return new WaitForSeconds(2.0f); // 2초 대기
        warningObject.SetActive(false); // Warning 오브젝트 비활성화
    }

    void UpdateText()
    {
        totalPointText.text = totalPoint.ToString();
    }

    // 인스펙터에서 할당할 Sprite 필드
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