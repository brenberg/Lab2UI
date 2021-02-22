using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverallSliderValue : MonoBehaviour
{
    public static bool startup;
    public static float timer;
    public GameObject transition;
    public Animator traAnimator;

    private void Start()
    {
        startup = false;
        //transition.SetActive(false);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);

        if (startup == true)
        {
            //transition.SetActive(true);
            PlayOutTransition();

            if (timer >= 3 && timer <= 3.5)
            {
                SceneManager.LoadScene(1);
                startup = false;
            }

            if (timer >= 10)
            {
                SceneManager.LoadScene(0);
                startup = false;
            }
        }
        
    }
    public void RotSliderChanged(float spin)
    {
        RotateWithSlider.spinValue = spin;
    }

    //public void PosSliderChanged(float spin)
    //{
    //    RotateWithSlider.spinValue = spin;
    //}

    public void SpeedSliderChanged(float speed)
    {
        RotateWithSlider.fallSpeed = speed;
    }

    public void StartGame()
    {
        startup = true;
        timer = 0;
    }

    public void PlayOutTransition()
    {
        traAnimator.GetComponent<Animator>().SetBool("StartGameTransition", true);
    }
}
