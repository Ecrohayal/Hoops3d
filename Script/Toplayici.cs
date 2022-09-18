using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Toplayici : MonoBehaviour
{
    public GameObject anakup;
    float yukseklik;
    public TextMeshPro textScore;
    public int scoreCount;
    public GameControl control;
    public AudioSource destroy;
    public AudioClip tik;
    public ParticleSystem particle;
    private void Awake()
    {
      
        textScore.text = "X" + scoreCount.ToString();
    }
    private void FixedUpdate()
    {
        anakup.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z
            );


        
        this.transform.position = anakup.transform.position;



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "OrangeCollect" )
        {
            yukseklik -= 1.5f;

            other.gameObject.GetComponent<ToplanabiliHoop>().ToplandiYap();

            other.gameObject.GetComponent<ToplanabiliHoop>().indexAyarla(yukseklik);

            other.gameObject.transform.parent = anakup.transform;

            other.gameObject.tag = "Toplandi";
            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
            other.gameObject.GetComponent<BoxCollider>().isTrigger = true;

            //

            scoreCount--;

           // textScore.text = "X" + scoreCount.ToString();

            if(scoreCount ==0)
            {
                Destroy(anakup,0.2f);
                Instantiate(particle, transform.position, transform.rotation);
                control.cylinders.RemoveAt(0);
                //destroy.Play();
                destroy.PlayOneShot(tik);
            }
            


        }


     
        


    }


}

