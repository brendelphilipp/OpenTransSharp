namespace OpenTransSharp;

/// <summary>
/// (Reference to invoicing party)<br/>
/// <br/>
/// Reference to an unique identifier of the invoicing party.<br/>
/// The element refers to a PARTY_ID in the same document.<br/>
/// <br/>
/// Caution:<br/>
/// If the document is used as a credit memo or advice of amendment (see also INVOICE_TYPE) the refered party of INVOICE_ISSUER_IDREF is additionally the recipient of the benefit/buyer.
/// </summary>
public class InvoiceIssuerIdRef : global::BMEcatSharp.PartyIdRefBase<InvoiceIssuerIdRef>
{
    /// <summary>
    /// <inheritdoc cref="InvoiceIssuerIdRef"/>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public InvoiceIssuerIdRef()
    {
        Value = null!;
    }

    /// <summary>
    /// <inheritdoc cref="InvoiceIssuerIdRef"/>
    /// </summary>
    /// <param name="value"></param>
    public InvoiceIssuerIdRef(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"'{nameof(value)}' cannot be null or whitespace.", nameof(value));
        }

        Value = value;
    }

    /// <summary>
    /// <inheritdoc cref="InvoiceIssuerIdRef"/>
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type">The most common coding standards are predefined - see <see cref="BMEcatSharp.PartyTypeValues"/>.</param>
    public InvoiceIssuerIdRef(string value, string? type)
        : this(value)
    {
        Type = type;
    }

    public static explicit operator global::BMEcatSharp.PartyId(InvoiceIssuerIdRef idRef)
    {
        if (idRef is null)
        {
            return null!;
        }

        return new global::BMEcatSharp.PartyId(idRef.Value, idRef.Type);
    }
}
