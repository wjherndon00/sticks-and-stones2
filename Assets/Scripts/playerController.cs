using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    Animator animator;
    public float speed;
    public float orderinlayer;
    public SpriteRenderer sr;

    private void Start()
    {
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(1))
        {
            animator.SetBool("walking", true);
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = transform.position.z;
            transform.position = Vector3.MoveTowards(transform.position, mousePosition, speed);
        }
        else
        {
            animator.SetBool("walking", false);
        }
    }

    public void ChangePlayerOrderInLayer(int so)
    {
        sr.sortingOrder = so;
    }
}
