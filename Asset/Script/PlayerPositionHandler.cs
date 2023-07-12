using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionHandler : MonoBehaviour
{
    [SerializeField] Vector2 playerCurrentPosition;
    [SerializeField] Vector2 currentCheckpointPosition;
    public TransformData playerPositionData;
    private TriggerEvent playerTriggerEvent;
    void Start()
    {
       playerTriggerEvent = GetComponent<TriggerEvent>();
    }
    private void LoadPosition()
    {
        playerCurrentPosition = playerPositionData.position;
    }
    //berguna untuk Save Position ke Scriptable Object
    private void SavePosition(Vector2 newPosition)
    {
        playerPositionData.position = newPosition;
    }

    //berguna untuk mengubah posisi player
    private void ChangePlayerPosition(Vector2 newPosition)
    {
        transform.position = newPosition;
    }

    public void OnCheckpoint(GameObject col)
    {
        Vector2 newCheckpointPosition = col.transform.position;
        currentCheckpointPosition = newCheckpointPosition;
        SavePosition(currentCheckpointPosition);
        //CheckpointWallActive(col);
    }

    public void OnTrap()
    {
        ChangePlayerPosition(currentCheckpointPosition);
    } 
}
