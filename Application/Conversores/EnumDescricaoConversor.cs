using AutoMapper;
using NET.Utils.Extensoes;

namespace Vinculo_Net_Api.Application.Converters;

public class EnumDescricaoConversor : IValueConverter<Enum, string?>
{
    public string? Convert(Enum sourceMember, ResolutionContext context)
    {
    return sourceMember.GetDescription();
    }
}