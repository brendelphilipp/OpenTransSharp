namespace BMEcatSharp;

[BMEXmlRoot("EMAIL")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class EmailAddress : EmailComponent
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public EmailAddress()
    {
        Value = null!;
    }

    public EmailAddress(string value)
    {
        Value = value;
    }

    [XmlText]
    public string Value { get; set; }
}
