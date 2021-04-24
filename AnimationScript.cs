using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
	GameObject EggMaker;
	GameObject Core;
	GameObject Material;
	GameObject Egga;
	Animator m_Animator;



    // Start is called before the first frame update
    void Start()
    {
	EggMaker = GameObject.Find("EggMaker");
	Core = GameObject.Find("Core");
	Material = GameObject.Find("Material");
	m_Animator = EggMaker.GetComponent<Animator>();
	Egga = GameObject.Find("Egg");


	if (EggMaker) {
            Debug.Log(EggMaker.name);
        } else {
            Debug.Log("No game object called EggMaker found");
        }

	if (Core) {
            Debug.Log(Core.name);
	    
        } else {
            Debug.Log("No game object called Core found");
        }

	if (Material) {
            Debug.Log(Material.name);
        } else {
            Debug.Log("No game object called Material found");
        }


    }

    void Update()
    {
   if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("ABC"))
        {
            Debug.Log("AEC");
	    Destroy(Core);
	    Destroy(Material);
	    m_Animator.SetBool("IsThereCore", false);
	    Instantiate(Egga, new Vector3(-5.31f, -0.59f, 0f), Quaternion.identity);
        }
    }
}













