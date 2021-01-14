using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S5VSlider : MonoBehaviour
{
    public static S5VSlider instance;

    public float vNum;

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

        vNum = PlayerPrefs.GetFloat("S5Vnum");
        gameObject.GetComponent<Slider>().value = vNum;
    }

    public void OnChange()
    {
        vNum = GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("S5Vnum", vNum);
        PlayerPrefs.Save();
    }
}