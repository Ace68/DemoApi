using System.Text.RegularExpressions;

namespace DemoApi.Shared.CustomTypes;

public partial record CodiceFiscale
{
    // 6 lettere (cognome+nome) | 2 anno | 1 mese | 2 giorno | 1+3 codice comune (Belfiore) | 1 carattere di controllo.
    // Le posizioni numeriche accettano anche le lettere dell'omocodia (L,M,N,P,Q,R,S,T,U,V).
    public const string Pattern =
        "^[A-Z]{6}[0-9LMNPQRSTUV]{2}[ABCDEHLMPRST][0-9LMNPQRSTUV]{2}[A-Z][0-9LMNPQRSTUV]{3}[A-Z]$";

    [GeneratedRegex(Pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)]
    private static partial Regex Validator();

    public string Value { get; }

    public CodiceFiscale(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);

        var normalized = value.Trim().ToUpperInvariant();
        if (!Validator().IsMatch(normalized))
            throw new ArgumentException($"Codice fiscale non valido: '{value}'.", nameof(value));

        Value = normalized;
    }

    public static bool IsValid(string? value) =>
        !string.IsNullOrWhiteSpace(value) && Validator().IsMatch(value.Trim().ToUpperInvariant());

    public override string ToString() => Value;
}
