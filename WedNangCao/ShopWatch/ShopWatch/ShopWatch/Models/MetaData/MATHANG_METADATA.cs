using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ShopWatch.Models.MetaData
{
    public class MATHANG_METADATA {

        public int MAMATHANG { get; set; }
        [Required(ErrorMessage = "Please enter the Name")]
        public string TENHANG { get; set; }
        /* [Required(ErrorMessage = "Please choose Image")]*/
        public string ANHSANPHAM { get; set; }
        [Required(ErrorMessage = "Please Enter date")]
        
        public Nullable<double> GIAHANG { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập LOAI.")]
        public string LOAI { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập BẢO HÀNH")]
        public string BAOHANH { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn kich thược")]
        public string KICHTHUOC { get; set; }

    }
}