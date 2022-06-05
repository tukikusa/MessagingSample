# MessagingSample

ScriptableObjectを用いた、
Unityメッセージングのサンプルです。

【シーン構成】
Main.Scene
├ Title.Scene
└ GamePlay.Scene

最初にMain.Sceneが読み込まれ、続けてTitle.SceneがAdditiveで読み込まれます
Title.SceneのButtonをクリックすると、Title.Sceneが破棄され、
GamePlay.Sceneに切り替わります
（Main.Sceneはそのまま残ります）

シーン切り替えを実行するために、
ScriptableObjectを用いたGameEventを使用します

文字列を指定できるGameEventWithStringにより、ボタンをクリックすると
読み込みたいScene名を書き込んだGameEventが発行されます
例＞GameEventWithString.Raise("Title")

続けて、SceneControllerに設置したGameEventListenerWithStringが
そのイベントを購読し、受けとります
GameEventListenerWithStringはSceneController.ChangeScene()と紐づいており
シーン切り替えが実行されます
