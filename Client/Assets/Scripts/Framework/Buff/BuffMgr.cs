/********************************************************************************
** auth:  https://github.com/HushengStudent
** date:  2018/01/10 23:27:56
** desc:  Buff管理
*********************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
    public class BuffMgr : Singleton<BuffMgr>
    {
        public override void Init()
        {
            base.Init();
            LogUtil.LogUtility.Print("--->>>BuffMgr Init!", LogUtil.LogColor.Green);
        }
    }
}
