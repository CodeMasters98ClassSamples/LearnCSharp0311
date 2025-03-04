
using LearnCSharp0311.Entities;
using LearnCSharp0311.Interfaces;
using System.Diagnostics.Metrics;

namespace LearnCSharp0311.Businesses;

internal class MasterBusiness : IBaseBusiness<Master>
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
