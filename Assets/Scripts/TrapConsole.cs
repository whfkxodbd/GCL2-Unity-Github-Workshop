using UnityEngine;

public class TrapConsole : MonoBehaviour
{
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
        Debug.Log("Player slowed!");
        Debug.Log("I am but a pitiful slow trap burdened by the wreckage of the world my ancestors have left me. My parents have died. My friends have died. My life is already miserable. At rock bottom, I thought I could fall no deeper. But YOU- YOU came and stepped on me, pushing me into the depths of madness. For this, I curse you with slowness, so you too can experience torment.");
    }

}
