//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prj1091613.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class TableTravel1091613
    {
        [DisplayName("會員帳號")]
        [StringLength(15, ErrorMessage = "帳號必須是3~15個字元", MinimumLength = 3)]
        public string TId { get; set; }

        [DisplayName("行程編號")]
        [StringLength(5, ErrorMessage = "編號為5個字", MinimumLength = 5)]
        public string TNo { get; set; }

        [DisplayName("行程名稱")]
        [StringLength(15, ErrorMessage = "最多15字", MinimumLength = 0)]
        public string TName { get; set; }

        [DisplayName("起始日期")]
        [DataType(DataType.Date, ErrorMessage = "日期必須為日期格式")]
        public Nullable<System.DateTime> TDateStart { get; set; }

        [DisplayName("結束日期")]
        [DataType(DataType.Date, ErrorMessage = "日期必須為日期格式")]
        public Nullable<System.DateTime> TDateEnd { get; set; }
    }
}
