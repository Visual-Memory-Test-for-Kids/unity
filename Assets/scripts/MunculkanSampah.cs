using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MunculkanSampah : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;
    public GameObject[] obyekSampah;

	public static bool sPause;

	public static bool pause;

    // Use this for initialization
    void Start()
    {
		pause = false;
    }
    // Update is called once per frame
    void Update()
    {
		sPause = pause;
	
		if(!pause){
			timer += Time.deltaTime;
			if (timer > jeda)
			{
				int random = Random.Range(0, obyekSampah.Length);
				Instantiate(obyekSampah[random], transform.position, transform.rotation);
				timer = 0;
			}
		}
			
	
        
    }

	public void mPause(){
        if (pause) {
        	pause = false;
        } else {
        	pause = true;
        }
	}

}