using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // 共通シーン名（Mainシーン）
    public string _mainSceneName = "Main";

    // 最初に読み込まれるシーン名
    public string _defaultSceneName = "Title";

    // 現在表示中のシーン名（Title か GamePlay）
    string _currentSceneName;

    void Start()
    {
        // 再生直後はタイトルシーンを読み込む
        SceneManager.LoadSceneAsync("Title", LoadSceneMode.Additive);
        _currentSceneName = "Title";
    }

    // シーン切り替え
    public void ChangeScene(string sceneName)
    {
        // 現在のシーンを削除
        SceneManager.UnloadSceneAsync(_currentSceneName);

        // 新たにシーンを追加読み込み
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        // 読み込んだシーンをCurrentSceneとして保存
        _currentSceneName = sceneName;
    }
}
