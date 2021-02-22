using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimations : MonoBehaviour
{
    public static GameObject PlayerAnim;
    public static float i;
    public static bool boolCheck;
    public AudioSource hitSound;

    void Start()
    {
        PlayerAnim = gameObject;
        boolCheck = false;
    }

    void Update()
    {
        i += Time.deltaTime;

        if(boolCheck == true)
        {
            hitSound.Play();
        }

        if (i >= 0.5f && boolCheck == true)
        {
            HurtAnimFalse();
            boolCheck = false;
        }
    }

    public static void HurtAnimTrigger()
    {
        //Debug.Log("TRIGGER");
        PlayerAnim.GetComponent<Animator>().SetBool("HurtBool", true);
        boolCheck = true;
        i = 0;
    }

    public static void HurtAnimFalse()
    {
        PlayerAnim.GetComponent<Animator>().SetBool("HurtBool", false);
    }
}
