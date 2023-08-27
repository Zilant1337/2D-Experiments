using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikeGeneration : MonoBehaviour
{
    public static int mikeNum = 0;
    public int maxAmountOfMike;
    public GameObject mike;
    private System.Random rn = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mikeNum < maxAmountOfMike)
        {
            Instantiate(mike, new Vector2(this.transform.position.x + rn.Next(-5, 6), this.transform.position.y), Quaternion.identity);
            mikeNum += 1;
        }
    }
}
