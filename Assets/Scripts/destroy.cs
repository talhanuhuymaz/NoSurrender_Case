using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class destroy : MonoBehaviour
{
   
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Cube"))
            {
                Destroy(collision.gameObject);
                ScoreManager.scoreCount += 1; // when its collides with a cube the score will be rise
            }
        }
    private void Update()
    {
        // Check the "Cube" tags
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Cube");

        // if there is no one in the plane then loadscreen again
        if (enemies.Length == 0)
        {
            SceneManager.LoadScene("SampleScene");
            ScoreManager.scoreCount = 0; //We need to reset the score after the new load
        }
    }

}
