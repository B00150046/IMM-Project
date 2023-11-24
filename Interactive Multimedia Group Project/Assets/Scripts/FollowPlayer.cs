using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour

{
    public GameObject plane;
    private Vector3 off;

    // Start is called before the first frame update
    void Start()
    {
        off = transform.position - plane.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + off;
    }
}

