using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Defense : MonoBehaviour
{
  // Start is called before the first frame update
  private bool d_positive;
  private float x;
  private float x_sum = 0.0f;
  private float x_max = 6.0f;
  private float defense_x;
  private float defense_y;
  private float defense_z;

  // Use this for initialization
  void Start () {
    Vector3 defense = GameObject.Find(transform.name).transform.position;
    defense_x = defense.x;
    defense_y = defense.y;
    defense_z = defense.z;

    d_positive = Random.Range(0,2) == 0;
    x = Random.Range(0.1f,0.2f);
  }

  // Update is called once per frame
  void Update () {

    if (d_positive && Mathf.Abs(x_sum) < x_max) { // Move positive direction
      transform.position = new Vector3(defense_x + x_sum, defense_y, defense_z);
      x_sum += x;
    } else if (!d_positive && Mathf.Abs(x_sum) < x_max) { // Move negative direction
      transform.position = new Vector3(defense_x + x_sum, defense_y, defense_z);
      x_sum -= x;
    } else {

      if(d_positive){
        x_sum -= x;
      } else {
        x_sum += x;
      }
      d_positive = !d_positive;

    }

  }
}
