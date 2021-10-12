using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    Animator anim;
    private NavMeshAgent agent;
    private GameObject target;
    // Start is called before the first frame update
    private void OnEnable()
    {
        anim = gameObject.GetComponent<Animator>();
        target = GameObject.Find("Doc");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        agent.SetDestination(target.transform.position);
        
        float Dist = Vector3.Distance(target.transform.position, this.transform.position);

        if(Dist <= 2.0f)
        {
            anim.SetBool("stopped",true);
        }
        else
        {
            anim.SetBool("stopped",false);
        }
        
        
    }
}
