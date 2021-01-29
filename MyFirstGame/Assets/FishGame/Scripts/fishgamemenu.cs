using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fishgamemenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void play () {
        SceneManager.LoadScene(3);
        //SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    public void quit () {
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene(2);
    }
}
