using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform[] targets;
    [SerializeField] private float speed;

    private GameObject target;
    private int i = 0;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        target = targets[i].gameObject;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        transform.LookAt(target.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Target"))
        {
            i++;

            if (i > 5)
            {
                i = targets.Length - 1;
                animator.SetBool("Idle", true);
            }
        }

        if (i == 2) animator.SetBool("Jump", true);
        else animator.SetBool("Jump", false);
    }
}
