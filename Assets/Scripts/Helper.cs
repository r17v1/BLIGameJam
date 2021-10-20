using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{
    public static float VelocityToAngle(Vector2 velocity)
    {
        velocity = velocity.normalized;
        float x = velocity.x;
        float y = velocity.y;
        float angle=0;
        if (x != 0 && y != 0)
        {
            float aa = Mathf.Rad2Deg * Mathf.Atan(Mathf.Abs(y) / Mathf.Abs(x));

            if (x > 0 && y > 0)
                angle = aa;
            else if (x < 0 && y > 0)
                angle = 180 - aa;
            else if (x < 0 && y < 0)
                angle = 180 + aa;
            else angle = -aa;
        }
        else if (y != 0)
        {
            angle = y > 0 ? 90f : -90f;
        }
        else if (x != 0)
        {
            angle = x > 0 ? 0f : 180f;
        }

        return angle;
    }
}
