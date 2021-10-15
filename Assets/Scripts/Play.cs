using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class Play : MonoBehaviour
{
    public PlayableDirector faded;
    public GameObject Imagen;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        Imagen.SetActive(true);
        faded.Play();
        StartCoroutine(Faded());
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    IEnumerator Faded()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Guardia");
    }
}
