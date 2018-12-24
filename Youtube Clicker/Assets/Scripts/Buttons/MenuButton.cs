using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{

    public string scene;

    private void OnMouseUp()
    {
        SceneManager.LoadScene(scene);
    }

}
