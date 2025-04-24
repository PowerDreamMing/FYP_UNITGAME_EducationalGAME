using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerImage : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (ShopManager.isBuyScuess)
        {
            gameObject.GetComponent<Image>().sprite = ShopManager.playerSprite;
        }
      
    }
}
