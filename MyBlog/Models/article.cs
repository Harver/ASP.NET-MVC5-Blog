//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBlog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class article
    {
        public int id { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public string content { get; set; }
        public int cateid { get; set; }
        public System.DateTime time { get; set; }
        public int creator { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual cate cate { get; set; }
    }
}
