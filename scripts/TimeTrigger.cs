using UnityEngine;

namespace Cinemachine
{
    public class TimeTrigger : MonoBehaviour
    {
        [SerializeField]
        private float newTimeScale = 1f;
    
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Time.timeScale = newTimeScale;
            }
        }
    }
}
