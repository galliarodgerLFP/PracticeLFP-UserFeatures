using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebStuff : MonoBehaviour
{
    public Text usern;
    public Text passW;
    public Text extraS;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public IEnumerator GetUsers(string usern)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", usern);

        using (UnityWebRequest webRequest = UnityWebRequest.Get("http://localhost/TestTut/getusers.php"))
        {
            // Request and wait for the desired page.
            yield return webRequest.Send();

            //string[] pages = webRequest.Split('/');
            //int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                UnityEngine.Debug.Log(webRequest.error);
            }
            else
            {
                UnityEngine.Debug.Log(webRequest.downloadHandler.text);
                byte[] results = webRequest.downloadHandler.data;
                //the above would take results?
                UnityEngine.Debug.Log(results);
                GetUserDeets(results);
            }
        }
    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPassw", password);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/TestTut/login.php", form))
        {
            yield return www.Send();


            if (www.isNetworkError || www.isHttpError)
            {
                UnityEngine.Debug.Log(www.error);
            }
            else
            {
                UnityEngine.Debug.Log(www.downloadHandler.text); //text from php doc
                MainStuff.Instance.SetFINActive();
            }
        }
    }//assign the www stuff to a string (downloadhandler) and then use in unity

    public IEnumerator RegisterUser(string username, string password, string extra)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPassw", password);
        form.AddField("extrastuff1", extra);



        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/TestTut/registerUser.php", form))
        {
            yield return www.Send();

            //string[] pages = uri.Split('/');
            //int page = pages.Length - 1;

            if (www.isNetworkError || www.isHttpError)
            {
                UnityEngine.Debug.Log(www.error);
            }
            else
            {
                UnityEngine.Debug.Log(www.downloadHandler.text);
                byte[] results = www.downloadHandler.data;
                MainStuff.Instance.SetHomeActive();
            }
        }
    }//byte array instead of .split ??

    public void GetUserDeets(byte[] fields)
    {
        usern.text = fields[0].ToString();
        passW.text = fields[1].ToString();
        extraS.text = fields[2].ToString();
    }
}
