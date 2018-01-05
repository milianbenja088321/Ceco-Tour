using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vodgets
{ 
    public class sound_interaction : Vodget
    {
        AudioSource sound;
        bool touch_active = false;

        public BoolEvent onPlaySound = new BoolEvent();

        public void PlaySound( bool state )
        {
            if (state)
            {
                sound.Play();
            }
        }

        void Start()
        {
            sound = GetComponent<AudioSource>();
            RegisterState(onPlaySound, PlaySound);
        }
        
        public override void DoFocus(Selector cursor, bool state)
        {
            base.DoFocus(cursor, state);
            onPlaySound.Invoke(state);
            //PlaySound(state);
        }

        //public override void DoGrab(Selector cursor, bool state)
        //{
        //    base.DoGrab(cursor, state);
        //}

        //public override void DoButton(Selector cursor, Selector.Button button, bool state)
        //{
        
        //}

        //public override void DoUpdate(Selector cursor)
        //{
        //    base.DoUpdate(cursor);
           
        //}

    }
}
