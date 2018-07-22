using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlow : MonoBehaviour
{
    [SerializeField]
    Vector3 flow;
    [SerializeField]
    float buoyancy = 11;
    [SerializeField]
    float decelerationRate = 0.5f;

    public void OnTriggerStay(Collider c)
    {
        if (c.attachedRigidbody != null)
        {
            Vector3 reduceSpd = c.attachedRigidbody.velocity * -decelerationRate;
            Vector3 force = Vector3.up * buoyancy + reduceSpd + flow;
            c.attachedRigidbody.AddForce(force, ForceMode.Force);
        }
    }
}
