using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MYCLASSNAME : MonoBehaviour {
    
Light RedLight;
Light GreenLight;
Light YellowLight;
float GreenTimer = 5; // default 5sec.
float redTimer = 15; // default 15sec.
 
bool  estaVerde = true;
bool  estaVermelho = true;
 
IEnumerator  Start (){
 YellowLight.enabled = false;
 
 while(true)
 {  
  Verde();
  yield return new WaitForSeconds(GreenTimer);
  
  YellowLight.enabled = true;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.1f);
 
  YellowLight.enabled = false;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.2f);
 
  YellowLight.enabled = true;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.3f);
 
  YellowLight.enabled = false;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.4f);
 
  YellowLight.enabled = true;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.5f);
 
  YellowLight.enabled = false;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.6f);
 
  YellowLight.enabled = true;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.7f);  
 
  YellowLight.enabled = false;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.8f);  
 
  YellowLight.enabled = true;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.9f);  
 
  YellowLight.enabled = false;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.10f);
 
  YellowLight.enabled = true;  
  GreenLight.enabled = false;
  yield return new WaitForSeconds(0.1f);
  
  Vermelho();
  yield return new WaitForSeconds(redTimer);
 }
}

void  Verde (){
 if (estaVerde)
 {
  GreenLight.enabled = true;    
  RedLight.enabled = false;
 }
}
void  Vermelho (){
 if (estaVermelho)
 {
  RedLight.enabled = true;  
  YellowLight.enabled = false;
 }
}
 
}