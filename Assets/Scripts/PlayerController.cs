using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    Vector2 lastClickPos;
    bool moving;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            lastClickPos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if(moving && (Vector2)transform.position != lastClickPos)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickPos, step);
        }

        else
        {
            moving= false;
        }
    }


}
