namespace CrudDemo.Backend.CrudDemo.Contracts
{
    public interface IStudentAppService
    {
        Task<StudentDto> CreateAsync(StudentCreateDto input);
        Task<StudentDto> GetAsync(Guid id);
        Task<List<StudentDto>> GetListAsync();
        Task<StudentDto> UpdateAsync(Guid id, StudentUpdateDto input);
        Task DeleteAsync(Guid id);
    }
}
