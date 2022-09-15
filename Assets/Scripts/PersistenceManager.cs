using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PersistenceManager : MonoBehaviour
{
    public static PersistenceManager INSTANCE;

    public string userName;
    public int score;

    private void Awake()
    {
        if(INSTANCE != null)
        {
            Destroy(gameObject); 
            return;
        }
        INSTANCE = this;
        DontDestroyOnLoad(gameObject);
        LoadBestScore();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]
    class SaveData
    {
        public string username;
        public int score;
    }

    public void SaveBestScore()
    {
        SaveData data = new SaveData();
        data.username = userName;
        data.score = score;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/saveFile.json", json);
        Debug.Log(Application.persistentDataPath);
    }

    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/saveFile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            userName = data.username;
            score = data.score;
        }
    }
}
