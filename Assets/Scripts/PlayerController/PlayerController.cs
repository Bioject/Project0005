using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float lastHit = 0.0f;
    [SerializeField]
    BaseClass hero;

    private void Update()
    {
        //***Attack
        if (Input.GetMouseButtonDown(0) && Time.time >= lastHit)
        {
            lastHit = Time.time + hero.AttackSpeed;
            if (hero.HitSystem.HitDetected(50f))
                print("true");
            else
                print("false");
        }
    }//end of Update
}
