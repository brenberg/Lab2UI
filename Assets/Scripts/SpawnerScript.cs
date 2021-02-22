using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject PassArchOb;
    public GameObject ArchOb;
    public GameObject Wall;
    float i;
    public float spawnHeight;
    public float randTime;
    public float timeCheck;
    public float randObject;

    // Start is called before the first frame update
    void Start()
    {
        spawnHeight = 15f;
        randTime = Random.Range(4, 8);
        randObject = Random.Range(1, 4);
        Instantiate(PassArchOb, new Vector3(0, spawnHeight, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        i += Time.deltaTime;

        timeCheck = randTime + (RotateWithSlider.fallSpeed * 100);

        if (timeCheck <= 0 && i > randTime)
        {
            InstantiateThem2();
        }

        if (timeCheck >= 0 && i > timeCheck)
        {
            InstantiateThem();
        }
    }

    void InstantiateThem()
    {
        if(randObject >= 1 && randObject < 2)
        {
            Instantiate(PassArchOb, new Vector3(0, spawnHeight, 0), Quaternion.identity);
        }
        if (randObject >= 2 && randObject < 3)
        {
            Instantiate(Wall, new Vector3(0, spawnHeight, 0), Quaternion.identity);
        }
        if (randObject >= 3 && randObject < 4)
        {
            Instantiate(ArchOb, new Vector3(0, spawnHeight, 0), Quaternion.identity);
        }
        if (randObject >= 4 && randObject < 5)
        {
            Instantiate(Wall, new Vector3(0, spawnHeight, 0), Quaternion.identity);
        }

        randTime = Random.Range(4, 8);
        randObject = Random.Range(1, 4);
        i = 0;
    }

    void InstantiateThem2()
    {
        if (randObject >= 1 && randObject < 2)
        {
            Instantiate(PassArchOb, new Vector3(0, spawnHeight, 0), Quaternion.identity);
        }
        if (randObject >= 2 && randObject < 3)
        {
            Instantiate(Wall, new Vector3(0, spawnHeight, 0), Quaternion.identity);
        }
        if (randObject >= 3 && randObject < 4)
        {
            Instantiate(ArchOb, new Vector3(0, spawnHeight, 0), Quaternion.identity);
        }
        if (randObject >= 4 && randObject < 5)
        {
            Instantiate(Wall, new Vector3(0, spawnHeight, 0), Quaternion.identity);
        }

        randTime = Random.Range(0.5f, 2);
        randObject = Random.Range(1, 4);
        //randTime = 2.4567f;
        i = 0;
    }
}
