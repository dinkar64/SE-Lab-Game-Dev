﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void playgame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
        //SceneManager.LoadScene(2);
    }

    public void goback () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1 );
        //SceneManager.LoadScene(2);
    }
}
