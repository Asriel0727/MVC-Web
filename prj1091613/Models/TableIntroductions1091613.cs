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

    public partial class TableIntroductions1091613
    {
        [DisplayName("姓名")]
        [Required(ErrorMessage = "姓名不可空白")]
        public string IName { get; set; }

        [DisplayName("帳號")]
        [StringLength(15, ErrorMessage = "帳號必須是3~15個字元", MinimumLength = 3)]
        public string IID { get; set; }

        [DisplayName("性別")]
        public string IGrander { get; set; }

        [DisplayName("信箱")]
        [EmailAddress(ErrorMessage = "E-Mail格式有誤")]
        public string IMail { get; set; }

        [DisplayName("生日")]
        [DataType(DataType.Date, ErrorMessage = "生日必須為日期格式")]
        public Nullable<System.DateTime> IDate { get; set; }

        [DisplayName("畢業/就讀學校")]
        public string ISchool { get; set; }

        [DisplayName("自我介紹")]
        [StringLength(20, ErrorMessage = "自我介紹最多20字", MinimumLength = 0)]
        public string Iabout { get; set; }
    }
}
