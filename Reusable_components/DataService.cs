//This is a dependency injection
using System.Collections.Generic;
using System.Threading.Tasks;
public class DataService
{
    public async List<string> GetData()
    {
        await Task.Delay(500);
        return new List<string> { "Item 1", "Item 2", "Item 3" };
    }
}