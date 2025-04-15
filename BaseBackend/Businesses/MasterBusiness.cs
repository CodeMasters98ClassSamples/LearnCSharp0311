using BaseBackend.Entities;
using BaseBackend.Interfaces;

namespace BaseBackend.Businesses;

public class MasterBusiness : IBaseBusiness<Master>
{
    List<Master> masters = new List<Master>();

    public void Add(Master item)
    {
        masters.Add(item);
    }


    public List<Master> GetAll()
    {
        return masters;
    }

}
