using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketClientDemo.Model
{
   public class DevicesDAL
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <returns></returns>
        public int Add(Devices model)
        {
            using (var lisctx = new DataModel())
            {
                lisctx.Devices.Add(model);
                return lisctx.SaveChanges();
            }
        }

        /// <summary>
        /// 获取表所有数据
        /// </summary>
        /// <returns></returns>
        public List<Devices> GetList()
        {
            using (var lisctx = new DataModel())
            {
                return lisctx.Devices.ToList();
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Delete(Devices model)
        {
            using (var lisctx = new DataModel())
            {
                lisctx.Devices.Attach(model);
                lisctx.Devices.Remove(model);
                return lisctx.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改一条记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Devices model)
        {
            using (var lisctx = new DataModel())
            {
                lisctx.Devices.Attach(model);
                lisctx.Entry(model).State = System.Data.Entity.EntityState.Modified;
                return lisctx.SaveChanges() > 0;
            }
        }
    }
}
