using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batting : MonoBehaviour
{
  private int a =-9;//angle
  private int a_sum = 0;//angle sum

    void Start()
    {
        }

    void Update()
    {
      if(Input.GetMouseButton(0)&&  a_sum < 120){//マウス押下かつ角度が120未満
      transform.Rotate(0,a,0);//バットを奥に回転させる
      a_sum -= a;//回転した分を記録
    }else if(!Input.GetMouseButton(0)&& a_sum !=0){//マウス押下してないかつ回転した
      transform.Rotate(0, -a, 0);//元の位置に向かって回転した分だけ戻す
      a_sum += a;//元の位置に戻った分引く
    }
  }
}
