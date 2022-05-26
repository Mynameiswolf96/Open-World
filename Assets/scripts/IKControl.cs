using UnityEngine;
[RequireComponent(typeof(Animation))]
public class IKEAControl : MonoBehaviour
{
    [SerializeField]
    private bool _ikActive;
    
    [SerializeField]
    private Transform _pointLeftHand;
    
    [SerializeField]
    private Transform _pointLook;

    [SerializeField] private float _radiusLooking=2;
    private Animator _animator;
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnAnimatorIK(int layerIndex)
    {
        if (!_animator)
            return;
        if (_ikActive)
        {
            if (_pointLook != null)
            {

                Vector3 distanceForLookPoint = _pointLook.position - transform.position;
                if (distanceForLookPoint.magnitude <= _radiusLooking)
                {
                    _animator.SetLookAtWeight(1);
                    _animator.SetLookAtPosition(_pointLook.position);
                   
                }
                WeightLeftHand(1);
                _animator.SetIKPosition(AvatarIKGoal.LeftHand, _pointLeftHand.position);
                _animator.SetIKRotation(AvatarIKGoal.LeftHand, _pointLeftHand.rotation);    
            }
        }
        else
        {
            WeightLeftHand(0);
            _animator.SetLookAtWeight(0);
        }
    }
    private void WeightLeftHand(float value)
    {
        _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, value);
        _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, value);
    }
    
}

