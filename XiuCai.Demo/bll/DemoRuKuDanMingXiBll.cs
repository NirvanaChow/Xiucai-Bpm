using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xiucai.Dal;
using Xiucai.Model;
using Xiucai.Common.Provider;
using Xiucai.Common.Data;

namespace Xiucai.Bll
{
    public class DemoRuKuDanMingXiBll
    {
        public static DemoRuKuDanMingXiBll Instance
        {
            get { return SingletonProvider<DemoRuKuDanMingXiBll>.Instance; }
        }

        public int Add(DemoRuKuDanMingXiModel model)
        {
            return DemoRuKuDanMingXiDal.Instance.Insert(model);
        }

        public int Update(DemoRuKuDanMingXiModel model)
        {
            return DemoRuKuDanMingXiDal.Instance.Update(model);
        }

        public int Delete(int keyid)
        {
            return DemoRuKuDanMingXiDal.Instance.Delete(keyid);
        }
        /// <summary>
        /// ɾ����ⵥ�����е���ϸ��¼
        /// </summary>
        /// <param name="rkdid">��ⵥID</param>
        /// <returns></returns>
        public int deleteAll(int rkdid)
        {
            return DbUtils.DeleteWhere<DemoRuKuDanMingXiModel>(new {rkdId = rkdid});
        }

        public string GetJson(int pageindex, int pagesize, string filterJson, string sort = "Keyid", string order = "asc")
        {

            return DemoRuKuDanMingXiDal.Instance.GetJson(pageindex, pagesize, filterJson, sort, order);
        }
    }
}
