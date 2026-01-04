using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScenes : MonoBehaviour
{
    public bool istwo = false;
    public Button bt1;
    public Button bt2;
    // Start is called before the first frame update
    void Start()
    {
        bt2.interactable = false;
        bt1.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(istwo = false){
           bt2.interactable = false; 
           bt1.interactable = true;
        }
        if(istwo = true){
           bt2.interactable = true; 
           bt1.interactable = false; 
        }
        
    }
    public void OnLevel1Click(){
        SceneManager.LoadScene("Advanture1");
        istwo = true;
    }
    public void OnLevel2Click(){
        SceneManager.LoadScene("Advanture2");
    }
}
