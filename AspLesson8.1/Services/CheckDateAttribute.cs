using System.ComponentModel.DataAnnotations;

namespace AspLesson8._1.Services
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter,
     AllowMultiple = false)]
    public class CheckDateAttribute : ValidationAttribute
    {
        public List<DayOfWeek> Days { get;}

        public CheckDateAttribute(params DayOfWeek[] days)
        {
            Days = days.ToList();
        }

        public override bool IsValid(object? value)
        {
            if (value == null) return false;
            if (value is DateTime date)
            {
                foreach(DayOfWeek day in Days)
                {
                    if (date.DayOfWeek == day)
                    {
                        ErrorMessage = "У вихідні лікар не працює, виберіть робочий день";
                        return false;
                    }
                }
                return true;
                
            }
            return false;
        }
    }
}
