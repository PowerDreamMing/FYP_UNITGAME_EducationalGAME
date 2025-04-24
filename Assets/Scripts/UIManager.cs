using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //[SerializeField]
    //private GameObject[] UIPanel;

    //public static bool isGameBg = false;



    // 方法2-场景切换
    public void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
 
  public void GameBack()
    {
        SceneManager.LoadScene("MapScene"+(MainOptionManager.curCourseNum+1));
    }

    //public void PlayBtn()
    //{
    //    UIPanel[1].SetActive(true);
    //}
    //public void PlayBackBtn()
    //{
    //    UIPanel[1].SetActive(false);
    //}

    //public void EquipmentBtn()
    //{
    //    UIPanel[4].SetActive(true);
    //}
    //public void EquipmentBackBtn()
    //{
    //    UIPanel[4].SetActive(false);
    //}


    //public void  KeTiBtn()
    //{
    //    UIPanel[2].SetActive(true);
    //    UIPanel[1].SetActive(false);
    //}
    //public void KeTiBackBtn()
    //{
    //    UIPanel[1].SetActive(true);
    //    UIPanel[2].SetActive(false);
    //}


    //public void GuanQiaBtn()
    //{
    //    UIPanel[3].SetActive(true);
    //    UIPanel[2].SetActive(false);
    //    isGameBg = true;
    //}
    //public void GuanQiaBackBtn()
    //{
    //    UIPanel[2].SetActive(true);
    //    UIPanel[3].SetActive(false);
    //}
}
