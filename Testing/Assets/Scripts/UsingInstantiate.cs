using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform barrelEnd;
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelEnd.forward * 350f);
        }
          
    }
}