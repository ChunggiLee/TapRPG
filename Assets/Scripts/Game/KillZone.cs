using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour {

    void OnTriggerStay2D(Collider2D _hit)
    {
        if (_hit.tag == "Monster")
        {
            _hit.GetComponent<MonsterFSM>().SetState(CharacterState.Dead);

        }
    }
}
