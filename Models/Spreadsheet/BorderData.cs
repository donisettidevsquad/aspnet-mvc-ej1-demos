﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
public class BorderData
{
    public string name { get; set; }
    public string style1 { get; set; }
    public string style2 { get; set; }
    public string style3 { get; set; }
    public string style4 { get; set; }
    public string style5 { get; set; }
    public static List<BorderData> GetBorderDetails
    {
        get
        {
            List<BorderData> formats = new List<BorderData>();

            formats.Add(new BorderData() { name = "Right Border", style5 = "Left Border" });
            formats.Add(new BorderData());
            formats.Add(new BorderData() { name = "Bottom Border", style5 = "Top Border" });
            formats.Add(new BorderData());
            formats.Add(new BorderData() { name = "All Borders", style5 = "No Border" });
            formats.Add(new BorderData());
            formats.Add(new BorderData() { name = "Outside Borders", style5 = "Thick Box Border" });
            formats.Add(new BorderData());
            formats.Add(new BorderData() { name = "Thick Bottom Border", style5 = "Top and Bottom Border" });
            formats.Add(new BorderData());
            formats.Add(new BorderData() { name = "Top and Thick Bottom Border", style5 = "Outside Borders" });
            formats.Add(new BorderData());
            formats.Add(new BorderData() { name = "Grid Borders" });
            formats.Add(new BorderData());
            formats.Add(new BorderData());
            formats.Add(new BorderData());
            formats.Add(new BorderData() { name = "Bottom Double Border", style5 = "Top and Bottom Double Border" });
            return formats;
        }
    }
}