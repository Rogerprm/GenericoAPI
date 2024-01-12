using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using AspNetCore.IQueryable.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using System.ComponentModel.DataAnnotations;

namespace Generico.Application.Registro
{
    public class RegistroBolsaFamiliaFilter : ICustomQueryable, IQueryPaging, IQuerySort
    {
        [Display(Name = "UF")]
        [QueryOperator(Operator = WhereOperator.Contains)]
        public string[]? UF { get; set; }

        [Display(Name = "Nome do Favorecido")]
        [QueryOperator(Operator = WhereOperator.Contains)]
        public string? NomeFavorecido { get; set; }



        public int? Limit { get; set; } = 10;
        public int? Offset { get; set; }
        public string? Sort { get; set; }  
    }
}
