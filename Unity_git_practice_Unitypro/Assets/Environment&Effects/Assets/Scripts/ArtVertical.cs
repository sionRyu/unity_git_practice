using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtVertical : MonoBehaviour
{
    [SerializeField]
    private GameObject topTransform;
    [SerializeField]
    private float angle_z;
    [SerializeField]
    private float maxRotation  = 40.0f;
    [SerializeField]
    private float minRotation  = 0.0f;


    private void GunSetVertical(float rotation_z)
    { 
        transform.rotation *= Quaternion.Euler(0,0,rotation_z);

    }

    private void Awake()
    {
        angle_z = 0.1f;
    }

    private void Update()
    {
        if (transform.rotation.z >= -1 && transform.rotation.z <= 40)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("up");
                GunSetVertical(angle_z);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Debug.Log("down");
                GunSetVertical(-angle_z);
            }
        }
        else
        {
            return;
        }
    }
}
