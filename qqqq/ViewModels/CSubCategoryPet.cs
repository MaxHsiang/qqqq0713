using qqqq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.ViewModels
{
    public class CSubCategoryPet
    {
        public SubCategory _subCategory;
        public CSubCategoryPet()
        {
            _subCategory = new SubCategory();
        }
        public CSubCategoryPet(SubCategory subcategory)
        {
            SubCategory = subcategory;
        }

        public SubCategory SubCategory
        {
            get { return _subCategory; }
            set { _subCategory = value; }
        }

        [DisplayName("序號")]
        public int SubCategoryId
        {
            get { return _subCategory.SubCategoryId; }
            set { _subCategory.SubCategoryId = value; }
        }

        [DisplayName("品種")]
        public string SubCategoryName
        {
            get { return _subCategory.SubCategoryName; }
            set { _subCategory.SubCategoryName = value; }
        }
        public int CategoryId
        {
            get { return _subCategory.CategoryId; }
            set { _subCategory.CategoryId = value; }
        }

        [DisplayName("類別")]
        public string CategoryName
        {
            get { return _subCategory.Category.CategoryName; }
            set { _subCategory.Category.CategoryName = value; }
        }
  

    }
}
