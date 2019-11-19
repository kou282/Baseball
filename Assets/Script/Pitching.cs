using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitching : MonoBehaviour
{
  private float time = 0.0f;
  private float nextball = 1.5f;
  public static int  next = 0;
    // Start is called before the first frame update
    void Start()
    {
      next = 1;
    }

    // Update is called once per frame
    void Update()
    {
      if(next==1){
        time += Time.deltaTime;
      }
      if((time　>nextball) & next==1) {
        float s = Random.Range(4000,8000);//speed
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(0, 0, -s);//打ち出す

        time = 0.0f;
        next = 0;
      }
      if(OutCount.outCount==3){
        next = 0;
      }
    }
}
