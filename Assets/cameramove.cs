using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    Vector3 offset;
    void Start()
    {
        offset = transform.position -  target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newpos = target.transform.position + offset;
        transform.position = newpos;
    }
}
