using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableTest : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Try to load new asset");
            AsyncOperationHandle<GameObject> asyncOperationHandle =
                Addressables.LoadAssetAsync<GameObject>("Assets/Prefabs/Sphere.prefab");

            asyncOperationHandle.Completed += AsyncOperationHandleCompleted;
        }
    }

    private void AsyncOperationHandleCompleted(AsyncOperationHandle<GameObject> asyncOperationHandle)
    {
        if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
        {
            Instantiate(asyncOperationHandle.Result);
            Debug.Log("AsyncOperationHandleCompleted");
        }
        else
        {
            Debug.Log("Failed to load");
        }
    }
}
