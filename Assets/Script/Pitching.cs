using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitching : MonoBehaviour
{
  private float timer = 0.0f;
  private float nextball = 1.0f;
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
        timer += Time.deltaTime;
      }
      if((timer >nextball) & next==1) {
        float s = 4000;//speed
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(0, 0, -s);//打ち出す

        timer = 0.0f;
        next = 0;
      }
    }
}
