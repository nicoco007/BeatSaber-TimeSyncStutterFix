// <copyright file="Plugin.cs" company="Nicolas Gnyra">
// This file is part of TimeSyncStutterFix.
//
// TimeSyncStutterFix is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// TimeSyncStutterFix is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with TimeSyncStutterFix.  If not, see https://www.gnu.org/licenses/.
// </copyright>

using HarmonyLib;
using IPA;

namespace TimeSyncStutterFix;

[Plugin(RuntimeOptions.DynamicInit)]
public class Plugin
{
    private readonly Harmony _harmony = new("com.nicoco007.timesyncstutterfix");

    [OnEnable]
    public void OnEnable()
    {
        _harmony.PatchAll();
    }

    [OnDisable]
    public void OnDisable()
    {
        _harmony.UnpatchSelf();
    }
}
