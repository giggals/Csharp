using System;
using System.Collections.Generic;
using System.Text;


public interface ICommando
{
    List<string> Missions { get; set; }

    string MissionCode { get; set; }

    string MissionStade { get; set; }
}

