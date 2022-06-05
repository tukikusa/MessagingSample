﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvent
{
    /// <summary>
    /// GameEventを受け取るコンポーネント　引数を受け取るバージョン
    /// 引数を受け取る場合は、このクラスを継承して作る
    /// </summary>
    public abstract class GameEventListenerWithArgs<T> : MonoBehaviour
    {
        /// <summary>
        /// 受けたいイベント
        /// </summary>
        public GameEventWithArgs<T> Event;

        /// <summary>
        /// 受け取ったイベントを対象に渡すUnityEvent
        /// </summary>
        public UnityEvent<T> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        /// <summary>
        /// イベント発行時に呼ばれる
        /// </summary>
        public void OnEventRaised(T value)
        {
            Response.Invoke(value);
            Debug.Log($"{this} -> 受け取ったよ : {value}");
        }
    }
}