using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{

    float speed;

    void Start()
    {
        speed = Game.instance.gameSpeed;
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed);
    }
}
