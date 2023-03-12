using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassPipeContoller : MonoBehaviour
{   
    [SerializeField] LogicManager logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.layer == 3){
            logic.addScore(1);
        }
    }
}
