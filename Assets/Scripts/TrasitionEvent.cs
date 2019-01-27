using UnityEngine;

public class TrasitionEvent : StateMachineBehaviour
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) =>
        animator.GetComponent<TransitionEventBehaviour>()?.TriggerOnEnter();
}
