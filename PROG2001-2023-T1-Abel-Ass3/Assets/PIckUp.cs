using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIckUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision) {
        string name = collision.collider.name;
        print(name);
    }
}
