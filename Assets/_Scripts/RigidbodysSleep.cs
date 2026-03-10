using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent( typeof(Rigidbody) )]
public class RigidbodysSleep : MonoBehaviour {
    private int       sleepCountdown = 4;                                     // b
    private Rigidbody rigid;

    void Awake() {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        if ( sleepCountdown > 0 ) {
            rigid.Sleep();
            sleepCountdown--;
        }
    }
}
