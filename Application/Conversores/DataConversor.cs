using AutoMapper;

namespace Vinculo_Net_Api.Application.Converters
{
    public class DataConversor : IValueConverter<DateTime, string?>
    {
        public string? Convert(DateTime sourceMember, ResolutionContext context)
        {
            return sourceMember.ToString("dd/MM/yyyy");
        }
    }
}