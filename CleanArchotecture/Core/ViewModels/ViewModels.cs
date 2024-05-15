using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels;

public class CategoryAddVm
{
    [Required(ErrorMessage = "Title is Required")]
    public string Title { get; set; }
}

public class CategoryEditVm
{
    [Required(ErrorMessage = "Title is Required")]
    public string Title { get; set; }
    public int Id { get; set; }
}