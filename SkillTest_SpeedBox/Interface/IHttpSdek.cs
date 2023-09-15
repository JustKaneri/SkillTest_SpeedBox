using SkillTest_SpeedBox.Models;

namespace SkillTest_SpeedBox.Interface
{
    public interface IHttpSdek
    {
        /// <summary>
        /// Calculation of shipping costs
        /// </summary>
        /// <param name="item">order</param>
        /// <returns>Return price or in case of an error return object with message error/returns>
        public Task<object> CalculetPrice(Order item);

        public Task<int> GetCodeSity(string fias);
    }
}
