using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMControl : MonoBehaviour
{
    private void Awake()
    {
        if (FindObjectsOfType<BGMControl>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
