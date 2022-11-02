using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoreFront.DATA.EF.Models//.Metadata
{
    
        //internal class Partials
        //{
        //}

        #region Category
        [ModelMetadataType(typeof(CategoryMetadata))]
        public partial class Category { }
        #endregion

        #region Order
        [ModelMetadataType(typeof(OrderMetadata))]
        public partial class Order { }
        #endregion

        #region Product
        [ModelMetadataType(typeof(ProductMetadata))]
        public partial class Product
        {
            [NotMapped]
            public IFormFile? Image { get; set; }
        }
        #endregion

        #region Supplier
        [ModelMetadataType(typeof(SupplierMetadata))]
        public partial class Supplier { }
        #endregion

        #region UserDetail
        [ModelMetadataType(typeof(UserDetailMetadata))]
        public partial class UserDetail
        {
            public string FullName { get { return $"{FirstName} {LastName}"; } }
        }
        #endregion


    
}
