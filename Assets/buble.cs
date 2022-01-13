using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce((collision.transform.position - transform.position) * 5, ForceMode.Impulse);
    }
}
