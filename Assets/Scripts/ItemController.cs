using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Pun.UtilityScripts;
using Photon.Realtime;

public class ItemController : MonoBehaviour
{
    [SerializeField] GameObject m_nowChip;
    public GameObject NowChip { get { return m_nowChip; } set { m_nowChip = value; } }

    private bool m_used = false;

    DropChipTurnManager dropChipTurnManager;

    void Start()
    {
        dropChipTurnManager = GameObject.Find("Manager").GetComponent<DropChipTurnManager>();
    }

    void Update()
    {
        
    }

    public void PushReDraw()
    {
        if (dropChipTurnManager.ActivePlayer.Equals(PhotonNetwork.LocalPlayer) && !m_used)
        {
            PhotonNetwork.Destroy(m_nowChip);
            dropChipTurnManager.SpawnChip();
            m_used = true;
        }
    }
}
