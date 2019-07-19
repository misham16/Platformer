using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move4 : MonoBehaviour
{
    
      void Update()
    {
        transform.position = new Vector2 (transform.position.x, Mathf.PingPong(Time.time, 3));
    }
}
