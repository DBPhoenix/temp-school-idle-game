using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class GlobalWarmingIceAge : UI_Perk
{
    private protected override void Purchase()
    {
        GameObject.Find("Temperature").GetComponent<UI_Building>().Status = BuildingStatus.Enabled;
    }
}
