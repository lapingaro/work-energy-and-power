using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class DisplayQA : MonoBehaviour
{
    public Text questionDispla;
	public Text QDis;
	public Text QDis2;
	public Text QDis3;
	public Text QDis4;
	
	public TextAsset questionText;
	
	
	public int currentLine1;
	public int endAtLine1;
	public string[] textlines1;
	public List<string> stringList1 = new List<string> ();
	
	public TextAsset possibleAnswers;
	
	public int currentLine2;
	public int endAtLine2;
	public string[] textlines2;
	public List<string> stringList2 = new List<string> ();
	
	
	
	public TextAsset textFile3;
	public string[] textlines3;
	public int currentLine3;
	public int endAtLine3;
	public List<string> stringList3 = new List<string> ();
	
	public Toggle Q1;
	public Toggle Q2;
	public Toggle Q3;
	public Toggle Q4;
	
	public int questionNum=1;
	
	public string answ;
	public string sHolder;
	public string selectedAns;
	
	public string Answer;
	public string nme;
	
	public int scoreCount =0;
	public Text scoreC;
	
	public	bool veri;
	
	public GameObject queScene;
	public GameObject scoScene;
	
	public Text finalScore;
	
	public float timeLeft = 0f;
	public Text timerText;
	// Start is called before the first frame update
    void Start(){
        loadQuestion();
		loadPossiAnswers();
		loadAnswers();
		answAssign(1);
		updateQuestion(1);
		questionDisplay(1);
		
		timeLeft = 0f;
}

    // Update is called once per frame
    void Update()
    {
       // updateQuestion(questionNum);
	   questionDisplay(questionNum);
	   //	eAnsw(questionNum); 
	   answAssign(questionNum);
	   
	   timerFunction();
    }
	
//////////////////////////////////////////////////////////////////
	
	void loadQuestion()
	{
			//Load file , separte line
	if(questionText != null)
		{
			textlines1= (questionText.text.Split('\n'));
		}

	if(endAtLine1==0)
		{
			endAtLine1=textlines1.Length-1;
		}
	
	
	if(currentLine1<0)
		{
			currentLine1=0;
		}

	}
	
///////////////////////////////////////////////////////////////////	
	
	void loadPossiAnswers(){
		
			//Load file , separte line
	if(possibleAnswers != null)
		{
			textlines2= (possibleAnswers.text.Split('\n'));
		}

	if(endAtLine2==0)
		{
			endAtLine2=textlines2.Length-1;
		}
	
	
	if(currentLine2<0)
		{
			currentLine2=0;
		}

		
		
	}
	
///////////////////////////////////////////////////////////////////	

public void NextQ()//Question counter
	{
		questionNum=questionNum+1;

	}
//////////////////////////////////////////////////////
public void cong(){
	
	NextQ();
	updateQuestion(questionNum);
	questionDisplay(questionNum);

	
	
}



///////////////////////////////////////////////////////////////
	
public void updateQuestion(int QNum){
		string dialog;
	
		dialog = textlines1[QNum-1];
		questionDispla.text = dialog;
	
	
	}	
///////////////////////////////////////////////////////////////////

public void questionDisplay(int qNum){


if(qNum ==1){
	
			QDis.text=textlines2[currentLine2];
			QDis2.text=textlines2[currentLine2+1];
			QDis3.text=textlines2[currentLine2+2];
			QDis4.text=textlines2[currentLine2+3];
	
}

if(qNum ==2){
	
			QDis.text=textlines2[currentLine2+4];
			QDis2.text=textlines2[currentLine2+5];
			QDis3.text=textlines2[currentLine2+6];
			QDis4.text=textlines2[currentLine2+7];
	
}

if(qNum ==3){
	
			QDis.text=textlines2[currentLine2+8];
			QDis2.text=textlines2[currentLine2+9];
			QDis3.text=textlines2[currentLine2+10];
			QDis4.text=textlines2[currentLine2+11];
	
}
if(qNum ==4){
	
			QDis.text=textlines2[currentLine2+12];
			QDis2.text=textlines2[currentLine2+13];
			QDis3.text=textlines2[currentLine2+14];
			QDis4.text=textlines2[currentLine2+15];
	
}
if(qNum ==5){
	
			QDis.text=textlines2[currentLine2+16];
			QDis2.text=textlines2[currentLine2+17];
			QDis3.text=textlines2[currentLine2+18];
			QDis4.text=textlines2[currentLine2+19];
	
}


if(qNum ==6){
	
			QDis.text=textlines2[currentLine2+20];
			QDis2.text=textlines2[currentLine2+21];
			QDis3.text=textlines2[currentLine2+22];
			QDis4.text=textlines2[currentLine2+23];
	
}

if(qNum ==7){
	
			QDis.text=textlines2[currentLine2+24];
			QDis2.text=textlines2[currentLine2+25];
			QDis3.text=textlines2[currentLine2+26];
			QDis4.text=textlines2[currentLine2+27];
	
}

if(qNum ==8){
	
			QDis.text=textlines2[currentLine2+28];
			QDis2.text=textlines2[currentLine2+29];
			QDis3.text=textlines2[currentLine2+30];
			QDis4.text=textlines2[currentLine2+31];
	
}

if(qNum ==9){
	
			QDis.text=textlines2[currentLine2+32];
			QDis2.text=textlines2[currentLine2+33];
			QDis3.text=textlines2[currentLine2+34];
			QDis4.text=textlines2[currentLine2+35];
	
}

if(qNum ==10){
	
			QDis.text=textlines2[currentLine2+36];
			QDis2.text=textlines2[currentLine2+37];
			QDis3.text=textlines2[currentLine2+38];
			QDis4.text=textlines2[currentLine2+39];
	
}



updateQuestion(qNum);

/*for(int y =1;y>5;y++){
	if(qNum ==y){
			
			QDis.text=textlines2[currentLine2*(y-1)];
			QDis2.text=textlines2[currentLine2*(y-1)+1];
			QDis3.text=textlines2[currentLine2*(y-1)+2];
			QDis4.text=textlines2[currentLine2*(y-1)+3];
			y=6;
			
	
}
}*/
}
///////////////////////////////////////////////////////////////
 public void valueAssign(){
		
		//name= " ";
		
if(Q1.isOn == true)
		{	
			Q2.interactable=false;
			Q3.interactable=false;
			Q4.interactable=false;
		nme=QDis.text;
	
		}
		else {
		Q1.interactable =true;
		Q2.interactable =true;
		Q3.interactable = true;
		Q4.interactable = true;
		}
		
 }
//////////////////////////////////////////////////////////////////// 
public void valueAssignTwo(){
if(Q2.isOn == true)
		{	
			Q1.interactable=false;
			Q3.interactable=false;
			Q4.interactable=false;
		nme=QDis2.text;
	
		}
		else {
		Q1.interactable =true;
		Q2.interactable =true;
		Q3.interactable = true;
		Q4.interactable = true;
		}
}
///////////////////////////////////////////////////////////////////////	
public void valueAssignThree(){
if(Q3.isOn == true)
		{	
			Q2.interactable=false;
			Q1.interactable=false;
			Q4.interactable=false;
		nme=QDis3.text;
	
		}
		else {
		Q1.interactable =true;
		Q2.interactable =true;
		Q3.interactable = true;
		Q4.interactable = true;
		}
}
//////////////////////////////////////////////////////////////////
public void valueAssignFour(){
if(Q4.isOn == true)
		{	
			Q2.interactable=false;
			Q3.interactable=false;
			Q1.interactable=false;
		nme=QDis4.text;
	
		}
		else {
		Q1.interactable =true;
		Q2.interactable =true;
		Q3.interactable = true;
		Q4.interactable = true;
		}

}
//////////////////////////////////////////////////////////////////////////
 public string holder()
	{
		
		Answer= nme;

		return Answer;
	}


////////////////////////////////////////////////////////////////////////
void loadAnswers(){
	
			if(textFile3 != null)
		{
			textlines3= (textFile3.text.Split('\n'));
		}

		if(endAtLine3==0)
		{
			endAtLine3=textlines3.Length-1;
		}
        

}
////////////////////////////////////////////////////////////////////
public bool answAssign(int qNum){
		

		answ=textlines3[qNum-1];
		
		selectedAns= holder();
	
		if(answ == selectedAns)
		{
			veri=true;
			//Debug.Log("Yes");
		}
		else
		{
			veri=false;
			//Debug.Log("NO");
		
		}
	
	return veri;
}

////////////////////////////////////////////////////////////////

public void enterBtn(){
	
	bool variableBE = veri;
	
	Q1.isOn = false;
	Q2.isOn = false;
	Q3.isOn = false;
	Q4.isOn = false;
	
	if(variableBE == true){
					Debug.Log("Yes");
			scoreCount=scoreCount+1;
		
	}
	else{
		
		Debug.Log("No");
		scoreCount=scoreCount;
	}
	
		scoreC.text=scoreCount.ToString();
		
		cong();
		queLoop();
}
//////////////////////////////////////////////////////////////////////
public void queLoop(){
	
	if(questionNum >10){
		scoScene.SetActive(true);
		queScene.SetActive(false);
		questionNum=1;
		finalScore.text=scoreCount.ToString();
	}
	
	
	
}

////////////////////////////////////////////////////////////////////////
public void timerFunction(){
	
	
	
	timeLeft= timeLeft + Time.deltaTime;
	
	int seconds = (int)(timeLeft);
	int minutes = (int)(timeLeft/ 60)%60;
	int hours = (int)(timeLeft/3600)% 24;

	//string strTime = string.Format("{0:0}:{1:00}:{2:00},hours,minutes,seconds");

	string strTime = seconds.ToString();
			
	timerText.text= strTime;

	if(timeLeft >120)
	{ 
		scoScene.SetActive(true);
		queScene.SetActive(false);
		questionNum=1;
		finalScore.text=scoreCount.ToString();
	}
	
	
	
}


//////////////////////////////////////////////////////////////////////
    public void changeBackToMenu()
    {
        SceneManager.LoadScene(2);
    }


////////////////////////////////////////////////////////////////

public void retryQuizz(){
	
		scoScene.SetActive(false);
		queScene.SetActive(true);
		questionNum =1;
		timeLeft=0;
}








}
