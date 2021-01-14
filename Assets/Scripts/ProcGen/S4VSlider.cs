using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S4VSlider : MonoBehaviour
{
    public static S4VSlider instance;

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

        vNum = PlayerPrefs.GetFloat("S4Vnum");
        gameObject.GetComponent<Slider>().value = vNum;
    }

    public void OnChange()
    {
        vNum = GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("S4Vnum", vNum);
        PlayerPrefs.Save();
    }
}
