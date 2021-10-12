using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneWin : MonoBehaviour
{
    public GameObject Botones;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        StartCoroutine(spawnText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnText()
    {
        yield return new WaitForSeconds(3);
        Botones.SetActive(true);

    }

    public void VolverAMenu(string menu)
    {
        SceneManager.LoadScene(menu);
    }

    public void OtraNoche(string siguientenoche)
    {
        SceneManager.LoadScene(siguientenoche);
    }
}
