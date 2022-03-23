//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;
//public class OpenURLScript : MonoBehaviour
//{
//    public string emailAddressSubscribed,sceneToLoad,URLtoOpen;
//    public InputField inputFieldEmailAddress;
//    // Start is called before the first frame update
//    void Start()
//    {

//        string connetionString;
//        SqlConnection cnn;
//        connetionString = @"Data Source=go4irhrserver.database.windows.net;Initial Catalog=Go4irEmployees;User ID=HRAdmin;Password=LetMeInGo4ir";
//        cnn = new SqlConnection(connetionString);
//        cnn.Open();
//        inputFieldEmailAddress.text = "Connection Open";
//        cnn.Close();

//    }
//    public void StartSubscriptionCheck()
//    {
//        CheckSubscription(inputFieldEmailAddress.text);
//    }
//    public void CheckSubscription(string emailLoginString)
//    {
//        if (VerifyEmail(emailLoginString)==true)
//        {
//            bool LoginApproved = false;
//            string connetionString;
//            SqlConnection cnn;
//            connetionString = @"Data Source=go4irhrserver.database.windows.net;Initial Catalog=Go4irEmployees;User ID=HRAdmin;Password=LetMeInGo4ir";
//            cnn = new SqlConnection(connetionString);
//            cnn.Open();
//            Debug.Log("Connection Open  !");
//            SqlCommand commandToExecute;
//            SqlDataReader sqlDataReader;
//            string sql, queryOutput;
//            queryOutput = "";
//            sql = "Select * from SubscriptionTable";
//            commandToExecute = new SqlCommand(sql, cnn);
//            sqlDataReader = commandToExecute.ExecuteReader();
//            while (sqlDataReader.Read())
//            {
//                Debug.Log(sqlDataReader.GetValue(10).ToString());
//                queryOutput = queryOutput + sqlDataReader.GetValue(0) + " - " + sqlDataReader.GetValue(1) + " - " + sqlDataReader.GetValue(2) + " - " + sqlDataReader.GetValue(3) + " - " + sqlDataReader.GetValue(4) + " - " + sqlDataReader.GetValue(5) + " - " + sqlDataReader.GetValue(6) + " - " + sqlDataReader.GetValue(7) + " - " + sqlDataReader.GetValue(8) + " - " + sqlDataReader.GetValue(9) + " - " + sqlDataReader.GetValue(10) + " - " + sqlDataReader.GetValue(11) + " - " + sqlDataReader.GetValue(12) + " - " + sqlDataReader.GetValue(13) + " - " + sqlDataReader.GetValue(14) + "\n";
//                if (emailLoginString == sqlDataReader.GetValue(10).ToString() && sqlDataReader.GetValue(2).ToString() == "COMPLETE")
//                {
//                    Debug.Log("Access Allowed");
//                    LoginApproved = true;
                    
//                }
//                else
//                {
//                    Debug.Log("Email has not been subscribed");

                    
//                }
//            }
//            if (LoginApproved)
//            {
//                SceneManager.LoadScene(sceneToLoad);
//            }
//            else
//            {
//                OpenUrlPortal(URLtoOpen);
//            }
//            Debug.Log(queryOutput);
//            sqlDataReader.Close();
//            commandToExecute.Dispose();
//            cnn.Close();
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//    public bool VerifyEmail(string emailAddressToVerify)
//    {
//        bool IsEmailValid=false,IsThereAFullStop=false, IsThereAnAt = false;       
//        for (int i = 0; i < emailAddressToVerify.Length; i++)
//        {
//            if (emailAddressToVerify.Substring(i,1)=="@")
//            {
//                IsThereAnAt = true;
//            }
//            if (emailAddressToVerify.Substring(i, 1) == ".")
//            {
//                IsThereAFullStop = true;
//            }
            
//        }
//        if (IsThereAFullStop && IsThereAnAt)
//        {
//            IsEmailValid = true;
//        }
//        if (IsEmailValid)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//    public void OpenUrlPortal(string URL)
//    {
//        Application.OpenURL(URL);
//    }
//}
