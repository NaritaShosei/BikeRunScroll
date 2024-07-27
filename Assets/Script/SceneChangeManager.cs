using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : MonoBehaviour
{
    [SerializeField] string _sceneName;
    [SerializeField] float _waitTime;
    [SerializeField] AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void GetScene()
    {
        if (_audio)
        {
            _audio.Play();
        }
        StartCoroutine(StartSceneChange());
    }

    IEnumerator StartSceneChange()
    {
        yield return new WaitForSeconds(_waitTime);
        SceneChange(_sceneName);
    }
}
