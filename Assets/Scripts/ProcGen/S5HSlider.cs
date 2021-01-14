using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S5HSlider : MonoBehaviour
{
    public static S5HSlider instance;

    public float hNum;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        hNum = PlayerPrefs.GetFloat("S5Hnum");
        gameObject.GetComponent<Slider>().value = hNum;
    }

    public void OnChange()
    {
        hNum = GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("S5Hnum", hNum);
        PlayerPrefs.Save();
    }
}