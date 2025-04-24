using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WuQiManager : MonoBehaviour
{
    private ScrollRect scrollRect;
    public Text priceText;
    [SerializeField]
    private Sprite[] playerSprite;

    public Image playerImage;

    public static int wuqiNum = 0;

   public static int num = 0;


    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
        scrollRect.onValueChanged.AddListener(OnChange);
        num = 0;
    }


    void Update()
    {
        WuQiAndImage();
        if (num == 0)
        {
            priceText.text = "$100";
        }
    }
    public void OnChange(Vector2 scrollValue)
    {
        if (scrollValue.x >= 0 && scrollValue.x <= 0.4f)
        {
            wuqiNum = 0;
           
        }
        else if (scrollValue.x >= 0.4f && scrollValue.x <= 0.75f)
        {
            wuqiNum = 1;
        }
        else if (scrollValue.x > 0.75f)
        {
            wuqiNum = 2;
        }
       // WuQiAndImage();
        num=1;
    }

    public void WuQiAndImage()
    {
        if (wuqiNum == 0)
        {
            //priceText.text = "$100";
            ShopManager.CoinCount = 100;
            ShopManager.playerSprite = playerSprite[0];
        }
        else if (wuqiNum == 1)
        {
           // priceText.text = "$200";
            ShopManager.CoinCount = 200;
            ShopManager.playerSprite = playerSprite[1];
        }
        else if (wuqiNum == 2)
        {
            priceText.text = "$2000";
            ShopManager.CoinCount = 2000;
            ShopManager.playerSprite = playerSprite[2];
        }
    }


}


