using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{

      void Update()
    {
        transform.position = new Vector2 (Mathf.PingPong(Time.time, 2) + 3.5f, transform.position.y);
    }
}
