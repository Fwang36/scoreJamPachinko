using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PegCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        gameObject.GetComponent<Renderer>().material.color= Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
