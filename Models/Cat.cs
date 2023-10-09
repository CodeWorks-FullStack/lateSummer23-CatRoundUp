namespace catRoundUp.Models;

public class Cat{
  public int Id {get; set;}
  public string Name {get; set;}
  public string Color {get; set;}
  public  int Age {get; set;}
  public bool Feisty {get; private set;}

  public float AgeInHumanYears
  {
    get { return Age * 4; }
  }

    public Cat(int id, string name, string color, int age, bool feisty)
    {
        Id = id;
        Name = name;
        Color = color;
        Age = age;
        Feisty = feisty;
    }
}