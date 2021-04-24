using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDeleteButton : MonoBehaviour
{
    public GameObject ConfirmationDelete;

    public void SlimeDeleteButtonClick()
    {
        ConfirmationDelete.gameObject.SetActive(true);
    }
}
