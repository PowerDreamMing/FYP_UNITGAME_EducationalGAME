using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Toggle toggle;
    public static int CoinCount = 0;                    // 當前物品價格
    public static int coinAllCount = 100000;            // 玩家總金幣數量
    public static Sprite playerSprite;                  // 玩家角色圖片

    public Sprite chushiSprite;                         // 初始圖片
    public Image img;                                   // 當前顯示圖片

    public Text coinAllText;                            // 金幣顯示UI

    public static bool isBuyScuess;                     // 購買結果標記

    public Text bugResText;                             // 購買結果提示
    public GameObject bugPanel;                         // 購買結果顯示面板

    public Text priceText;                              // 價格顯示

    GameObject camera;
    public AudioClip bugAudio;

    // 使用布林陣列標記物品是否已購買
    bool[] isBug = { false, false, false, false, false, false };

    private void Start()
    {
        camera = GameObject.Find("Main Camera");
        coinAllText.text = "$" + coinAllCount;
    }

    private void Update()
    {
        // 更新金幣顯示
        coinAllText.text = "$" + coinAllCount;

        // 根據選擇武器更新顯示內容
        if (WuQiManager.num == 0)
        {
            img.sprite = chushiSprite;
            priceText.text = "$100";
        }
        else
        {
            img.sprite = playerSprite;
            priceText.text = "$" + CoinCount;
        }
    }

    // 購買按鈕事件
    public void UseBtn()
    {
        AudioSource.PlayClipAtPoint(bugAudio, camera.transform.position);

        if (toggle.isOn) // 購買武器
        {
            if (WuQiManager.wuqiNum == 0)
            {
                CoinCount = 100;
                CheckAndBuy(0);
            }
            else if (WuQiManager.wuqiNum == 1)
            {
                CoinCount = 200;
                CheckAndBuy(1);
            }
            else if (WuQiManager.wuqiNum == 2)
            {
                CoinCount = 2000;
                CheckAndBuy(2);
            }
        }
        else // 購買坐騎
        {
            if (ZuoJiManager.zuojiNum == 0)
            {
                CoinCount = 200;
                CheckAndBuy(3);
            }
            else if (ZuoJiManager.zuojiNum == 1)
            {
                CoinCount = 500;
                CheckAndBuy(4);
            }
            else if (ZuoJiManager.zuojiNum == 2)
            {
                CoinCount = 800;
                CheckAndBuy(5);
            }
        }
    }

    // 檢查購買狀態並處理購買邏輯
    public void CheckAndBuy(int index)
    {
        if (isBug[index]) // 如果已經購買
        {
            bugPanel.gameObject.SetActive(true);
            bugResText.text = "This item has already been purchased!";
            Invoke("BugFalse", 1f);
            return;
        }

        Bug(index); // 嘗試購買
    }

    // 購買邏輯
    public void Bug(int index)
    {
        bugPanel.gameObject.SetActive(true);

        if (coinAllCount < CoinCount)
        {
            bugResText.text = "There's not enough coins to buy it. Please go and answer the questions to get the coins!";
            isBuyScuess = false;
        }
        else
        {
            bugResText.text = "Purchase Success";
            coinAllCount -= CoinCount;
            isBuyScuess = true;

            // 購買成功標記該物品為已購買
            isBug[index] = true;
        }

        Invoke("BugFalse", 1f);
    }

    // 關閉購買結果面板
    public void BugFalse()
    {
        bugPanel.gameObject.SetActive(false);
    }

    // **檢查物品是否可用**
    public bool IsPurchased(int index)
    {
        return isBug[index]; // 返回是否已購買
    }

    // **嘗試放置物品**
    public void TryPlaceItem(int index)
    {
        if (IsPurchased(index)) // 檢查是否已購買
        {
            Debug.Log("Item placed successfully!");
            // 添加物品放置邏輯
        }
        else
        {
            Debug.Log("You cannot place this item as it is not purchased!");
            bugPanel.SetActive(true);
            bugResText.text = "You need to buy this item first!";
            Invoke("BugFalse", 1f);
        }
    }
}