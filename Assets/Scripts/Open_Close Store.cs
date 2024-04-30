using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_CloseStore : MonoBehaviour
{
    [SerializeField] GameObject uiElement;

    [SerializeField] GameObject playerObject;

    [SerializeField] PlayerMovement movementScript;

    // Start is called before the first frame update
    void Start()
    {
        uiElement.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // G�r s� att man bara kan g� in i shoppen om man st�r p� detta objekt och st�r stilla annars st�ngs shoppen
    private void OnTriggerStay2D(Collider2D collision)
    {

        if(collision.gameObject == playerObject && movementScript.rigidBody2D.velocity.x == 0 && movementScript.rigidBody2D.velocity.y == 0)
        {
            uiElement.SetActive(true);
        }
        else
        {
            uiElement.SetActive(false);
        }
    }
}
