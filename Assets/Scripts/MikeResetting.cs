using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikeResetting : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
        MikeGeneration.mikeNum -= 1;
    }
}

