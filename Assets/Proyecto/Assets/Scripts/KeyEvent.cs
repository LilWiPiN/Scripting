using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class KeyEvent : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        InventoryEngineKey key = e.PickedItem.GetComponent<InventoryEngineKey>();

        if (key != null)
            Debug.Log("Llave encontrada");
    }
}
