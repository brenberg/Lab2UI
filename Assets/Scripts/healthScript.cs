using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
    public GameObject H1;
    public GameObject H2;
    public GameObject H3;
    public GameObject H4;
    public GameObject H5;
    public GameObject Player;
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(health);

        if (health <= 4)
        {
            H5.SetActive(false);
        }
        if (health <= 3)
        {
            H4.SetActive(false);
        }
        if (health <= 2)
        {
            H3.SetActive(false);
        }
        if (health <= 1)
        {
            H2.SetActive(false);
        }
        if (health == 0)
        {
            H1.SetActive(false);
            GameOver();
            health -= 1;

        }
    }

    void GameOver()
    {
        RotateWithSlider.fallSpeed = 0;
        OverallSliderValue.timer = 4;
        OverallSliderValue.startup = true;
        //PlayerAnimation
    }
}
