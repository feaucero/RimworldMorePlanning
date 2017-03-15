﻿using RimWorld;
using System;
using UnityEngine;
using Verse;

namespace MorePlanning
{
    public class Designator_PlanYellowRemove : Designator_PlanBase
    {
        public Designator_PlanYellowRemove() : base(PlanningDesignationDef.ColorYellow, DesignateMode.Remove)
        {
            this.defaultLabel = "MorePlanning.PlanYellowRemove".Translate();
            this.defaultDesc = "DesignatorPlanRemoveDesc".Translate();
            this.icon = ContentFinder<Texture2D>.Get("UI/PlanToolYellowRemove", true);
            this.hotKey = KeyBindingDefOf.Misc4;
        }
    }
}
