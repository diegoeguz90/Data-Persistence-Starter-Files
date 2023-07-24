using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandlerUI : MonoBehaviour
{
    public TMP_InputField nickNameInputTxt;
    public string nickName;

    // singleton 
    public static MenuHandlerUI instance;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void startGame()
    {
        nickName = nickNameInputTxt.text;
        SceneManager.LoadScene(1);
    }
}
