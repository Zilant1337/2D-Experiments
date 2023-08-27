using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CloudMovement : MonoBehaviour

{
    System.Random rng = new System.Random();
    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = rng.Next(2,7);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
        CloudGeneration.cloudNumber -= 1;
    }
}
