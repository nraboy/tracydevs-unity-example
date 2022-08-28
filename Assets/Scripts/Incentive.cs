using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incentive : MonoBehaviour {

    private Rigidbody2D _rb2d;

    void Awake() {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Start() {
        _rb2d.position = new Vector2(Random.Range(-4, 4), Random.Range(-4, 4));
    }

    void OnCollisionEnter2D(Collision2D collision) {
         _rb2d.position = new Vector2(Random.Range(-4, 4), Random.Range(-4, 4));
    }

}
