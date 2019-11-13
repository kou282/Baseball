using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batting : MonoBehaviour
{
  int a =10;//angle
  int a_sum = 0;//angle sum

    void Start()
    {
        }

    void Update()
    {
      if(Input.GetMouseButton(0)&&  a_sum < 120){
      transform.Rotate(0,-a,0);
      a_sum += a;
    }else if(!Input.GetMouseButton(0)&& a_sum !=0){
      transform.Rotate(0, a, 0);
      a_sum -= a;
    }
  }
}
