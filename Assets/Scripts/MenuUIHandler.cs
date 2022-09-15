using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TMPro.TMP_InputField usernameText;

    // Start is called before the first frame update
    void Start()
    {
        usernameText.text = PersistenceManager.INSTANCE.userName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNameChanged(string value)
    {
        Debug.Log(value);
        PersistenceManager.INSTANCE.userName = value;
        PersistenceManager.INSTANCE.score = 0;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
