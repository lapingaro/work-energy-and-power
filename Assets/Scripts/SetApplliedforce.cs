using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetApplliedforce : MonoBehaviour
{
    [TextArea]
    public string _text;
    
    public float _characterInterval;

    string _partialText;
    float _cumulativeDeltatime;
    public static bool _showObjective;

    public static bool introOff;
    public static bool resultOf;
    
    public Animator AppliedAnim;
    public Image appliedForthound;
    private Color buttonColor;
    public bool animOn;






    Text _label;

    void Start()
    {
        StartText();
        _showObjective = false;
        //BoardText.SetActive(false);

       introOff=false;

        // set button color alpha
        buttonColor.a = 0;
        
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

    public void switchAnimOn()
    {

        animOn = true;

    }




    void Update()
    {
        

        if(_partialText.Length < _text.Length){

          
           TypeWriteText();
        }else if(_partialText.Length ==_text.Length){

        
         Invoke("EraseText",7f);
        
          
        }

        if (introOff)
        {
            AppliedAnim.enabled = true;
            appliedForthound.raycastTarget = true;
        }

        if (animOn)
        {
            AppliedAnim.enabled = false;
            appliedForthound.color = buttonColor;

        }


    }


    
}
