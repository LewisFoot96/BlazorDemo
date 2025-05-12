namespace BlazorDemo.Hyrbid.Shared.Data;

public interface IExamService
{
    Task<IEnumerable<Exam>> LoadExamData();
}
