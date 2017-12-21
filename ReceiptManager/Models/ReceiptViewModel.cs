using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ReceiptManager.Models
{
    public class ReceiptViewModel
    { 
        public ObjectId _id { get; set; }
        [Display(Name="發票號碼")]
        public string RecNo { get; set; }
        [Display(Name = "商家")]
        public string Store { get; set; }
        [Display(Name = "時間")]
        public DateTime Date { get; set; }
        [Display(Name = "金額")]
        public int Price { get; set; }
        [Display(Name = "註記")]
        public string Memo { get; set; }
    }
    public class ReceiptAddViewModel
    {
        public string RecNo { get; set; }
        public string Store { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public string Memo { get; set; }
    }
}