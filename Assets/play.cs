using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public void buttonUp()
    {
        SceneManager.LoadScene("2D_Game");
    }
}
