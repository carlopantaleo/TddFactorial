namespace FactorialTdd;

public class QwertySortableString
{
    private static readonly Dictionary<char, int> QwertyOrder = new();

    static QwertySortableString()
    {
        const string qwertyLayout = "qwertyuiopasdfghjklzxcvbnm";
        for (int i = 0; i < qwertyLayout.Length; i++)
        {
            QwertyOrder.Add(qwertyLayout[i], i);
        }
    }

    public QwertySortableString(string value)
    {
    }

    public static implicit operator QwertySortableString(string value) => throw new NotImplementedException();

    public static implicit operator string(QwertySortableString value) => throw new NotImplementedException();

}
