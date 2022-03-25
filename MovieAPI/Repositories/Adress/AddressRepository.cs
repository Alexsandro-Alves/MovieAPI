using MovieAPI.Data;
using MovieAPI.Entities;

namespace MovieAPI.Repositories.Adress
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
