using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMotor : MonoBehaviour
{
   public Transform lookAt;
   float boundX = 7.00f;
   float boundY = 3.50f;

   private void LateUpdate()
   {
    Vector3 delta = Vector3.zero;
    float deltaX = lookAt.position.x - transform.position.x;
    float deltaY = lookAt.position.y - transform.position.y;
    if (deltaX > boundX || deltaX < -boundX)
    {
        if (lookAt.position.x < transform.position.x)
        {
            delta.x = lookAt.position.x - transform.position.x + boundX;
        }

          if (lookAt.position.x > transform.position.x)
        {
            delta.x = lookAt.position.x - transform.position.x - boundX;
        }
    }
    
       if (deltaY > boundY || deltaY < -boundY)
    {
        if (lookAt.position.y < transform.position.y)
        {
            delta.y = lookAt.position.y - transform.position.y + boundY;
        }

          if (lookAt.position.y > transform.position.y)
        {
            delta.y = lookAt.position.y - transform.position.y - boundY;
        }
    }
    transform.position += new Vector3(delta.x, delta.y, 0);
   }
}
