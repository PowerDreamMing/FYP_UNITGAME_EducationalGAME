using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public AudioClip[] audioClips;

    private GameObject gamePanel;
    GameObject camera;
    void Start()
    {
        gamePanel = GameObject.Find("GamePanel");
        camera = GameObject.Find("Main Camera");
    }

   
    void Update()
    {
        transform.Translate(Vector3.left * 100 * Time.deltaTime);
    }


   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                //碰到玩家音效
                AudioSource.PlayClipAtPoint(audioClips[0],camera.transform.position);

                gamePanel. SendMessage("CreateEnemy");
                gamePanel.SendMessage("GameOver");
                Destroy(gameObject);
                break;
            case "GongJian":
                //碰到弓箭音效
                AudioSource.PlayClipAtPoint(audioClips[1], camera.transform.position);
                Answer.enemyCount--;
                gamePanel. SendMessage("CreateEnemy");
                gamePanel.SendMessage("NextTM");
                Destroy(gameObject);
                Destroy(collision.gameObject);

                break;
        }
    }
}
