using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitching : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      float z = 3000;
      Rigidbody rigidbody = GetComponent<Rigidbody>();
      rigidbody.AddForce(0, 0, -z);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
