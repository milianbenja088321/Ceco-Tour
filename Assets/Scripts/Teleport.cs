using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vodgets
{
    public class Teleport : Vodget
    {
        public SteamVR_TrackedController controller_left;
        public SteamVR_TrackedController controller_right;
        public Transform VRperson_pos = null;
        public LineRenderer lineray;
        
  

        // Use this for initialization
        void Start()
        {
            lineray.enabled = false;
          
        }

        public override void DoFocus(Selector cursor, bool state)
        {
            base.DoFocus(cursor, state);
            Debug.Log("DoFocus" + cursor.Cursor.localPosition.ToString() );
        }

        public override void DoGrab(Selector cursor, bool state)
        {
            base.DoGrab(cursor, state);
            Debug.Log("DoGrab" + cursor.Cursor.localPosition.ToString());
            //if (state)
            //    VRperson_pos.position = cursor.Cursor.localPosition;
           
        }

        public override void DoButton(Selector cursor, Selector.Button button, bool state)
        {
            Debug.Log("Button:" + button + " State:" + state);
            
            if (state && button == Selector.Button.PadClicked)
            {
                lineray.enabled = true;
                SteamVR_Fade.Start(Color.clear, 0f);
                SteamVR_Fade.Start(Color.black, 1f);
                VRperson_pos.position = cursor.Cursor.localPosition;
                SteamVR_Fade.Start(Color.black, 0f);
                SteamVR_Fade.Start(Color.clear, 1f);
            }
                
        }

        public override void DoUpdate(Selector cursor)
        {
            base.DoUpdate(cursor);
            //Debug.Log("DoUpdate" + cursor.Cursor.localPosition.ToString());
        }
    }
}
