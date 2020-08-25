using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Exit());
    }

    IEnumerator Exit()
    {
        yield return new WaitForSeconds(.1f);
        Application.Quit();
    }
}
