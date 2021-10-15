using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameOvermanager : MonoBehaviour
{
    public PlayableDirector TimelineText;
    public GameObject Botones;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        TimelineText.Play();
        StartCoroutine(TiempoDeNo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TiempoDeNo()
    {
        yield return new WaitForSeconds(4);
        Botones.SetActive(true);
        
    }

    public void VolverALmenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void JugarDeNuevo()
    {
        SceneManager.LoadScene("Guardia");
    }
    public void QUIT()
    {
        Application.Quit();
    }
}
