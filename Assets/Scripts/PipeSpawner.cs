using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{   
    [SerializeField] GameObject pipe;
    [SerializeField] float spawnRate = 3;

    [SerializeField] float HEIGHT_OFFSET = 10f;
    [SerializeField] float ROTATE_OFFSET = 15f;
    private float lastRotateValue = 0.0f;
    private float timer = 0;
    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnPipe();
            transform.Rotate(new Vector3(0,0,-lastRotateValue));
            timer = 0;
        }


    }

    bool rotateOnZRandom() {
        float random = Random.Range(0.0f,2.0f);
        return true ? random > 0.6f : false;
    }

    void spawnPipe() {
        float lowestPoint = transform.position.y - HEIGHT_OFFSET;
        float highestPoint = transform.position.y + HEIGHT_OFFSET;
        if (rotateOnZRandom()){
            float rotateValue = Random.Range(ROTATE_OFFSET,-ROTATE_OFFSET);
            lastRotateValue = rotateValue;
            transform.Rotate(new Vector3(0,0,rotateValue));
        }

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint)), transform.rotation);
    }
}
