using System.ComponentModel.DataAnnotations;

namespace Demo.Sales.SharedKernel.ExternalContracts;

public class RegisterOrderJson
{
    [Required]
    public string CodiceFiscale { get; set; } = string.Empty;
}