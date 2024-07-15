using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestructionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float Delay = 1f;
    void Start()
    {
        StartCoroutine(BeginSelfDestruction());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator BeginSelfDestruction(){
        yield return new WaitForSeconds(Delay);
        Destroy(gameObject);
    }
}
