using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudEffects : MonoBehaviour
{
    [SerializeField] float cloudSpeed = 1;
    
    // Update is called once per frame
    void Update()
    {
        cloudSpeed += 0.01f;
        transform.position = new Vector3(20 * cloudSpeed, 75, -60.5f);
    }
}
