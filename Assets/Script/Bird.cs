using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Vector3 InitialPos;

    public float limitDis;
    private void Start()
    {
        InitialPos = transform.position;
    }
    private void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0; 

        float distance = (InitialPos - mousePos).magnitude;

        if(distance < limitDis) {
            transform.position = new Vector3(mousePos.x, mousePos.y);
        }
    }

    private void OnMouseUp()
    {
        Vector3 vectorPos = InitialPos - transform.position;
        GetComponent<Rigidbody2D>().AddForce(vectorPos * 400);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
