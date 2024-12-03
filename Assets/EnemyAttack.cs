using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Animator animator;
    Movement player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("attack", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("attack", false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Vector3 ignoreY = player.transform.position;
            ignoreY.y = transform.position.y;
            transform.LookAt(ignoreY);
        }
        
    }
}
