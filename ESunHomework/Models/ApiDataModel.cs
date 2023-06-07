using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESunHomework.Models
{
    [Table("Table1")]
    public class ApiDataModel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 農會漁會別
        /// </summary>
        [JsonProperty("農會漁會別")]
        public string category { get; set; }

        /// <summary>
        /// 總部分支機構別
        /// </summary>
        [JsonProperty("總部分支機構別")]
        public string category2 { get; set; }

        /// <summary>
        /// 金融代號
        /// </summary>
        [JsonProperty("金融代號")]
        public string FinancialCode { get; set; }

        /// <summary>
        /// 郵遞區號
        /// </summary>
        [JsonProperty("郵遞區號")] 
        public string PostalCode { get; set; }

        /// <summary>
        /// 所在縣市
        /// </summary>
        [JsonProperty("所在縣市")] 
        public string City { get; set; }

        /// <summary>
        /// 住址
        /// </summary>
        [JsonProperty("住址")] 
        public string Address { get; set; }

        /// <summary>
        /// 電話
        /// </summary>
        [JsonProperty("電話")] 
        public string Phone { get; set; }
    }
}