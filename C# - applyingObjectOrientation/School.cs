namespace C____applyingObjectOrientation;

class Studant
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<double> Grades { get; set; } = new List<double>();
}

class Professor
{
    public string Name { get; set; }
    public List<string> DisciplinesTaught { get; set; } = new List<string>();
}

class Discipline
{
    public string Name { get; set; }
    public List<Studant> Studants { get; set; } = new List<Studant>();
}

