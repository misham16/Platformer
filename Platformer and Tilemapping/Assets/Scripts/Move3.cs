using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3 : MonoBehaviour
{
      void Update()
    {
        transform.position = new Vector2 (Mathf.PingPong(Time.time, 1) + 2, transform.position.y);
    }
}
