using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene5 : MonoBehaviour
{
    public void Pressed_Fightbtn()
    {
        SceneManager.LoadScene("FightScene1");
    }
}
