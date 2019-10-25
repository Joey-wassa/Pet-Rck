using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_Controller : MonoBehaviour
{


    public string Rockname = "Mike";
    public float hunger = 100f;
    public float friendship = 100f;
    public bool issick = false;

    float hungerscale = 2f;
    float friendshipscale = 2f;
       
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Rockname); 
    }

    // Update is called once per frame
    void Update()
    {
        Statusupdate();
       
    }

void Statusupdate()
    {
        hunger -= Time.deltaTime * hungerscale;
        friendship -= Time.deltaTime * friendshipscale;

        int sickchance = Random.Range(0, 1000);
        if (sickchance==97)
        {
            issick = true;
        }

        if (issick == false)
        {
            hungerscale = 2f;
            friendshipscale = 2f;
        }
        else
        {
            hungerscale = 5f;
            friendshipscale = 5f;
        }
    }

    void IsDead()
    {
        if (hunger <= 0)
        {
            Destroy(gameObject);
        }
        else if (friendship <= 0) ;
        {
            Destroy(gameObject);
        }
    }
}
