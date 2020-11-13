using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class MainStuff : MonoBehaviour
{

    public static MainStuff Instance;
    public WebStuff Web;
    

    public GameObject viewsCreate;
    public GameObject viewsLogin;
    public GameObject viewsHome;
    public GameObject viewsFIN;

    public Text usern;
    public Text passw;
    public Text extras;



    void Start()
    {
        SetHomeActive();

        Instance = this;
        Web = GetComponent<WebStuff>();
 
    }

    public void SetFINActive()
    {
        viewsHome.SetActive(false);
        viewsCreate.SetActive(false);
        viewsLogin.SetActive(false);
        viewsFIN.SetActive(true);
        
  
        

    }

    public void SetLoginActive()
    {
        viewsHome.SetActive(false);
        viewsCreate.SetActive(false);
        viewsFIN.SetActive(false);
        viewsLogin.SetActive(true);
    }
    public void SetRegisterActive()
    {
        viewsHome.SetActive(false);
        viewsCreate.SetActive(true);
        viewsLogin.SetActive(false);
        viewsFIN.SetActive(false);

    }
    public void SetHomeActive()
    {
        viewsHome.SetActive(true);
        viewsCreate.SetActive(false);
        viewsLogin.SetActive(false);
        viewsFIN.SetActive(false);

    }

    
}
