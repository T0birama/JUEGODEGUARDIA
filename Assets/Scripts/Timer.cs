using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshPro timer;
    [Tooltip("Tiempo inicial en segundos")]
    public int TiempoInicial;

    [Tooltip("Escala del tiempo del reloj")]
    [Range(-10.0f,10.0f)]
    public float escalaDelTiempo = 1;

    public float tiempoDelFrameConTimeScale = 0f;
    public float tiempoAMostrarEnSegundos = 0f;
    public float escaladoDelTiempoAlPausar , escalaDelTimpoInicial;
    private bool estaPausado = false;
   
    
    public float tiempo = 75f;
    // Start is called before the first frame update
    void Start()
    {
        escalaDelTimpoInicial = escalaDelTiempo;
        timer.text = " " + tiempo;

        tiempoAMostrarEnSegundos = TiempoInicial;
        ActualizarReloj(TiempoInicial);
    }

    public void ActualizarReloj(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;    

        if(tiempoEnSegundos < 0) tiempoEnSegundos = 0; 

        minutos = (int)tiempoEnSegundos /60;
        segundos = (int)tiempoEnSegundos % 60;
        
        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        timer.text = textoDelReloj; 

        if(tiempoEnSegundos >= 360)
        {
            Pausar();
            StartCoroutine(Gameover());
        }
    }

    // Update is called once per frame
    void Update()
    {
        tiempoDelFrameConTimeScale = Time.deltaTime * escalaDelTiempo;
        tiempoAMostrarEnSegundos += tiempoDelFrameConTimeScale;
        ActualizarReloj(tiempoAMostrarEnSegundos);

    }

    public void Pausar()
    {
        if (!estaPausado)
        {
            estaPausado = true;
            escaladoDelTiempoAlPausar = escalaDelTiempo;
            escalaDelTiempo = 0;
        }
    }

    public void Continuar()
    {
        if (estaPausado)
        {
            estaPausado = false;
            escalaDelTiempo = escaladoDelTiempoAlPausar;
        }
    }

    public void ResetTimer()
    {
        estaPausado = false;
        escalaDelTiempo = escalaDelTimpoInicial;
        tiempoAMostrarEnSegundos = TiempoInicial;
        ActualizarReloj(tiempoAMostrarEnSegundos);
    }

    IEnumerator Gameover()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Niños");
    }
}
