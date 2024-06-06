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
        // Ŭ���� ��ư�� Source Image�� ������
        Sprite sourceImage = GetComponent<Image>().sprite;

        // ������ Source Image�� ���� �ش��ϴ� �̹����� Ȱ��ȭ�ϰ� �������� ��Ȱ��ȭ
        if (sourceImage == ImgBlackboard.sprite)
        {
            ToggleImage(ImgBlackboard);
        }
        else if (sourceImage == ImgBookshelf.sprite)
        {
            ToggleImage(ImgBookshelf);
        }
        else if (sourceImage == ImgCandy.sprite)
        {
            ToggleImage(ImgCandy);
        }
        else if (sourceImage == ImgChocolate.sprite)
        {
            ToggleImage(ImgChocolate);
        }
        else if (sourceImage == ImgClock.sprite)
        {
            ToggleImage(ImgClock);
        }
        else if (sourceImage == ImgFishbowl.sprite)
        {
            ToggleImage(ImgFishbowl);
        }
        else if (sourceImage == ImgFlower.sprite)
        {
            ToggleImage(ImgFlower);
        }
        else if (sourceImage == ImgFrame.sprite)
        {
            ToggleImage(ImgFrame);
        }
        else if (sourceImage == ImgGlass.sprite)
        {
            ToggleImage(ImgGlass);
        }
        else if (sourceImage == ImgHairband.sprite)
        {
            ToggleImage(ImgHairband);
        }
        else if (sourceImage == ImgHat.sprite)
        {
            ToggleImage(ImgHat);
        }
        else if (sourceImage == ImgRibbon.sprite)
        {
            ToggleImage(ImgRibbon);
        }
        else
        {
            // ��� �̹����� ��Ȱ��ȭ
            DisableAllImages();
        }
    }

    private void DisableAllImages()
    {
        ImgBlackboard.gameObject.SetActive(false);
        ImgBookshelf.gameObject.SetActive(false);
        ImgCandy.gameObject.SetActive(false);
        ImgChocolate.gameObject.SetActive(false);
        ImgClock.gameObject.SetActive(false);
        ImgFishbowl.gameObject.SetActive(false);
        ImgFlower.gameObject.SetActive(false);
        ImgFrame.gameObject.SetActive(false);
        ImgGlass.gameObject.SetActive(false);
        ImgHairband.gameObject.SetActive(false);
        ImgHat.gameObject.SetActive(false);
        ImgRibbon.gameObject.SetActive(false);
    }

    private void ToggleImage(Image image)
    {
        DisableAllImages();
        image.gameObject.SetActive(true);
    }
}
