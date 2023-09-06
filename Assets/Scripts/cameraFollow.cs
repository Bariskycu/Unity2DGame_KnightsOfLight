using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    [SerializeField]
    private float xMax;

    [SerializeField]
    private float yMax;

    [SerializeField]
    private float xMin;
    
    [SerializeField]
    private float yMin;

    private Transform target;

    void Start()
    {
        target = GameObject.Find("Player_Level_1").transform;
    }

    
    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x,xMin,xMax),Mathf.Clamp(target.position.y,yMin,yMax),transform.position.z);
    }
}
