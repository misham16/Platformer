using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{

      void Update()
    {
        transform.position = new Vector2 (Mathf.PingPong(Time.time, 2) - 2, transform.position.y);
    }
}
