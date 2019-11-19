using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
  AudioSource Bgm;
    // Start is called before the first frame update
    void Start()
    {
      Bgm= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      if(OutCount.outCount==3){
        Bgm.Stop();
      }
    }
}
