using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASK_1_APRIL_13.Models;
namespace TASK_1_APRIL_13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        List<CustomerDet> custdet = new List<CustomerDet>()
        {
            new CustomerDet(){cid=1,cname="Gowthami",cadd="Kakinada",cno=123456789,cmail="gowthami@gmail.com"},
            new CustomerDet(){cid=2,cname="Amu",cadd="Vijayawada",cno=987654321,cmail="amu@gmail.com"},
            new CustomerDet(){cid=3,cname="Amaira",cadd="Vizag",cno=6309240306,cmail="amaira@gmail.com"},
            new CustomerDet(){cid=4,cname="Radha",cadd="Chittor",cno=234567298,cmail="radha@gmail.com"},
            new CustomerDet(){cid=5,cname="Ramya",cadd="Srikakulam",cno=936583824,cmail="ramya@gmail.com"},
            new CustomerDet(){cid=6,cname="Arjun",cadd="Guntur",cno=938475745,cmail="arjun@gmail.com"},
            new CustomerDet(){cid=7,cname="Pranav",cadd="Ananthapur",cno=867485938,cmail="pranav@gmail.com"},
            new CustomerDet(){cid=8,cname="Sudha",cadd="Pithapuram",cno=895748596,cmail="sudha@gmail.com"},
            new CustomerDet(){cid=9,cname="Raj",cadd="Rajamundry",cno=789654387,cmail="raj@gmail.com"},
            new CustomerDet(){cid=10,cname="Bhavya",cadd="Kakinada",cno=689547585,cmail="bhavya@gmail.com"}
        };
        [HttpGet]
        public IEnumerable<CustomerDet> Getall()
        {
            var query1 = from i in custdet select i;
            return query1;
        }
    }
}


