namespace Ucu.Poo.TestDateFormat;


/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        if(string.IsNullOrEmpty(date)){
            return "Error: Invalid date";
        }
        if(!(date[2].Equals('/') && date[5].Equals('/'))){
            return "Error: Invalid format";
        }
        foreach (char c in (date.Substring(0,2)+date.Substring(3,2)+date.Substring(6)))
        {
            if(!char.IsDigit(c)){
                return "Error: Invalid date";
            }
        }
        
        string stringDays = date.Substring(0, 2);
        int days = Convert.ToInt32(stringDays);
        if(days>31)
        {
            return "Error: Invalid day";
        }
        string stringMonths = date.Substring(3, 2);
        int months = Convert.ToInt32(stringMonths);
        if(months>12)
        {
            return "Error: Invalid month";
        }
        if (months == 1 || months == 3 || months == 5 || months == 7 || months == 8 || months == 10 || months == 12 && days>31)
        {
            return "Error: Invalid date";
        }
        
        if ((months == 2 && days>29) || (months == 4 || months == 6 || months == 9 || months == 11 && days>30))
        {
            return "Error: Invalid date";
        }
        
        
        return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
    }
}
