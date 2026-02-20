using static System.Console;

int entryDays, days, months, years;

WriteLine($"Digite o número de dias: ");
entryDays = int.Parse(ReadLine());

years = entryDays/365;
months = (entryDays%365)/30;
days = (entryDays%365)/12;

WriteLine($"Anos: {years}");
WriteLine($"Meses: {months}");
WriteLine($"Dias: {days}");



