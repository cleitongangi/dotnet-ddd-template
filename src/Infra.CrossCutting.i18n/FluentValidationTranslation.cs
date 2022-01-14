namespace Infra.CrossCutting.i18n
{
    public class FluentValidationTranslation : FluentValidation.Resources.LanguageManager
    {
        public FluentValidationTranslation()
        {
            AddTranslation("pt-BR", "NotNullValidator", "[{PropertyName}] é obrigatório.");
            AddTranslation("pt-BR", "EmailValidator", "[{PropertyName}] inválido.");
            AddTranslation("pt-BR", "GreaterThanOrEqualValidator", "[{PropertyName}] deve ser superior ou igual a '{ComparisonValue}'.");
            AddTranslation("pt-BR", "GreaterThanValidator", "[{PropertyName}] deve ser superior a '{ComparisonValue}'.");
            AddTranslation("pt-BR", "LengthValidator", "[{PropertyName}] deve ser um texto com no mínimo {MinLength} caracteres e no máximo {MaxLength} caracteres. Você informou {TotalLength} caracteres.");
            AddTranslation("pt-BR", "MinimumLengthValidator", "[{PropertyName}] deve um texto com no mínimo {MinLength} caracteres. Você informou {TotalLength} caracteres.");
            AddTranslation("pt-BR", "MaximumLengthValidator", "[{PropertyName}] deve ser um texto com no máximo {MaxLength} caracteres. Você informou {TotalLength} caracteres.");
            AddTranslation("pt-BR", "LessThanOrEqualValidator", "[{PropertyName}] deve ser inferior ou igual a '{ComparisonValue}'.");
            AddTranslation("pt-BR", "LessThanValidator", "[{PropertyName}] deve ser inferior a '{ComparisonValue}'.");
            AddTranslation("pt-BR", "NotEmptyValidator", "[{PropertyName}] é obrigatório.");
            AddTranslation("pt-BR", "NotEqualValidator", "[{PropertyName}] deve ser diferente de '{ComparisonValue}'.");
            AddTranslation("pt-BR", "NotNullValidator", "[{PropertyName}] é obrigatório.");
            AddTranslation("pt-BR", "PredicateValidator", "[{PropertyName}] não atende a condição definida.");
            AddTranslation("pt-BR", "AsyncPredicateValidator", "[{PropertyName}] não atende a condição definida.");
            AddTranslation("pt-BR", "RegularExpressionValidator", "[{PropertyName}] com formato inválido.");
            AddTranslation("pt-BR", "EqualValidator", "[{PropertyName}] deve ser igual a '{ComparisonValue}'.");
            AddTranslation("pt-BR", "ExactLengthValidator", "[{PropertyName}] deve ser um texto com {MaxLength} caracteres. Você informou {TotalLength} caracteres.");
            AddTranslation("pt-BR", "ExclusiveBetweenValidator", "[{PropertyName}] deve estar entre {From} e {To}. Você informou {Value}.");
            AddTranslation("pt-BR", "InclusiveBetweenValidator", "[{PropertyName}] deve estar entre {From} e {To}. Você informou {Value}.");
            AddTranslation("pt-BR", "CreditCardValidator", "[{PropertyName}] inválido.");
            AddTranslation("pt-BR", "ScalePrecisionValidator", "[{PropertyName}] não pode ter mais do que {ExpectedPrecision} dígitos no total, com {ExpectedScale} dígitos decimais. {Digits} dígitos e {ActualScale} decimais foram informados.");
            AddTranslation("pt-BR", "EmptyValidator", "[{PropertyName}] deve estar vazio.");
            AddTranslation("pt-BR", "NullValidator", "[{PropertyName}] deve estar null.");
            AddTranslation("pt-BR", "EnumValidator", "[{PropertyName}] possui um intervalo de valores que não inclui '{PropertyValue}'.");
        }
    }
}
