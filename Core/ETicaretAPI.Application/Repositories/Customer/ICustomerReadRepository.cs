using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Enitites;


namespace ETicaretAPI.Application.Repositories{

    public interface ICustomerReadRepository:IReadRepository<Customer>
    {

    }

}
