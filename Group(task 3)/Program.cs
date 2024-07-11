using System;
using System.Collections.Generic;
public class Group
{
    public string Name { get; }

    public Group(string name)
    {
        Name = name;
    }
}

public class GroupManager
{
    private List<Group> groups;

    public GroupManager()
    {
        groups = new List<Group>();
    }

    public void AddGroup(Group group)
    {
        if (!groups.Exists(Group => Group.Name == group.Name))
        {
            groups.Add(group);
            Console.WriteLine($"Group '{group.Name}' added.");
        }
        else
        {
            Console.WriteLine($"Group '{group.Name}' exists.");
        }
    }

    public void PrintGroups()
    {
        Console.WriteLine("Groups:");
        foreach (var group in groups)
        {
            Console.WriteLine(group.Name);
        }
    }
}

public class Program
{
    public static void Main()
    {
        GroupManager groupManager = new GroupManager();

        Group group1 = new Group("Group1");
        Group group2 = new Group("Group2");
        Group group3 = new Group("Group1");

        groupManager.AddGroup(group1);
        groupManager.AddGroup(group2);
        groupManager.AddGroup(group3);

        groupManager.PrintGroups();
    }
}
