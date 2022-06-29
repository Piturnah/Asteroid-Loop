using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSpawner : MonoBehaviour {
    public GameObject asteroid;
    WorldBoundary boundary;

    void Start() {
        boundary = FindObjectOfType<WorldBoundary>();
        for (int i = 0; i < 7; i++) {
            Instantiate(asteroid, new Vector2(Random.Range(-boundary.dimensions.x, boundary.dimensions.x), Random.Range(-boundary.dimensions.y, boundary.dimensions.y)) * 0.5f, Quaternion.identity);
        }
    }

    private void Update() {
        if (Input.GetAxisRaw("Fire1") == 1) {
            SceneManager.LoadScene(1);
        }
    }

    public void PlayButton() {
        Debug.Log("balls");
        SceneManager.LoadScene(1);
    }
}
