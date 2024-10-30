using Unity.Cinemachine;
using UnityEngine;

namespace Cinemachine
{
    public class CameraSwitchTrigger : MonoBehaviour
    {
        [SerializeField] private CinemachineCamera cam2;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.gameObject.CompareTag("Player")) return;
            cam2.Priority = 100;
        }
    }
}
