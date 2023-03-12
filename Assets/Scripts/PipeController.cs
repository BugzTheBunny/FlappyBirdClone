using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 5f;
    private float deadZone = -45f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }


}
