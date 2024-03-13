﻿using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite.Models;

internal class Spy : Soldier, ISpy
{
    public Spy(string id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
    {
        CodeNumber = codeNumber;
    }

    public int CodeNumber { get; private set; }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
        sb.AppendLine($"Code Number: {CodeNumber}");
        return sb.ToString().TrimEnd();
    }
}
