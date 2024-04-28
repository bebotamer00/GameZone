using System.ComponentModel.DataAnnotations;

namespace GameZone.Filters
{
    public class MaxFileSizeAttribute(int maxFileSize) : ValidationAttribute
    {
        private readonly int _maxFileSize = maxFileSize;

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is IFormFile file && file.Length > _maxFileSize)
                return new ValidationResult($"Maximum allowed size is {_maxFileSize} bytes.");

            return ValidationResult.Success;
        }
    }
}
