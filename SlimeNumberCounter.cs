using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeNumberCounter : MonoBehaviour
{
    public static int MaximumSlime = 30;
    public static bool IsMaximumSlimeNow;

    void Update()
    {
      if(this.transform.childCount >= MaximumSlime)
        {
            IsMaximumSlimeNow = true;
        }

      else if(this.transform.childCount < 30)
        {
            IsMaximumSlimeNow = false;
        }
            
    }


}
