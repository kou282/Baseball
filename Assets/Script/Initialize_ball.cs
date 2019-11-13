using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize_ball : MonoBehaviour
{
  private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision){
      if(collision.gameObject.tag!="Bat" & collision.gameObject.tag!="Ground"){//BatとGround以外に触れた時
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = new Vector3(0.3f, 0.5f, -25f);
        Pitching.next=1;
      }
    }
}
