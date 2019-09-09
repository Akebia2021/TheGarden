using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "SplashScreen")
        {
            StartCoroutine(LoadStartFromSplash());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    IEnumerator LoadStartFromSplash()
    {
        yield return new WaitForSeconds(3f);
        LoadStartScene();
      
    }
}
