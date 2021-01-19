using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRotation : MonoBehaviour
{

    float angle;
    float stopAngle;
    Vector2 target, mouse;
    Color color;


    private void Start()
    {
        target = transform.position;
    }
    private void Update()
    {
        disappear();

        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        //this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        if (Input.GetMouseButtonDown(0))
        {
            stopAngle = angle;
            this.transform.rotation = Quaternion.AngleAxis(stopAngle - 90, Vector3.forward);
        }


    }
   

    public void disappear()
    {
        SpriteRenderer spr = GetComponent<SpriteRenderer>();
        Color color = spr.color;
        color.a = 0f;
        spr.color = color;

    }
}
