
// NOTE data decorators/attributes effect the next definition, making our class an API CONTROLLER with the route ".../api/cats"

[ApiController]
[Route("api/cats")]
public class CatsController : ControllerBase{

  private readonly CatsService _catsService;
  public CatsController(CatsService cs){
    _catsService = cs;
  }

// adding to the route
[HttpGet("test")]
public string GetTest(){
 return "hey it worked";
}

// Method client uses to hit this route
[HttpGet]
//accessor, return type, method name
// Return type can have types inside of each other, in this case we will return a Result with a List of Cats
public ActionResult<List<Cat>> GetCats(){
try
  {
    List<Cat> cats = _catsService.GetCats();
    return Ok(cats);
    // return something else in a second
  }
  catch (Exception e)
  {
    return BadRequest(e.Message);
  }
}

[HttpGet("{catId}")]
public ActionResult<Cat> GetOneCatById(int catId){
try
{
  Cat cat = _catsService.GetOneCatById(catId);
  return Ok(cat);
}
 catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}

[HttpPost]
public ActionResult<Cat> CreateCat([FromBody]Cat catData){
try
{
  Cat cat = _catsService.CreateCat(catData);
  return Ok(cat);
}
 catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}

[HttpDelete("{catId}")]
public ActionResult<string> RemoveCat(int catId){
  try
  {
    string message = _catsService.RemoveCat(catId);
    return Ok(message);
  }
 catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}



}