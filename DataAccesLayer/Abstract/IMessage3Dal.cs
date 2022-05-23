using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessage3Dal:IGenericDal<Message3>
    {
        List<Message3> GetListWithMessageByWriter(int id);
    }
}
