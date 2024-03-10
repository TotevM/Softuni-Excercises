﻿namespace PersonsInfo;

internal class Team
{
	private string name;
	private List<Person> firstTeam;
	private List<Person> reserveTeam;

    public Team(string name)
    {
        Name = name;
		firstTeam = new();
        reserveTeam = new();
    }

    public string Name
	{
		get => name;
		private set => name = value; 
	}
    public IReadOnlyCollection<Person> FirstTeam
	{
		get => firstTeam.AsReadOnly(); 
	}
    public IReadOnlyCollection<Person> ReserveTeam
    {
        get => reserveTeam.AsReadOnly();
    }

	public void AddPlayer(Person person)
	{
		if (person.Age < 40)
		{
			firstTeam.Add(person);
		}
		else
		{
            reserveTeam.Add(person);
		}
	}
}
