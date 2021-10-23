using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public void StartGameNow()
    {
        SceneManager.LoadScene("BasicMovement");
    }

    public void TestConnect()
    {
        SocketManager socketManager = new SocketManager();
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
