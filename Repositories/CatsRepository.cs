



namespace catRoundUp.Repositories;


public class CatsRepository{

private List<Cat> _FakeDb;
// private Guid id; guid if for GenerateId;

public CatsRepository()
{
  // id = Guid.NewGuid();
  _FakeDb = new List<Cat>();
  _FakeDb.Add(new Cat(1, "Georgie", "Orange", 5, false));
  _FakeDb.Add(new Cat(2, "Bean", "Black", 7, true));
  _FakeDb.Add(new Cat(3, "Garfield", "Orange", 100, true));
}

    internal Cat CreateCat(Cat catData)
    {
      int catId = _FakeDb[_FakeDb.Count -1].Id; // weirdness for sequenced id's
      catData.Id = catId + 1;
      _FakeDb.Add(catData);
      return catData;
    }

    internal List<Cat> GetAllCats()
    {
      return _FakeDb;
    }

    internal Cat GetOneCatById(int catId)
    {
      Cat cat = _FakeDb.Find(c => c.Id == catId);
      return cat;
    }

    internal void RemoveCat(int catId)
    {
      Cat cat = _FakeDb.Find(c => c.Id == catId);
      _FakeDb.Remove(cat);
    }

    // OVERLOADING methods. methods with the same name but different parameters
    internal void RemoveCat(Cat cat){
      _FakeDb.Remove(cat);
    }
}