using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotFollower : MonoBehaviour
{
    public GameObject followingTarget;
    int MyIndex;
    public Vector3 Direction;
    float xax = 0;
    float yax = 0;
    public float AngleR = 0;
    public float AngleD = 0;
    public bool IsHitGround = false;
    Color OriginalColor;
    Color Blank;
    public float AngleDifference;

    // Start is called before the first frame update
    void Start()
    {
        OriginalColor = this.GetComponent<SpriteRenderer>().color;
        Blank = new Color(0, 0, 0, 0);
        MyIndex = this.transform.GetSiblingIndex();
        if (MyIndex != 0)
        {
            followingTarget = this.transform.parent.GetChild(MyIndex - 1).gameObject;
        }
        else if (MyIndex == 0)
        {
            followingTarget = this.transform.parent.gameObject;
        }
    }
    void OnEnable()
    {
        IsHitGround = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Abs(transform.position.x - followingTarget.transform.position.x) > 0.1 && IsHitGround == false)
        {
            Vector3 dir = followingTarget.transform.position - transform.position;
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, followingTarget.transform.position, ref velo, 0.02f);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle - AngleDifference, Vector3.forward);
            this.GetComponent<SpriteRenderer>().color = OriginalColor;

        }
        else if (IsHitGround == false)
        {
            if (MyIndex != 0)
            {
                this.GetComponent<SpriteRenderer>().color = Blank;
            }
            Vector3 dir = followingTarget.transform.position - transform.position;
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, followingTarget.transform.position, ref velo, 0.02f);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle - AngleDifference, Vector3.forward);
        }

    }
    
}
