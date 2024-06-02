using System.Globalization;
using AutoMapper;

namespace Vinculo_Net_Api.Application.Converters
{
    public class MoedaRealConversor : IValueConverter<decimal, string?>
    {
        public string? Convert(decimal sourceMember, ResolutionContext context)
        {
            return sourceMember != 0 
                ? sourceMember.ToString("c2")
                : null;
        }
    }
}