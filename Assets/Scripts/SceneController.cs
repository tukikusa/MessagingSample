using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // ���ʃV�[�����iMain�V�[���j
    public string _mainSceneName = "Main";

    // �ŏ��ɓǂݍ��܂��V�[����
    public string _defaultSceneName = "Title";

    // ���ݕ\�����̃V�[�����iTitle �� GamePlay�j
    string _currentSceneName;

    void Start()
    {
        // �Đ�����̓^�C�g���V�[����ǂݍ���
        SceneManager.LoadSceneAsync("Title", LoadSceneMode.Additive);
        _currentSceneName = "Title";
    }

    // �V�[���؂�ւ�
    public void ChangeScene(string sceneName)
    {
        // ���݂̃V�[�����폜
        SceneManager.UnloadSceneAsync(_currentSceneName);

        // �V���ɃV�[����ǉ��ǂݍ���
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        // �ǂݍ��񂾃V�[����CurrentScene�Ƃ��ĕۑ�
        _currentSceneName = sceneName;
    }
}
