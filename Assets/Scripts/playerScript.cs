using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    public GameObject Player;
    public bool colorGreen;
    public bool colorBlue;
    public Material green;
    public Material blue;
    [SerializeField] ParticleSystem SmokeTrail = null;
    public static bool partBool;
    public AudioSource flySound;
    public float multValue = 1.02f;

    // Start is called before the first frame update
    void Start()
    {
        colorGreen = true;
        colorBlue = false;
        flySound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        flySound.pitch = RotateWithSlider.fallSpeed * -10 + multValue;

        if (partBool == true)
        {
            Collect();
        }
    }

    public void PlayerSliderChanged(float newValue)
    {
        Vector3 pos = transform.position;
        pos.x = newValue;
        transform.position = pos;
    }

    public void ButtonisPressed()
    {
        if (colorGreen == true)
        {
            Player.GetComponent<MeshRenderer>().material = blue;
            colorGreen = false;
            colorBlue = true;
        }

        else if (colorBlue == true)
        {
            Player.GetComponent<MeshRenderer>().material = green;
            colorBlue = false;
            colorGreen = true;
        }
    }
    
    public void Collect()
    {
        SmokeTrail.Play();
        partBool = false;
    }
}
