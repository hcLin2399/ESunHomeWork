using ESunHomework.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;

namespace ESunHomework.DataAccess
{
    public class dataaccess
    {
        private myDbContext context = new myDbContext();
        /// <summary>
        /// 取得api資料並寫入資料庫
        /// </summary>
        public void GetApiData()
        {
            const string url = "https://odws.hccg.gov.tw/001/Upload/25/opendataback/9059/870/8bfb5f8a-2748-44da-a188-6e568987676b.json";
            string jsonData;

            // 建立 API 請求
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            // 讀取 API 回應
            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    jsonData = reader.ReadToEnd();
                }
            }
            response.Close();

            List<ApiDataModel> modelList = new List<ApiDataModel>();
            modelList = JsonConvert.DeserializeObject<List<ApiDataModel>>(jsonData);
            using (var scope = context.Database.BeginTransaction())
            {
                //先刪除資料在寫入取得資料
                try
                {
                    deleteTableData();
                    saveTableData(modelList);
                    scope.Commit();

                }
                catch
                {
                    scope.Rollback();
                }
            }
        }

        public void deleteTableData()
        {
            var table = context.Table1.ToList();
            context.Table1.RemoveRange(table);
            context.SaveChanges();

        }

        public void saveTableData(List<ApiDataModel> modelList)
        {
            foreach (var data in modelList)
            {
                context.Table1.Add(data);
            }
            context.SaveChanges();
        }

        public List<ApiDataModel> getTableData()
        {
            var allData = context.Table1.ToList();
            return allData;

        }
    }
}