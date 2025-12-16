namespace OpenTransSharp;

/// <summary>
/// (Reference to the recipient of the invoice)<br/>
/// <br/>
/// Reference to an unique identifier to the recipient of the invoice.<br/>
/// The element refers to a PARTY_ID of an invoice recipient in the same document.<br/>
/// <br/>
/// Caution:<br/>
/// If the document is used as a credit memo or advice of amendment (see also INVOICE_TYPE) the refered party of INVOICE_RECIPIENT_IDREF is also the supplier.
/// </summary>
public class InvoiceRecipientIdRef : global::BMEcatSharp.PartyIdRefBase<InvoiceRecipientIdRef>
{
    /// <summary>
    /// <inheritdoc cref="InvoiceRecipientIdRef"/>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public InvoiceRecipientIdRef()
    {
        Value = null!;
    }

    /// <summary>
    /// <inheritdoc cref="InvoiceRecipientIdRef"/>
    /// </summary>
    /// <param name="value"></param>
    public InvoiceRecipientIdRef(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"'{nameof(value)}' cannot be null or whitespace.", nameof(value));
        }

        Value = value;
    }

    /// <summary>
    /// <inheritdoc cref="InvoiceRecipientIdRef"/>
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type">The most common coding standards are predefined - see <see cref="BMEcatSharp.PartyTypeValues"/>.</param>
    public InvoiceRecipientIdRef(string value, string? type)
        : this(value)
    {
        Type = type;
    }

    public static explicit operator global::BMEcatSharp.PartyId(InvoiceRecipientIdRef idRef)
    {
        if (idRef is null)
        {
            return null!;
        }

        return new global::BMEcatSharp.PartyId(idRef.Value, idRef.Type);
    }
}
