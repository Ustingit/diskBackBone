using System;

namespace DiscountPoolBackbone.Models.TOP.enums
{
    [Flags]
    public enum TopItemType
    {
        Picture = 1,
        Wood = 2,
        Adult = 4,
        Other = 8,
        Seewing = 16, //шитьё и вязание
        Texts = 32,
        Photos = 64
    }
}
