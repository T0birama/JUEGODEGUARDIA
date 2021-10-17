using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    Animator anim;
    public GameObject Grito;
    public PlayableDirector LinternaTimeline;
    private NavMeshAgent agent;
    private GameObject target;
    private GameObject EscapeTarget;
    public GameObject Ladron;
    public bool EstaPlayer = false;
    // Start is called before the first frame update
    private void OnEnable()
    {
        anim = gameObject.GetComponent<Animator>();
        target = GameObject.Find("Doc");
        EscapeTarget = GameObject.Find("Escape");
        
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    
    void Update()
    {

       if (!target.activeSelf)
       {
            target = GameObject.Find("Doc");
       }



        agent.SetDestination(target.transform.position);
        if (target.activeSelf == false)
        {
            agent.SetDestination(target.transform.position);
        }

        if(EstaPlayer== true)
        {
            SceneManager.LoadScene("Gameover");
        }
        
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

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Linterna"))
        {
             LinternaTimeline.Play();
            anim.SetBool("Atrapado" ,true);
            StartCoroutine(OtravesEnemy());
        }

        if (other.CompareTag("Escape"))
        {
            anim.SetBool("escape",false);
            StartCoroutine(ladronDes());
            Grito.SetActive(false);
        }

    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            EstaPlayer = true;
        }
    }

    public void EstaAtrapado()
    {
        agent.speed = 0.0f;
        anim.SetBool("Atrapado", true);
        EstaPlayer = false;
    }

    public void MasRapida()
    {
        agent.speed = 4.0f;
    }

    IEnumerator OtravesEnemy()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("escape",true);
        target = EscapeTarget;
        agent.SetDestination(target.transform.position);
        agent.speed = 7.0f;
        Grito.SetActive(true);
        


        
    }
    IEnumerator ladronDes()
    {
        yield return new WaitForSeconds(2);
        agent.speed = 3.5f;
        
        Ladron.SetActive(false);
    }

}
