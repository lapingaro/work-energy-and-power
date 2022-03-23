using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterIntro : MonoBehaviour
{
    [TextArea]
    public string _text;
    
    public float _characterInterval;

    string _partialText;
    float _cumulativeDeltatime;
    public static bool _showObjective;

    public static bool introOff;
    public static bool resultOf;
    public GameObject BoardText;
    
    
   
   
     

    Text _label;

    void Start()
    {
        StartText();
        _showObjective = false;
        BoardText.SetActive(false);

       introOff=false;
        
    }

    void Awake()
    {
        _label = GetComponent<Text>();
    }

    void StartText()
    {
        _partialText = "";
        _cumulativeDeltatime = 0;
    }

    void TypeWriteText()
    {
        _cumulativeDeltatime += Time.deltaTime;

        while (_cumulativeDeltatime >= _characterInterval &&
            _partialText.Length < _text.Length)
        {
            _partialText += _text[_partialText.Length];
            _cumulativeDeltatime -= _characterInterval;
        }

        _label.text = _partialText;
    }

    void EraseText()
    {
        _label.text = "";
        introOff=true;
       
        
    }

  
    

    void Update()
    {
        

        if(_partialText.Length < _text.Length){

          
           TypeWriteText();
        }else if(_partialText.Length ==_text.Length){

        
         Invoke("EraseText",7f);
        
          
        }
           
      if(introOff){

         BoardText.SetActive(true);
        

      }
      
        
    }


    
}
