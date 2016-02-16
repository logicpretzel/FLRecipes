using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FLRecipes.Models
{
    /// <summary>
    /// Author: Dar Dunham
    /// Date: 2/15/16
    /// Model
    /// </summary>
    public class Image
    {
        public int ID { get; set; }
        public int SubscriberID { get; set; }
        public int FileSize { get; set; }
        public string FileName { get; set; }
        public byte[] ImageData { get; set; }
        //[Required(ErrorMessage="Please Select Image File")]
        //public HttpPostedFileBase File { get; set; }


    }
}
