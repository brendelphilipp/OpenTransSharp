namespace OpenTransSharp;

/// <summary>
/// (Reference to a remittee)<br/>
/// <br/>
/// Refers to a unique identifier of the remittee.<br/>
/// The elemente refers to the PARTY_ID of the remittee in the same document.<br/>
/// <br/>
/// XML-namespace: OpenTrans
/// </summary>
public class RemitteeIdRef : global::BMEcatSharp.PartyIdRefBase<RemitteeIdRef>
{
    /// <summary>
    /// <inheritdoc cref="RemitteeIdRef"/>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RemitteeIdRef()
    {
        Value = null!;
    }

    public RemitteeIdRef(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"'{nameof(value)}' cannot be null or whitespace.", nameof(value));
        }

        Value = value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type">The most common coding standards are predefined - see <see cref="BMEcatSharp.PartyTypeValues"/>.</param>
    public RemitteeIdRef(string value, string? type)
        : this(value)
    {
        Type = type;
    }

    public static explicit operator global::BMEcatSharp.PartyId(RemitteeIdRef idRef)
    {
        if (idRef is null)
        {
            return null!;
        }

        return new global::BMEcatSharp.PartyId(idRef.Value, idRef.Type);
    }
}
