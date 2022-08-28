using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [SerializeField] private Text _scoreText;

    void Start() {
        _scoreText.text = "SCORE: 0";
    }

    void Update() {
        if(RealmController.Instance.IsRealmReady()) {
            _scoreText.text = "SCORE: " + RealmController.Instance.GetScore().ToString();
        }
    }
}
