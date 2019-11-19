using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Defense : MonoBehaviour
{
  // Start is called before the first frame update
  private float x;
  private float x_sum = 0.0f;
  private float x_max = 6.0f;
  private float defense_x;
  private float defense_y;
  private float defense_z;
  private bool direction;

  // Use this for initialization
  void Start () {
    Vector3 defense = GameObject.Find(transform.name).transform.position;
    defense_x = defense.x;
    defense_y = defense.y;
    defense_z = defense.z;

    direction = Random.Range(0,2) == 0;
    x = Random.Range(0.1f,0.4f);
  }

  // Update is called once per frame
  void Update () {

    if (direction && Mathf.Abs(x_sum) < x_max) { // ＋方向,Mathf.Abs()は絶対値を返すやつ
      transform.position = new Vector3(defense_x+x_sum,defense_y,defense_z);
      x_sum += x;
    } else if (!direction && Mathf.Abs(x_sum) < x_max) { // ー方向
      transform.position = new Vector3(defense_x+x_sum,defense_y,defense_z);
      x_sum -= x;
    } else {

      if(direction){
        x_sum -= x;
      } else {
        x_sum += x;
      }
      direction = !direction;

    }

  }
}
