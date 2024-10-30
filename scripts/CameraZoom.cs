using Unity.Cinemachine;
using UnityEngine;

namespace Cinemachine
{
    public class CameraZoom : MonoBehaviour
    {
        [SerializeField] 
        private Vector2 zoomLimits = new(2f, 10f);
        [SerializeField] 
        private float zoomSpeed = 1f;
        
        private CinemachineCamera _virtualCamera;
    
        private void Start()
        {
            _virtualCamera = GetComponent<CinemachineCamera>();
        }
    
        private void Update()
        {
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)) return;
            var targetZoom = Input.GetKey(KeyCode.S) ? zoomLimits.y : zoomLimits.x;
            _virtualCamera.Lens.OrthographicSize = Mathf.Lerp(_virtualCamera.Lens.OrthographicSize, targetZoom, 
                Time.deltaTime * zoomSpeed);
        }
    }
}
