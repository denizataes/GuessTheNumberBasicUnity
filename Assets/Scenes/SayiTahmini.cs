using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayiTahmini : MonoBehaviour {
    int max = 1500, min = 1,tahmin=750;
    // Use this for initialization
    void Start () {
        OyunaBasla();

     

    }
    void OyunaBasla()
    {
        Debug.Log("Sayi tahmini oyununa hosgeldiniz...");
        Debug.Log("Aklınızdan " + min + " ile " + max + " arasında bir sayı tutun...");
        Debug.Log("Tuttuğunuz sayı " + tahmin + " mi ?");
        Debug.Log("Doğruysa => Enter \n Daha Yüksekse => Yukarı tuşu");
        Debug.Log("Daha Alçaksa =>Alt tuşu");
    }
    void TahminEtme()
    {
        tahmin = (min + max) / 2;
        Debug.Log("Yeni tahminim: " + tahmin);
    }
	
	// Update is called once per frame
	void Update () {
   
		if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = tahmin;
            TahminEtme();
          
        
          
        }
       else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = tahmin;
            TahminEtme();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {

            Debug.Log("Bu iş bu kadar aga.");
            min = 1;
            max = 1500;
            Start();
            
  
        }
                 
       
    }
}
