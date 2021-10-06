using System;

using UnityEngine;


public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;
    public GameObject Player;
    public Rigidbody rb;  
   
    public GameObject[] AllCars;
    public LevelsData[] AllLevels;
    public GameObject CurrentCar;
    public GameObject CurrentStartPoint;
    public GameObject CurrentEndPoint;
   
    public GameObject RacingStartPoint,Racingstartpoint2;
    public GameObject[] Racingcars;
    private int SelectedLevelNO=0;
    public GameObject CompleatePanel;
 
    public GameObject FailPanel;
   
    public GameObject PausePanel;
    string Name;
   
   
    void Start()
    {  
        instance = this;
        Time.timeScale = 1.0f;
       
        AllLevels[SelectedLevelNO].LevelDesign.SetActive(true);
        CurrentStartPoint = AllLevels[SelectedLevelNO].StartPoint;
        CurrentEndPoint = AllLevels[SelectedLevelNO].EndPoint;
        CurrentCar = AllCars[0];
        CurrentCar.transform.position = CurrentStartPoint.transform.position;
        CurrentCar.transform.rotation = CurrentStartPoint.transform.rotation;
        CurrentCar.SetActive(true);
        RacingStartPoint = AllLevels[SelectedLevelNO].RacingcarStartPoint;
        Racingstartpoint2 = AllLevels[SelectedLevelNO].RacingcarStartPoint2;
        Racingcars[0].transform.position = RacingStartPoint.transform.position;
        Racingcars[0].transform.rotation = RacingStartPoint.transform.rotation;
        Racingcars[0].SetActive(true);       
    }
    Predator0
    public void Failedlevel()
       { 
                  
         FailPanel.SetActive(true);
                      
        }

    https://github.com/Shoaibunity/Shooting-Games
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
    
  
   


[Serializable]
public class LevelsData
{
    public GameObject LevelDesign;
    public GameObject StartPoint;
    public GameObject RacingcarStartPoint;
    public GameObject RacingcarStartPoint2;
    public GameObject EndPoint;
    

}

