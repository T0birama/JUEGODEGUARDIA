using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ColliderParaLadron : MonoBehaviour
{
    public GameObject InterfaceParaAtrapar;
    public GameObject TimerParaAtrapar;
    public GameObject TextoParaAtrapar;
    public int TiempoParaAtrapar;
    bool EstaLadron;
    public PlayableDirector TimelinePuertas;
    public GameObject LinternaCollider;
    public Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EstaLadron == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                TimerParaAtrapar.SetActive(true);
                TextoParaAtrapar.SetActive(true);
                LinternaCollider.SetActive(true);
                TimelinePuertas.Play();
                enemy.EstaAtrapado();
                
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ladron"))
        {
            EstaLadron = true;
            InterfaceParaAtrapar.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ladron"))
        {
            EstaLadron = false;
            InterfaceParaAtrapar.SetActive(false);
        }
    }

    public void TimeLinePuertas()
    {
        TimelinePuertas.Stop();
    }




}
