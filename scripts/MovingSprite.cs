using System.Collections;
using UnityEngine;

namespace Cinemachine
{
    public class MovingSprite : MonoBehaviour
    {
        [SerializeField]
        private Vector3 moveDirection = Vector3.right;

        private float _delay;

        private IEnumerator Start()
        {
            _delay = Random.Range(1f, 3f);
            while (true)
            {
                yield return new WaitForSeconds(_delay);
                moveDirection = -moveDirection;
            }
        }
        
        private void Update()
        {
            transform.position += moveDirection * Time.deltaTime;
        }
    }
}
