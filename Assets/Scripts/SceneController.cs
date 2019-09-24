using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private GameObject img;

    public void ChangeScene(string sceneName){
        print("ChangeScene");
        StartCoroutine(TimeToFadeOut(sceneName));
    }

    public void ChangeSceneNoDelay(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    void Start(){
        print("Start");
        StartCoroutine(TimeToFadeIn());
    }

    IEnumerator TimeToFadeIn(){
        animator.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);
        img.SetActive(false);
        print("TimeToFadeIn");
    }

    IEnumerator TimeToFadeOut(string scene){
        print("TimeToFadeOut");
        img.SetActive(true);
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(scene);
    }

}
