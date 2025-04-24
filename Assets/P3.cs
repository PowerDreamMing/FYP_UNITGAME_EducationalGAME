using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Primary3 : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(3);
    }

}
