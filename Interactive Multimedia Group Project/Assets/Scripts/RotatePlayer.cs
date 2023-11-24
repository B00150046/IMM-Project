using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigid;
    Vector3 lookPlus;
    void Start()
    {
        Rigidbody rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 100)){
            lookPlus = hit.point;
        }
        Vector3 lookNeg = lookPlus - transform.position;
        lookNeg.y = 0;

        transform.LookAt(transform.position + lookNeg, Vector3.up);
    }

    private void FixedUpdate(){
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = new Vector3(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;
    }
}
