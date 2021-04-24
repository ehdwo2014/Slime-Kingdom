using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSelectedSlimeUI : MonoBehaviour
{
    public GameObject OriginalDummy;
    public GameObject TargetDummy;
    public GameObject SelectionSlime;
    Vector3 Original = new Vector3();
    Vector3 Target = new Vector3();
    public static GameObject WorkUI;
    public GameObject InventoryUI;





    // Start is called before the first frame update
    void Start()
    {

        Original = OriginalDummy.transform.position;
        Target = TargetDummy.transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {

        Original = OriginalDummy.transform.position;
        Target = TargetDummy.transform.position;

        if (SelectionSlime.GetComponent<SlimeSelection>().SelectedSlime != null && UIController.IsAnythingSelected == false)
        {
            //transform.position = Vector2.MoveTowards(transform.position, target, 1f);
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Target, ref velo, 0.05f);
        }
        if (SelectionSlime.GetComponent<SlimeSelection>().SelectedSlime == null || UIController.IsAnythingSelected == true)
        {
            //transform.position = Vector2.MoveTowards(transform.position, Original, 1f);
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Original, ref velo, 0.05f);
            if(SelectionSlime.GetComponent<SlimeSelection>().SelectedSlime == null && Mathf.Abs(Original.x - this.transform.position.x) < 0.3 && Mathf.Abs(Original.y - this.transform.position.y) < 0.3 )
            {
                this.gameObject.SetActive(false);
            }


        }

    }
    public void OpenInventoryUI()
    {
        InventoryUI.SetActive(true);
        ButtonSwitch.Swit = true;
    }
}
