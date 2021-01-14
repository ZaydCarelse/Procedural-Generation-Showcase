using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S4HSlider : MonoBehaviour
{
    public static S4HSlider instance;

    public float hNum;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }

        hNum = PlayerPrefs.GetFloat("S4Hnum");
        gameObject.GetComponent<Slider>().value = hNum;
    }

    public void OnChange()
    {
        hNum = GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("S4Hnum", hNum);
        PlayerPrefs.Save();
    }
}
