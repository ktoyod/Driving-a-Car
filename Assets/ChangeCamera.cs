using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour
{

    //　メインカメラ
    [SerializeField] private GameObject theFirstCamera;
    //　切り替える他のカメラ
    [SerializeField] private GameObject theSecondCamera;

    void Start()
    {
        theFirstCamera.SetActive(true);
        theSecondCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // クリックしたらカメラを切り替える
        if (Input.GetButtonDown("Fire1"))
        {
            theFirstCamera.SetActive(!theFirstCamera.activeSelf);
            theSecondCamera.SetActive(!theSecondCamera.activeSelf);
        }
    }
}