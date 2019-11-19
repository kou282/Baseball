using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutCount : MonoBehaviour
{
  public static int outCount=0;
  public static int strikeCount=0;
  public static int strikeOut=0;
    // Start is called before the first frame update
    void Start()
    {
        outCount=0;
        strikeCount=0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Defense" || collision.gameObject.tag == "Fineplay") {
      outCount += 1;
      strikeCount=0;
      strikeOut=0;
    }else if(collision.gameObject.tag == "Foul"){
      strikeCount+=1;
      strikeOut=0;
    }else if(collision.gameObject.tag == "Single" || collision.gameObject.tag == "Double" || collision.gameObject.tag == "Triple" || collision.gameObject.tag == "Homerun"){
      strikeCount=0;
      strikeOut=0;
    }
      if(strikeCount==3){
        outCount +=1;
        strikeCount=0;
        strikeOut=1;
      }
    }
}
