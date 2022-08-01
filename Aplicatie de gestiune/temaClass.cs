﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_de_gestiune
{
   public static class temaClass
    {
        public static List<string> ColorList = new List<string>()
        {
            "#000000",
            "#003300",
            "#006600",
            "#009900",
            "#00CC00",
            "#00FF00",
            "#000033",
            "#003333",
            "#006633",
            "#009933",
            "#00CC33",
            "#00FF33",
            "#000066",
            "#003366",
            "#006666",
            "#009966",
            "#00CC66",
            "#00FF66",
            "#000099",
            "#003399",
            "#006699",
            "#009999",
            "#00CC99",
            "#00FF99",
            "#0000CC",
            "#0033CC",
            "#0066CC",
            "#0099CC",
            "#00CCCC",
            "#00FFCC",
            "#0000FF",
            "#0033FF",
            "#0066FF",
            "#0099FF",
            "#00CCFF",
            "#00FFFF",
            "#330000",
            "#333300",
            "#336600",
            "#339900",
            "#33CC00",
            "#33FF00",
            "#330033",
            "#333333",
            "#336633",
            "#339933",
            "#33CC33",
            "#33FF33",
            "#330066",
            "#333366",
            "#336666",
            "#339966",
            "#33CC66",
            "#33FF66",
            "#330099",
            "#333399",
            "#336699",
            "#339999",
            "#33CC99",
            "#33FF99",
            "#3300CC",
            "#3333CC",
            "#3366CC",
            "#3399CC",
            "#33CCCC",
            "#33FFCC",
            "#3300FF",
            "#3333FF",
            "#3366FF",
            "#3399FF",
            "#33CCFF",
            "#33FFFF",
            "#660000",
            "#663300",
            "#666600",
            "#669900",
            "#66CC00",
            "#66FF00",
            "#660033",
            "#663333",
            "#666633",
            "#669933",
            "#66CC33",
            "#66FFCC",
            "#660066",
            "#663366",
            "#666666",
            "#669966",
            "#66CC66",
            "#66FF66",
            "#660099",
            "#663399",
            "#666699",
            "#669999",
            "#66CC99",
            "#66FF99",
            "#6600CC",
            "#6633CC",
            "#6666CC",
            "#6699CC",
            "#66CCCC",
            "#66FFCC",
            "#6600FF",
            "#6633FF",
            "#6666FF",
            "#6699FF",
            "#66CCFF",
            "#66FFFF",
            "#990000",
            "#993300",
            "#996699",
            "#999900",
            "#99CC00",
            "#99FF00",
            "#990033",
            "#993333",
            "#996633",
            "#999933",
            "#99CC33",
            "#99FF33",
            "#990066",
            "#993366",
            "#996666",
            "#999966",
            "#99CC66",
            "#99FF66",
            "#990099",
            "#993399",
            "#996699",
            "#999999",
            "#99CC99",
            "#99FF99",
            "#9900CC",
            "#9933CC",
            "#9966CC",
            "#9999CC",
            "#99CCCC",
            "#99FFCC",
            "#9900FF",
            "#9933FF",
            "#9966FF",
            "#9999FF",
            "#99CCFF",
            "#99FFFF",
            "#CC0000",
            "#CC3300",
            "#CC6600",
            "#CC9900",
            "#CCCC00",
            "#CCFF00",
            "#CC0033",
            "#CC3333",
            "#CC6633",
            "#CC9933",
            "#CCCC33",
            "#CCFF33",
            "#CC0066",
            "#CC3366",
            "#CC6666",
            "#CC9966",
            "#CCCC66",
            "#CCFF66",
            "#CC0099",
            "#CC3399",
            "#CC6699",
            "#CC9999",
            "#CCCC99",
            "#CCFF99",
            "#CC00CC",
            "#CC33CC",
            "#CC66CC",
            "#CC99CC",
            "#CCCCCC",
            "#CCFFCC",
            "#CC00FF",
            "#CC33FF",
            "#CC66FF",
            "#CC99FF",
            "#CCCCFF",
            "#CCFFFF",
            "#FF0000",
            "#FF3300",
            "#FF6600",
            "#FF9900",
            "#FFCC00",
            "#FFFF00",
            "#FF0033",
            "#FF3333",
            "#FF6633",
            "#FF9933",
            "#FFCC33",
            "#FFFF33",
            "#FF0066",
            "#FF3366#",
            "#FF6666",
            "#FF9966",
            "#FFCC66",
            "#FFFF66",
            "#FF0099",
            "#FF3399",
            "#FF6699",
            "#FF9999",
            "#FFCC99",
            "#FFFF99",
            "#FF00CC",
            "#FF33CC",
            "#FF66CC",
            "#FF99CC",
            "#FFCCCC",
            "#FFFFCC",
            "#FF00FF",
            "#FF33FF",
            "#FF66FF",
            "#FF99FF",
            "#FFCCFF",
            "#FFFFFF",
            "#FF4848",
            "#FF68DD",
            "#FF62B0",
            "#FE67EB",
            "#E469FE",
            "#D568FD",
            "#9669FE",
            "#FF7575",
            "#FF79E1",
            "#FF73B9",
            "#FE67EB",
            "#E77AFE",
            "#D97BFD",
            "#A27AFE",
            "#FF8A8A",
            "#FF86E3",
            "#FF86C2",
            "#FE8BF0",
            "#EA8DFE",
            "#DD88FD",
            "#AD8BFE",
            "#FF9797",
            "#FF97E8",
            "#FF97CB",
            "#FE98F1",
            "#ED9EFE",
            "#E29BFD",
            "#B89AFE",
            "#FFA8A8",
            "#FFACEC",
            "#FFA8D3",
            "#FEA9F3",
            "#EFA9FE",
            "#E7A9FE",
            "#C4ABFE",
            "#FFBBBB",
            "#FFACEC",
            "#FFBBDD",
            "#FFBBF7",
            "#F2BCFE",
            "#EDBEFE",
            "#D0BCFE",
            "#FFCECE",
            "#FFC8F2",
            "#FFC8E3",
            "#FFCAF9",
            "#F5CAFF",
            "#F0CBFE",
            "#DDCEFF",
            "#FFDFDF",
            "#FFDFF8",
            "#FFDFEF",
            "#FFDBFB",
            "#F9D9FF",
            "#F4DCFE",
            "#E6DBFF",
            "#FFECEC",
            "#FFEEFB",
            "#FFECF5",
            "#FFEEFD",
            "#FDF2FF",
            "#FAECFF",
            "#F1ECFF",
            "#FFF2F2",
            "#FFFEFB",
            "#FFF9FC",
            "#FFF9FE",
            "#FFFDFF",
            "#FDF9FF",
            "#FBF9FF",
        };
    }
}