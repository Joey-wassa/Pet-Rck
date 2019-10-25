using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Controller : MonoBehaviour
{


    public Text HungerText;
    public Text FriendshipText;
    public Text sickText;

    public GameObject Rock;

    // Start is called before the first frame update
    void Start()
    {
        /*HungerText.text = "I'm hungry";
        FriendshipText.text = "Hello";
        sickText.text = "Healthy";*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Rock != null)
        {
            HungerText.text = "Hunger: " + Rock.GetComponent<Rock_Controller>().hunger.ToString();
            FriendshipText.text = "Friendship: " + Rock.GetComponent<Rock_Controller>().friendship.ToString();
            sickText.text = "sick: " + Rock.GetComponent<Rock_Controller>().issick.ToString();
        }
       
    }

    public void Rock_Food()
    {
        Rock.GetComponent<Rock_Controller>().hunger += 2;
    }
    public void PlayRock()
    {
        Rock.GetComponent<Rock_Controller>().friendship += 2;
    }
    public void Vet()
    {
        Rock.GetComponent<Rock_Controller>().issick = false;
    }
}
