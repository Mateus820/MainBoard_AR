using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private GameObject img;

    public void ChangeScene(string sceneName){
        img.SetActive(true);
        StartCoroutine(TimeToFadeOut(sceneName));
    }

    void Start(){
        StartCoroutine(TimeToFadeIn());
        animator.SetTrigger("FadeIn");
        img.SetActive(false);
    }

    IEnumerator TimeToFadeIn(){
        animator.SetTrigger("FadeIn");
        yield return new WaitForSeconds(2.5f);
        img.SetActive(false);
    }

    IEnumerator TimeToFadeOut(string scene){
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(scene);
    }
}
