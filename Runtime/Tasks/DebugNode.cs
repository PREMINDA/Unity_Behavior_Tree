using BHTree.Runtime.Tasks.Core;
using UnityEngine;

namespace BHTree.Runtime.Tasks
{
    public class DebugNode : ActionNode
    {
        public string text;
        protected override void OnStart()
        {
            Debug.Log("Node Start "+text );
        }
        
        protected override TaskState OnUpdate()
        {
            Debug.Log("Node Update "+text);
            return TaskState.Success;
        }

        protected override void OnEnd()
        {
            Debug.Log("Node End"+ text);
        }

        
    }
}