/********************************************************************************
** auth:  https://github.com/HushengStudent
** date:  2018/04/06 22:40:14
** desc:  Buff
*********************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
    public class Buff
    {
        private int _buffId;
        private ulong _leftTime;
        private BuffEventHandler _onInitHandler;
        private BuffEventHandler _onFinishHandler;

        public int BuffId { get { return _buffId; } }
        public ulong LeftTime { get { return _leftTime; } }

        public void InitBuff(int buffId, ulong leftTime, BuffEventHandler onInit, BuffEventHandler onFinish)
        {
            _buffId = buffId;
            _leftTime = leftTime;
            _onInitHandler = onInit;
            _onFinishHandler = onFinish;
        }
    }
}