using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : IGenericDAL<CommentEntity>
    {
        public string Delete(CommentEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<CommentEntity> GetAllList()
        {
            throw new NotImplementedException();
        }

        public CommentEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Insert(CommentEntity entity)
        {
            throw new NotImplementedException();
        }

        public string Update(CommentEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
