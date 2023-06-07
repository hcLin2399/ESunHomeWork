using ESunHomework.DataAccess;
using ESunHomework.Models;
using System.Collections.Generic;

namespace ESunHomework.Service
{
    public class service
    {
        private readonly dataaccess _dataAccess = new dataaccess();

        public void GetApiData()
        {
            _dataAccess.GetApiData();
        }

        public List<ApiDataModel> getTableData()
        {
            return _dataAccess.getTableData();
        }
    }
}