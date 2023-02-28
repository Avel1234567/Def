using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsController3 : MonoBehaviour
{
    public GameObject star7, star8, star9;
    public static int open_star7, open_star8, open_star9;
    void Start()
    {
        PlayerPrefs.DeleteAll();
        open_star7 = PlayerPrefs.GetInt("stars7", 1);
        open_star8 = PlayerPrefs.GetInt("stars8", 1);
        open_star9 = PlayerPrefs.GetInt("stars9", 1);
    }

    void Update()
    {
        if (open_star7 == 1)
            star7.SetActive(false);
        if (open_star7 == 2)
            star7.SetActive(true);
        if (open_star8 == 1)
            star8.SetActive(false);
        if (open_star8 == 2)
            star8.SetActive(true);
        if (open_star9 == 1)
            star9.SetActive(false);
        if (open_star9 == 2)
            star9.SetActive(true);

        if (Stars3.Star3 >= 1)
            openStar7();
        if (Stars3.Star3 >= 2)
            openStar8();
        if (Stars3.Star3 >= 3)
            openStar9();
    }

    /*public void ResetStats()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("123");
    }*/

    public void openStar7()
    {
        open_star7 = 2;
        PlayerPrefs.SetInt("stars7", open_star7);
    }
    public void openStar8()
    {
        open_star8 = 2;
        PlayerPrefs.SetInt("stars8", open_star8);
    }
    public void openStar9()
    {
        open_star9 = 2;
        PlayerPrefs.SetInt("stars9", open_star9);
    }
}
