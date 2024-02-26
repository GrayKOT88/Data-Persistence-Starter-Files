using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUICanvas : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
