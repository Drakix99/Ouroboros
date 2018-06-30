﻿namespace SRPG
{
    using System;

    [Serializable]
    public class JSON_CondEffectParam
    {
        public string iname;
        public string job;
        public string buki;
        public string birth;
        public int sex;
        public int elem;
        public int cond;
        public int type;
        public int vini;
        public int vmax;
        public int rini;
        public int rmax;
        public int tini;
        public int tmax;
        public int chktgt;
        public int timing;
        public int[] conds;
        public int v_poi;
        public int v_poifix;
        public int v_par;
        public int v_blihit;
        public int v_bliavo;
        public int v_dea;
        public int v_beratk;
        public int v_berdef;
        public int v_fast;
        public int v_slow;
        public int v_don;
        public int v_ahp;
        public int v_ahpfix;
        public int v_amp;
        public int v_ampfix;
        public int curse;
        public string[] buffs;

        public JSON_CondEffectParam()
        {
            base..ctor();
            return;
        }
    }
}
