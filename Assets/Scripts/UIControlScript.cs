using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControlScript : MonoBehaviour
{
    public GameObject[] UIPages;
    // Start is called before the first frame update
    void Start()
    {
        ShowUI("UIStartPage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowUI(string UIPageName)
    {
        for (int i = 0; i < UIPages.Length; i++)
        {
            UIPages[i].SetActive(false);
            if (UIPages[i].name==UIPageName)
            {
                UIPages[i].SetActive(true);
               
            } 
            
                
            
        }
    }
}
