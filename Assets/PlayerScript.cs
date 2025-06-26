using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = FindObjectOfType<Canvas>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
