using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poursuite : MonoBehaviour
{
    public float vitesse = 1f;
    
    public Transform joueur;
    
    void Start()
    {
        GameObject joueurObjet = GameObject.FindGameObjectWithTag("Player");
        if (joueurObjet != null)
        {
            joueur = joueurObjet.transform;
        }
        else
        {
            Debug.LogError("Aucun joueur trouvé avec le tag 'Player' !");
        }
    }

    void Update()
    {
        if (joueur != null)
        {
            Vector3 positionActuelle = transform.position;

            Vector3 positionJoueur = joueur.position;

            Vector3 direction = (positionJoueur - positionActuelle).normalized;

            transform.position = positionActuelle + direction * vitesse * Time.deltaTime;
        }
    }
}
