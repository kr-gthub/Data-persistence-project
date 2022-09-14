using System.Collections;
using System.Collections.Generic;
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

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
