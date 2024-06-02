using AutoMapper;

namespace Vinculo_Net_Api.Application.Converters
{
    public class CodigoEstruturadoConversor : IValueConverter<string, string?>
    {
        public string? Convert(string sourceMember, ResolutionContext context)
        {
            return sourceMember != null 
                ? $"{sourceMember[..(sourceMember.Length / 2 + 2)]}/{sourceMember[(sourceMember.Length / 2 + 2)..]}" 
                : null;
        }
    }
}