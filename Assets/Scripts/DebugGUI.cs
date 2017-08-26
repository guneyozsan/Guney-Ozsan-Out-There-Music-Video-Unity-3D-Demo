﻿// Guney Ozsan - Out There (Music Video) - Real time music video in demoscene style for Unity 3D.
// Copyright (C) 2017 Guney Ozsan

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// ---------------------------------------------------------------------

// Displays the current time, measure and song part for tracking our place in the song and debugging.
# if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugGUI : MonoBehaviour {

    Sequencer sequencer;

    void Start()
    {
        sequencer = GetComponent<Sequencer>();
    }

    void OnGUI()
    {
        GUI.Label(
            new Rect(10, 10, 200, 100),
            "Bar:   " + sequencer.currentBar + ":" + sequencer.currentBeat
            + "      Time:   " + (int)(sequencer.musicDebug.time * 1000) + " ms" + Environment.NewLine
            + "-------------------------------------------" + Environment.NewLine
            + "Part:       " + sequencer.currentPart + Environment.NewLine
            + "Region:   " + sequencer.currentRegionId + Environment.NewLine
            + sequencer.currentRegionDescription
        );
    }
}
#endif // UNITY_EDITOR