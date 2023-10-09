using catRoundUp.Models;

namespace catRoundUp.Services;


public class CatsService
{

private readonly CatsRepository _repo;

    public CatsService(CatsRepository repo)
    {
        _repo = repo;
    }

    internal Cat CreateCat(Cat catData)
    {
      Cat cat = _repo.CreateCat(catData);
      return cat;
    }

    internal List<Cat> GetCats()
    {
      List<Cat> cats = _repo.GetAllCats();
      return cats;
    }

    internal Cat GetOneCatById(int catId)
    {
      Cat cat = _repo.GetOneCatById(catId);
      if(cat == null) throw new Exception($"not cat with that id {catId}");
      return cat;
    }

    internal string RemoveCat(int catId)
    {
      Cat cat = this.GetOneCatById(catId);

      _repo.RemoveCat(catId);
      // _repo.RemoveCat(cat);
      return $"{cat.Name} has been adopted";
    }
}

