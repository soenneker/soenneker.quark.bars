using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// Bar type enumeration.
/// </summary>
[Intellenum<string>]
public sealed partial class BarType
{
    public static readonly BarType Navbar = new("navbar");
    public static readonly BarType Header = new("header");
    public static readonly BarType Footer = new("footer");
    public static readonly BarType Toolbar = new("toolbar");
}
