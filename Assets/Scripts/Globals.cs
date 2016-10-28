﻿//-----------------------------------------------------------------------
// <copyright file="Globals.cs" company="Google">
//
// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------
using Tango;

/// <summary>
/// Game global states.
/// </summary>
public static class Globals
{
    /// <summary>
    /// If hosting a game, the Area Description to use, otherwise, null.
    /// </summary>
    public static AreaDescription m_curAreaDescription;

    /// <summary>
    /// The room player is going to join.
    /// </summary>
    public static RoomInfo m_gameRoom;

	public static Room m_room;
}
