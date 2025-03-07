using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class EasterEggEvent : MonoBehaviour, MMEventListener<PickableItemEvent>
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
        RetroStar easterEgg = e.PickedItem.GetComponent<RetroStar>();

        if (easterEgg != null)
            Debug.Log("Easter egg encontrado");
    }
}
