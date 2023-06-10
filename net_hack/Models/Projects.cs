using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

//Define your PokeItem model which will have a Name, and a Url.
//Make your class public, since by default it is internal.
public class Projects
{
    //Define the constructor of your PokeItem which is the same name as class, and is not returning anything.
    //Will take a string name
    // public WestDynamicsItem(string name)
    // {
    //     Name = name;
    // }
    //Your Properties are auto-implemented.
    public int? Id { get; set; }
    public string? Project { get; set; }
    public string? projectType { get; set; }
    public string? Subtitle { get; set; }
    public string? Desc1 { get; set; }
    public string? Subtitle2 { get; set; }
    public string? Desc2 { get; set; }
    public string? projectDesign { get; set; }
    public string? Desc3a { get; set; }
    public string? Desc3b { get; set; }
    public string? Link { get; set; }

    public override string ToString() => JsonSerializer.Serialize<Projects>(this);



}