using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    public Image ImgBlackboard;
    public Image ImgBookshelf;
    public Image ImgCandy;
    public Image ImgChocolate;
    public Image ImgClock;
    public Image ImgFishbowl;
    public Image ImgFlower;
    public Image ImgFrame;
    public Image ImgGlass;
    public Image ImgHairband;
    public Image ImgHat;
    public Image ImgRibbon;

    public void OnButtonClick()
    {
        Debug.Log("Button clicked");

        // 클릭된 버튼의 Source Image를 가져옴
        Sprite sourceImage = GetComponent<Image>().sprite;

        // 가져온 Source Image의 이름을 가져오기
        string imageName = sourceImage != null ? sourceImage.name : "Unknown";

        // 가져온 Source Image의 이름을 프린트
        Debug.Log("Source Image Name: " + imageName);

        // 가져온 Source Image의 이름에 따라 해당하는 이미지를 활성화
        switch (imageName)
        {
            case "Blackboard":
                ImgBlackboard.gameObject.SetActive(true);
                break;
            case "Bookshelf":
                ImgBookshelf.gameObject.SetActive(true);
                break;
            case "Candy":
                ImgCandy.gameObject.SetActive(true);
                break;
            case "Chocolate":
                ImgChocolate.gameObject.SetActive(true);
                break;
            case "Clock":
                ImgClock.gameObject.SetActive(true);
                break;
            case "Fishbowl":
                ImgFishbowl.gameObject.SetActive(true);
                break;
            case "Flower":
                ImgFlower.gameObject.SetActive(true);
                break;
            case "Frame":
                ImgFrame.gameObject.SetActive(true);
                break;
            case "Glass":
                ImgGlass.gameObject.SetActive(true);
                break;
            case "Hairband":
                ImgHairband.gameObject.SetActive(true);
                break;
            case "Hat":
                ImgHat.gameObject.SetActive(true);
                break;
            case "Ribbon":
                ImgRibbon.gameObject.SetActive(true);
                break;
            default:
                Debug.LogWarning("Unknown image name: " + imageName);
                break;
        }
    }
}
