﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopWatch.Models.MetaData
{

    public  class TAIKHOAN_METADATA
    {
        [Key]
        [Required(ErrorMessage = "Please enter the Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EMAIL { get; set; }
        [Required(ErrorMessage = "Please enter the tenhienthi")]
        public string TENDANGNHAP { get; set; }
        [Required(ErrorMessage = "Please enter the password")]
        public string MATKHAU { get; set; }
        [Required(ErrorMessage = "Please enter the xac minh")]
        public string XACTHUC  { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


