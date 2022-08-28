using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float _movementSpeed = 5.0f;

    private Rigidbody2D _rb2d;

    void Awake() {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Start() {
        if(RealmController.Instance.IsRealmReady()) {
            _rb2d.position = RealmController.Instance.GetPosition();
        }
    }

    void FixedUpdate() {
        if(Input.GetKey(KeyCode.UpArrow)) {
            _rb2d.position += Vector2.up * _movementSpeed * Time.fixedDeltaTime;
        } else if(Input.GetKey(KeyCode.DownArrow)) {
            _rb2d.position += Vector2.down * _movementSpeed * Time.fixedDeltaTime;
        } else if(Input.GetKey(KeyCode.LeftArrow)) {
            _rb2d.position += Vector2.left * _movementSpeed * Time.fixedDeltaTime;
        } else if(Input.GetKey(KeyCode.RightArrow)) {
            _rb2d.position += Vector2.right * _movementSpeed * Time.fixedDeltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(RealmController.Instance.IsRealmReady()) {
            RealmController.Instance.UpdatePosition(_rb2d.position);
            RealmController.Instance.IncreaseScore(1);
        }
    }

}
