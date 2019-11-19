using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize_ball : MonoBehaviour
{
  private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision){
      if(collision.gameObject.tag!="Bat" & collision.gameObject.tag!="Ground" &collision.gameObject.tag!="Runner"){//BatとGround以外に触れた時
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
        transform.position = new Vector3(0.3f, 0.5f, -25f);
        Pitching.next=1;
      }
    }
}
