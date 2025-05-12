using BlazorDemo.Hyrbid.Shared.Data;

namespace BlazorDemo.Hyrbid.Web.Data;

public class ExamService : IExamService
{
    public async Task<IEnumerable<Exam>> LoadExamData()
    {
        Exam[] exams = [new Exam("HSA", "History", 200)];

        //simulate server work

        await Task.Delay(1000);

        return exams;
    }
}
