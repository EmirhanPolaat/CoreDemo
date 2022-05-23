using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessage3Service: IGenericService<Message3>
    {
        List<Message3> GetInboxListByWriter(int id);
    }
}
