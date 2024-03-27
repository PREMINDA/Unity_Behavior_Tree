using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

namespace BHTree.Runtime.Tasks.Core
{
    public abstract class ParentTaskNode : TaskNode
    {
        [SerializeField]
        protected List<Task> children;
    }
}