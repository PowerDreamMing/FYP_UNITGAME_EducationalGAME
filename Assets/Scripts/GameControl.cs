using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemyObg;          // 敌人
    public GameObject gongjianObj;          // 武器
    public GameObject gameOverPanel;        // 游戏失败面板
    public Text winText;
    public static bool isRight = false;     // 答题是否正确
    private int numSort = 0;                // 敌人编号
    private GameObject player;              // 玩家

    public AudioClip[] audioClips;

    public GameObject imgCoin;

    GameObject camera;

    // 冷卻相關變數
    public float fireCooldown = 2f;         // 冷却时间 (秒)
    //public float fireCooldown = 2f; 
    private float lastFireTime;             // 上次發射時間

    private void Start()
    {
        Time.timeScale = 1;
        player = GameObject.Find("Player");
        gameOverPanel.SetActive(false);
        camera = GameObject.Find("Main Camera");

        // 確保開始時可以立即發射
        lastFireTime = Time.time - fireCooldown;
    }

    private void Update()
    {
        // 答題正確時檢查冷卻條件
        if (isRight && Time.time >= lastFireTime + fireCooldown)
        {
            FireGongJian(); // 发射子弹
            isRight = false; // 重置答題狀態
            ShopManager.coinAllCount += 100;
        }

        // 支持按下空格键发射，但受冷却时间限制
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= lastFireTime + fireCooldown)
        {
            FireGongJian(); // 发射子弹
        }
    }

    // 生成敌人
    public void CreateEnemy()
    {
        // 更新敵人編號
        numSort++;
        if (numSort > 2)
        {
            numSort = 0;
        }

        // 生成敵人
        GameObject go = Instantiate(enemyObg[numSort]);
        go.transform.SetParent(transform);
        go.transform.localPosition = new Vector3(699, 0, 0);

        // 更新答題狀態和冷卻時間
        isRight = false; // 確保新敵人生成時不會立即發射
        lastFireTime = Time.time - fireCooldown; // 確保冷卻計時已準備好
    }

    // 发射子弹
    private void FireGongJian()
    {
        AudioSource.PlayClipAtPoint(audioClips[0], camera.transform.position);
        GameObject go = Instantiate(gongjianObj);
        go.transform.SetParent(player.transform);
        go.transform.localPosition = new Vector3(53, 76, 0);

        // 更新冷卻時間
        lastFireTime = Time.time;
    }

    // 游戏失败
    public void GameOver()
    {
        AudioSource.PlayClipAtPoint(audioClips[1], camera.transform.position);
        gameOverPanel.SetActive(true);
        winText.text = "Mission Failed";
        Time.timeScale = 0;
        imgCoin.SetActive(false);
    }

    // 游戏胜利，下一关
    public void GameWin()
    {
        AudioSource.PlayClipAtPoint(audioClips[3], camera.transform.position);
        gameOverPanel.SetActive(true);
        winText.text = "MIssion Completed";
        Time.timeScale = 0;
        imgCoin.SetActive(true);
    }
}