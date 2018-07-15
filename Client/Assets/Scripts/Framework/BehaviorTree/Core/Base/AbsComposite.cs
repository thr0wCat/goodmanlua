/********************************************************************************
** auth:  https://github.com/HushengStudent
** date:  2018/07/11 00:25:08
** desc:  抽象节点父类;
*********************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
    public abstract class AbsComposite : AbsBehavior
    {
        protected List<AbsBehavior> _list = new List<AbsBehavior>();

        public override bool IsComposite
        {
            get
            {
                return false;
            }
        }

        public AbsComposite(Hashtable table) : base(table)
        {
            _list.Clear();
        }

        public void Serialize(List<AbsBehavior> behaviorList)
        {
            _list = behaviorList;
        }

        protected sealed override void Update()
        {
            if (Reslut == BehaviorState.Running)
            {
                UpdateEx();
            }
            else if (Reslut == BehaviorState.Finish)
            {
                Reslut = BehaviorState.Success;
            }
        }
    }
}