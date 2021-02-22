using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateWithSlider : MonoBehaviour
{
    public static float spinValue;
    public static float fallSpeed;
    float RandYRot;
    void Start()
    {
        RandYRot = Random.Range(0, 360);
        transform.position = new Vector3(Random.Range(-9, 9), transform.position.y + Random.Range(3, 6), -1.7f);
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, RandYRot);
    }

    void Update()
    {
        transform.position = transform.position + (new Vector3(0, 0 + fallSpeed, 0));

        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, RandYRot + spinValue);

        fallSpeed -= (Time.deltaTime / 10000);

        //if (spinValue >= 0.01)
        //{
        //    transform.Rotate(0, 0, -0.1f + spinValue/10f);
        //}

        //if (spinValue <= -0.01)
        //{
        //    transform.Rotate(0, 0, 0.1f + spinValue/10f);
        //}

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log(spinValue);
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        //Debug.Log("Delete");
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("DAMAGE");
        playerAnimations.HurtAnimTrigger();
        healthScript.health -= 1;
        playerScript.partBool = true;
        Destroy(gameObject);
    }
}
