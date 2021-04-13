using UnityEngine;

namespace Gerry.Scripts
{
    public class ChangePlayerPosOnTrigger : MonoBehaviour
    {
        [SerializeField] private Vector3 resetPos;

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;
        
            // Reset speed
            var rb = other.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.rotation = Quaternion.identity;
            rb.angularVelocity = Vector3.zero;
        
            other.gameObject.transform.position = resetPos;
        }
    }
}
