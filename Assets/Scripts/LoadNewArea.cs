using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNewArea : MonoBehaviour
{
    // Start is called before the first frame update

    public string levelToLoad;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
