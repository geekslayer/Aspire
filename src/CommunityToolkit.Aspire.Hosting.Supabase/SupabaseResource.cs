
namespace Aspire.Hosting.ApplicationModel;

/// <summary>
/// 
/// </summary>
/// <param name="name"></param>
/// <param name="supabaseUrl"></param>
/// <param name="supabaseKey"></param>
public class SupabaseResource(string name, string supabaseUrl, string supabaseKey): Resource(name)
{
    internal string SupabaseUrl { get; } = supabaseUrl;
    
    internal string SupabaseKey { get; } = supabaseKey;
}