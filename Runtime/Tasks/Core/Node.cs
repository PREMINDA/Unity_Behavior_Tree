using UnityEngine;

namespace BHTree.Runtime.Tasks.Core
{
    public abstract class Task : ScriptableObject
    {
        public TaskState state = TaskState.Running;
        public bool started = false;

        protected virtual void OnStart() {}

        protected virtual void OnEnd() {}

        protected virtual TaskState OnUpdate() => TaskState.Success;
    }
}