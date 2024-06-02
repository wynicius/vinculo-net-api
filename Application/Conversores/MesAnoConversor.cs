using AutoMapper;

namespace Vinculo_Net_Api.Application.Converters
{
    public class MesAnoConversor : IValueConverter<DateTime, string?>
    {
        public string? Convert(DateTime sourceMember, ResolutionContext context)
        {
            return sourceMember.ToString("MM/yyyy");
        }
    }
}