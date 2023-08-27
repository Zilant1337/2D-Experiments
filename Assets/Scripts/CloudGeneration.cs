using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneration : MonoBehaviour
{


    public static int cloudNumber = 0;
    public int maxAmountOfClouds;
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject cloud3;
    private List<GameObject> clouds = new List<GameObject>(3);
    private System.Random rng = new System.Random();
    
    // Start is called before the first frame update
    void Start()
    {
        clouds.Add(cloud1);
        clouds.Add(cloud2);
        clouds.Add(cloud3);
    }

    // Update is called once per frame
    void Update()
    {
        if (cloudNumber < maxAmountOfClouds)
        {
            Instantiate(clouds[rng.Next(0, 3)], new Vector2(this.transform.position.x, this.transform.position.y+rng.Next(-4, 4)), Quaternion.identity);
            cloudNumber += 1;
        }
    }
}
