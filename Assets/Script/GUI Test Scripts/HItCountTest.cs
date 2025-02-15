using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YARG.Core;
using YARG.Core.Engine;
using YARG.Core.Game;
using TMPro;
using YARG.Gameplay;
using System.Linq;
using YARG.Gameplay.Player;

namespace YARG
{
    public class HitCountTest : GameplayBehaviour
    {
        public TextMeshProUGUI Total_Notes_Counter;
        public TextMeshProUGUI Total_Notes_Missed_Counter;
        public TextMeshProUGUI Missed_Notes_Counter;
        public TextMeshProUGUI Hit_Notes_Counter; 
    
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {


            var currentPlayer = GameManager.Players.FirstOrDefault();
            

            int noteTotal = currentPlayer.BaseEngine.BaseStats.TotalNotes;
            Total_Notes_Counter.text = noteTotal.ToString();
            Total_Notes_Missed_Counter.text = noteTotal.ToString();

           /* if (currentPlayer is FiveFretPlayer fiveFretPlayer)
            {
                fiveFretPlayer.Engine.EngineStats.
                hit_Count.text = noteHit.ToString();
                miss_Count.text = noteMissed.ToString();
            }*/


        }
    }
}
