using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusScript : MonoBehaviour
{
    
    public GameObject cactus;
    private Animator animator;
    private float distance; 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isFighting", false);

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, cactus.transform.position);
        if (animator != null) {
            if (distance < 0.1f)
            {
                animator.SetBool("isFighting", true);
            } else
            {
                animator.SetBool("isFighting", false);
            }
        }
    }
}