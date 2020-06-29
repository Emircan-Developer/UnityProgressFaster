using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Revenue : MonoBehaviour
{
    float Timer = 0;

    public List<Build> builds = new List<Build>();
    private int Money;
   
    void Start()
    {   Money = 36000;
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0;i<builds.Count;i++){
            if(builds[i].returnCount > 0 ){
              
               
                int sellTime = Random.Range(3,6);
                
                while(Timer <= sellTime){
                    Debug.Log(sellTime);
                   Timer += Time.deltaTime; 
              //  Debug.Log("Time " +Timer);

                }
                Money += builds[i].IncomePerSecond;

                  builds[i].returnCount--; 
        }
     //   Debug.Log("remaining Return " +builds[i].returnCount);
        Timer = 0;
        }
        
    }
    public int getMoney(){
        return Money;
    }
}
