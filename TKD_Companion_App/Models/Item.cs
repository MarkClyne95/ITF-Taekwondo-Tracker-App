using System;
using System.Collections.Generic;

namespace TKD_Companion_App.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Grade { get; set; }
    }

}

public enum AllGrades
{
    WhiteBelt,
    YellowTag,
    YellowBelt,
    GreenTag,
    GreenBelt,
    BlueTag,
    BlueBelt,
    RedTag,
    RedBelt,
    BlackTag,
    First,
    Second,
    Third,
    Fourth,
    Fifth,
    Sixth,
}

public enum ColorBelt
{
    White = AllGrades.WhiteBelt,
    YellowTag = AllGrades.YellowTag,
    Yellow = AllGrades.YellowBelt,
    GreenTag = AllGrades.GreenTag,
    Green = AllGrades.GreenBelt,
    BlueTag = AllGrades.BlueTag,
    Blue = AllGrades.BlueBelt,
    RedTag = AllGrades.RedTag,
    Red = AllGrades.RedBelt,
    BlackTag = AllGrades.BlackTag,
}

public enum Blackbelt
{
    First = AllGrades.First,
    Second = AllGrades.Second,
    Third = AllGrades.Third,
    Fourth = AllGrades.Fourth,
    Fifth = AllGrades.Fifth,
    Sixth = AllGrades.Sixth
}