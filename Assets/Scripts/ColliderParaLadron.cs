using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ColliderParaLadron : MonoBehaviour
{
    public GameObject InterfaceParaAtrapar;
    public GameObject TimerParaAtrapar;
    public GameObject TextoParaAtrapar;
    public GameObject Alarma;
    public int TiempoParaAtrapar;
    bool EstaLadron;
    
    public GameObject LinternaCollider;
    public Enemy enemy;
    public GameObject luzDePuerta;
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
                luzDePuerta.SetActive(true);
                Alarma.SetActive(true);
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
        Alarma.SetActive(false);
        luzDePuerta.SetActive(false);
        Debug.Log("luzApagada");
    }




}
