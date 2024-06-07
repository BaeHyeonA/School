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

        // Ŭ���� ��ư�� Source Image�� ������
        Sprite sourceImage = GetComponent<Image>().sprite;

        // ������ Source Image�� �̸��� ��������
        string imageName = sourceImage != null ? sourceImage.name : "Unknown";

        // ������ Source Image�� �̸��� ����Ʈ
        Debug.Log("Source Image Name: " + imageName);

        // ������ Source Image�� �̸��� ���� �ش��ϴ� �̹����� Ȱ��ȭ
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
