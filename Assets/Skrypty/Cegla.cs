using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cegla : MonoBehaviour
{
    public int punktyZaCegle;
    public int hpCegly;
    public Sprite hit2;
    public Sprite hit3;

    public void RozbijCegle()
    {
        hpCegly--;
        if (hpCegly == 1)
        {
            GetComponent<SpriteRenderer>().sprite = hit2;
        }
        else if(hpCegly == 2)
        {
            GetComponent<SpriteRenderer>().sprite = hit3;
        }
    }
}
