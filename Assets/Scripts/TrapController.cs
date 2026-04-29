using System.Collections;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    // Look for player controller script and move speed int

    public PlayerController thePlayerController;

    public int moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Trap")
        {
            StartCoroutine(trapActive());
        }
    }

    // Decrease speed for 2s before returning speed to normal
    public IEnumerator trapActive() 
    {
        thePlayerController.moveSpeed = 1;
        yield return new WaitForSeconds(2);
        thePlayerController.moveSpeed = 4;
    }
}
