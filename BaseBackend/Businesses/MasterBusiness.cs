using BaseBackend.Entities;
using BaseBackend.Interfaces;

namespace BaseBackend.Businesses;

public class MasterBusiness : IBaseBusiness<Master>
{
    List<Master> masters = new List<Master>();

    public bool Add(Master item)
    {
        masters.Add(item);
        return true;
    }


    public List<Master> GetAll()
    {
        return masters;
    }

    public bool Update(Master item)
    {
        throw new NotImplementedException();
    }

}
