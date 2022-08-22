using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour

    
{
    public int counter = 0;
    public int rate = 60;
    public GameObject particulePrefab;

    public float dureeDeVie;
    public float dateDeCollision; //Heure de la collision
    public float RayonCercle; // Rayon du cercle pour g�n�rer

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("start !" + Time.time);
        dateDeCollision = Mathf.Infinity;
    }

    // Update is called once per frame
    void Update()
    {
        counter ++;

        if (counter % rate == 0)
        {
            // Debug. Log("message");
            Debug.Log("message");
        }

        if (counter % rate == 0) 
        {
            Vector2 NouvellePosition = Random.insideUnitCircle * RayonCercle;
            Quaternion NouvelleRotation = Quaternion.identity;
            Instantiate(particulePrefab, NouvellePosition, NouvelleRotation);  
        }



        if (Time.time > 5f) 
        {
            Debug.Log("stop");
           // this.gameObject.SetActive(false); //D�sactiver le GameObject
        }

        //if ( (dateDeCollision + 5f) > Time.time) 
        {
            //Il s'est �coul� au moins 5 secondes depuis la date de collision
            //this.gameObject.SetActive(false); //D�sactiver le GameObject
        }
    }

    //5 secondes apr�s le d�but collision, le GameObject se d�sactive
    //�a se trouve, 3 secondes apr�s il n'y a plus de collision
    private void OnCollisionEnter(Collision collision)
    {
        dateDeCollision = Time.time;    
    }
}
