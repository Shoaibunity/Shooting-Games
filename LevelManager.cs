using System;

using UnityEngine;


public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;
   
    public GameObject CompleatePanel;
   
    public GameObject PausePanel;
    string Name;
    public int enemiesLeft;

    void Start()
    {  
        instance = this;
        Time.timeScale = 1.0f;
       
        
    }
    



    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Target");
        enemiesLeft = enemies.Length;
        if (enemiesLeft == 0)
        {
           Completelevel();
        }
    }



    public void Completelevel()
       {
 

          CompleatePanel.SetActive(true);             
            
        }



    public void Handlepanels(string name)
    {
        Name = name;
        switch (Name)
        {
            case "OnRestart":
            Application.LoadLevel(Application.loadedLevel);
            break;

            case "OnPause":
            PausePanel.SetActive(true);
            Time.timeScale = 0.0f;
             break;

            case "OnResume":
        
            Time.timeScale = 1.0f;
            PausePanel.SetActive(false);
             break;

             case "OnQuit":
             Application.Quit();
             break;

        }
        }


    }
    
  
   




