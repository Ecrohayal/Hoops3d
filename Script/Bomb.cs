using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Bomb : MonoBehaviour
{

    public GameObject part;
    public float currentTime = 0f;
    public float startingTime;
    public TextMeshPro countDownText;
    public GameObject end;
   
    
    private void Start()
    {
        part.SetActive(false);
        currentTime = startingTime;
      
    }

    private void Update()
    {
        if(currentTime <= startingTime && currentTime>0f)
        {
            currentTime -= 1 * Time.deltaTime;
            countDownText.text = currentTime.ToString("0");
        }
       

        else if(currentTime <= 0)
        {
            this.gameObject.GetComponent<BoxCollider>().isTrigger = true;
            StartCoroutine(fin());
           
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="PinkCollect"||other.tag=="BlueCollect"||other.tag=="RedCollect"||other.tag=="GreenCollect"||other.tag=="OrangeCollect")
        {
            Destroy(other.gameObject, 0.1f);


        }
    }



   IEnumerator fin()
    {
        part.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        Destroy(gameObject);
       
        end.SetActive(true);
    }

  
}
