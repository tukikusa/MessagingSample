# MessagingSample

ScriptableObjectを用いた、</br>
Unityメッセージングのサンプルです。</br>
</br>
【シーン構成】</br>
Main.Scene</br>
├ Title.Scene</br>
└ GamePlay.Scene</br>
</br>
最初にMain.Sceneが読み込まれ、続けてTitle.SceneがAdditiveで読み込まれます</br>
Title.SceneのButtonをクリックすると、Title.Sceneが破棄され、</br>
GamePlay.Sceneに切り替わります</br>
（Main.Sceneはそのまま残ります）</br>
</br>
シーン切り替えを実行するために、</br>
ScriptableObjectを用いたGameEventを使用します</br>
</br>
文字列を指定できるGameEventWithStringにより、ボタンをクリックすると</br>
読み込みたいScene名を書き込んだGameEventが発行されます</br>
例＞GameEventWithString.Raise("Title")</br>
</br>
続けて、SceneControllerに設置したGameEventListenerWithStringが</br>
そのイベントを購読し、受けとります</br>
GameEventListenerWithStringはSceneController.ChangeScene()と紐づいており</br>
シーン切り替えが実行されます</br>
