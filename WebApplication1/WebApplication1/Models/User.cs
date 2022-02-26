using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {

        [ScaffoldColumn(false)]
        public long id { get; set; }
        [Required(ErrorMessage = "Xin mời bạn nhập vào")]
        [StringLength(maximumLength: 50, ErrorMessage = "Yêu cầu nhập từ 4 - 50 kí tự", MinimumLength = 4)]
        //[RegularExpression(@"[A-Za-z\s]+")]
        [RegularExpression(@"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂẾưăạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s\W|_]+", ErrorMessage = "Tên việt nam")] //https://www.regextester.com/115897
        public string name { get; set; }
        [Required(ErrorMessage = "Xin mời bạn nhập vào")]
        [RegularExpression(@"^([A-Za-z0-9_.]+)\@+(gmail|outlook|icloud|hotmail)*(.com|.uk|.vn|.us)$", ErrorMessage = "Sai định dạng email VD: tenEmail@gmail|outlook|icloud|hotmail.com|uk|vn|us")]
        public string email { get; set; }
        [Required(ErrorMessage = "Xin mời bạn nhập vào")]
        [RegularExpression(@"(84|0[3|5|7|8|9])+([0-9]{8})\b", ErrorMessage = "Nhập đúng theo dạng số +84 của việt nam")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Hãy nhập đúng 10 kí tự")]
        public string phoneNumber { get; set; }


    }
}