using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Swipe : MonoBehaviour
{

    public TMP_Text text;

    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if(endTouchPosition.x > startTouchPosition.x)
            {
                PageRight();
            }
            if(endTouchPosition.x < startTouchPosition.x)
            {
                PageLeft();
            }
        }
    }

    void PageRight()
    {
        int num = Int32.Parse(text.text);
        num += 1;
        text.text = num.ToString();
    }
    void PageLeft()
    {
        int num = Int32.Parse(text.text);
        num -= 1;
        text.text = num.ToString();
    }
}
