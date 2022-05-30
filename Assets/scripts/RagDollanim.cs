using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDollanim : MonoBehaviour
{
    private Rigidbody[] rb_AR;
    private float timer = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb_AR = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rb_AR)
        {
            rb.isKinematic = true;
        }
    }

    void Update()
    {
        if (timer <= 0)
        {
            Ragdoll_ON();
        }
        else
        {
            timer -= Time.deltaTime;
        }

    }

    void Ragdoll_ON()
    {
        foreach (Rigidbody rb in rb_AR)
        {
            rb.isKinematic = false;
            GetComponent<Animator>().enabled = false;
        }
    }
}
