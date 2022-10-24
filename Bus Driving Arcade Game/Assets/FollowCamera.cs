using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject BusToFollow;
    //AddComponentMenu();
    //BusDriver busDriver = new BusDriver();
    //BusDriver
    // Camera should be same as bus's position.
       void Update()
    {
        transform.position = BusToFollow.transform.position + new Vector3(0, 0, -12.5f);
        transform.rotation = BusToFollow.transform.rotation;
        transform.Translate(0, 0, -10);
        transform.Rotate(-5, 0, 0);
    }
}
