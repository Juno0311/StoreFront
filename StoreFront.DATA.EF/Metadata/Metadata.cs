using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF//.Metadata
{
    //internal class Metadata
    //{
    //}

    #region Category
    public class CategoryMetadata
    {
        //since this a PK, we should never see it in a view, or have to enter a value when creating/editing.
        //For those reasons, we will not need to apply any metadata to a PK
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "* Category Name is required")]
        [StringLength(50)]
        [Display(Name = "Category")]
        public string CategoryName { get; set; } = null!;

        [StringLength(500)]
        [Display(Name = "Description")]
        public string? CategoryDescription { get; set; }
    }
    #endregion

    #region Order
    public class OrderMetadata
    {
        //nothing needed - this is a PK
        public int OrderId { get; set; }

        //no metadata needed for FKs - as they are represented in a View by a dropdown list
        public string UserId { get; set; } = null!;

        [StringLength(50)]
        [Display(Name = "City")]
        [Required]
        public string ShipCity { get; set; } = null!;

        [StringLength(2)]
        [Display(Name = "State")]
        public string? ShipState { get; set; }

        [StringLength(5)]
        [Display(Name = "Zip")]
        [Required]
        [DataType(DataType.PostalCode)]
        public string ShipZip { get; set; } = null!;
    }
    #endregion

    #region Product
    public class ProductMetadata
    {
        public int ProductId { get; set; }
        [StringLength(200)]
        [Display(Name = "Item")]
        [Required]
        public string ProductName { get; set; } = null!;
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Price")]
        [Range(0, (double)decimal.MaxValue)]
        [Required]
        public decimal ProductPrice { get; set; }

        [StringLength(500)]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string? ProductDescription { get; set; }
        [Required]
        [Range(0, short.MaxValue)]
        [Display(Name = "In Stock")]
        public short UnitsInStock { get; set; }
        [Required]
        [Range(0, short.MaxValue)]
        [Display(Name = "On Order")]
        public short UnitsOnOrder { get; set; }

        [Display(Name = "Discontinued?")]
        public bool IsDiscontinued { get; set; }

        //fk
        public int CategoryId { get; set; }
        //fk
        public int? SupplierId { get; set; }
        [StringLength(75)]
        [Display(Name = "Image")]
        public string? ProductImage { get; set; }
    }
    #endregion

    #region Supplier
    public class SupplierMetadata
    {
        public int SupplierId { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name = "Supplier")]
        public string SupplierName { get; set; } = null!;

        [Required]
        [StringLength(150)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string City { get; set; } = null!;

        [StringLength(2)]
        public string? State { get; set; }

        [StringLength(5)]
        [DataType(DataType.PostalCode)]
        public string? Zip { get; set; }

        [StringLength(24)]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
    }
    #endregion

    #region UserDetail
    public class UserDetailMetadata
    {
        public string UserId { get; set; } = null!;
        [StringLength(50)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; } = null!;
        [StringLength(150)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? City { get; set; }
        [StringLength(2)]
        public string? State { get; set; }
        [StringLength(5)]
        [DataType(DataType.PostalCode)]
        public string? Zip { get; set; }
        [StringLength(24)]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
    }
    #endregion


}
