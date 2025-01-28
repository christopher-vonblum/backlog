#!/usr/bin/cs-script
﻿using System.Reflection;

string peek = "peek";
string done = "done";
string log = "log";

// ./backlog log

string workingDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

TryCreateDir("backlogs");

string backlogDir = workingDir + "backlogs";

Args parsedArgs = ParseArgs(args);

PerformBacklogAction(args);

void PerformBacklogAction(Args parsedArgs)
{
    if (parsedArgs.Instruction == peek)
    {
        File.ReadLines(workingDir + "").First()
    }
}

Args ParseArgs(string[] args)
{
    if (args.Length == 0)
    {
        throw new Exception("No arguments.");
    }

    Args parsedArgs = new Args();

    parsedArgs.Instruction = args[1];

    if (parsedArgs.Instruction == log)
    {
        
    }
    
}


void TryCreateDir(string dirName)
{
    if (!Directory.Exists(workingDir + $"/{dirName}"))
    {
        Directory.CreateDirectory(workingDir + $"/{dirName}");
    }
}

class Args
{
    public string Instruction;
    public string Backlog = "default";
    public string Task;
}