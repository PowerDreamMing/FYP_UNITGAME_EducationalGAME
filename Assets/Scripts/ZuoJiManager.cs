using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZuoJiManager : MonoBehaviour
{
   
    public Text priceText;
    [SerializeField]
    private Sprite[] zuojiSprite;
    public Image playerImage;

   public static int zuojiNum = 0;


    void Start()
    {
       
    }

    void Update()
    {
        ZuoJiAndImage();
       
    }
    public void OnChange(Vector2 scrollValue)
    {
        if (scrollValue.x >= 0 && scrollValue.x <= 0.4f)
        {
            zuojiNum = 0;
        }
        else if (scrollValue.x >= 0.4f && scrollValue.x <= 0.75f)
        {
            zuojiNum = 1;
        }
        else if (scrollValue.x > 0.75f)
        {
            zuojiNum = 2;
        }
    }

    public void ZuoJiAndImage()
    {
       
            if (WuQiManager.wuqiNum == 0)
            {
                if (zuojiNum == 0)
                {
                   //priceText.text = "$200";
                ShopManager.CoinCount = 200;
                ShopManager.playerSprite = zuojiSprite[0];
            }
                else if (zuojiNum == 1)
                {
                //priceText.text = "$500";
                ShopManager.CoinCount = 500;
                ShopManager.playerSprite = zuojiSprite[1];
            }
                else if (zuojiNum == 2)
                {
                //priceText.text = "$800";
                ShopManager.CoinCount = 800;
                ShopManager.playerSprite = zuojiSprite[2];
            }
            }
            else if (WuQiManager.wuqiNum == 1)
            {
                
                if (zuojiNum == 0)
                {
                // priceText.text = "$200";
                ShopManager.CoinCount = 200;
                ShopManager.playerSprite = zuojiSprite[3];
            }
                else if (zuojiNum == 1)
                {
                //priceText.text = "$500";
                ShopManager.CoinCount = 500;
                ShopManager.playerSprite = zuojiSprite[4];
            }
                else if (zuojiNum == 2)
                {
               // priceText.text = "$800";
                ShopManager.CoinCount = 800;
                ShopManager.playerSprite = zuojiSprite[5];
                }
            }
            else if (WuQiManager.wuqiNum == 2)
            {
            if (zuojiNum == 0)
                {
                //priceText.text = "$200";
                ShopManager.CoinCount = 200;
                ShopManager.playerSprite = zuojiSprite[6];
            }
                else if (zuojiNum == 1)
                {
                // priceText.text = "$500";
                ShopManager.CoinCount = 500;
                ShopManager.playerSprite = zuojiSprite[7];

            }
                else if (zuojiNum == 2)
                {
                //priceText.text = "$800";
                ShopManager.CoinCount = 800;
                ShopManager.playerSprite = zuojiSprite[8];
            }
        }
    }
}
