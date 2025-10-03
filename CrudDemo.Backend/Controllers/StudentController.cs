using CrudDemo.Backend.CrudDemo.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudDemo.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentAppService _studentAppService;
        public StudentController(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }
        // POST: api/Student    
        [HttpPost("add-student")]
        public async Task<StudentDto> CreateAsync(StudentCreateDto input)
        {
            return await _studentAppService.CreateAsync(input);
        }
        [HttpGet("get-all-students")]
        public async Task<List<StudentDto>> GetListAsync()
        {
            return await _studentAppService.GetListAsync();
        }
        [HttpGet("get-student-by/{id}")]
        public async Task<StudentDto> GetAsync(Guid id)
        {
            return await _studentAppService.GetAsync(id);
        }
        [HttpPut("update-student-by/{id}")]
        public async Task<StudentDto> UpdateAsync(Guid id, StudentUpdateDto input)
        {
            return await _studentAppService.UpdateAsync(id, input);
        }
        [HttpDelete("delete-student-by/{id}")]
        public async Task DeleteAsync(Guid id)
        {
            await _studentAppService.DeleteAsync(id);
        }
    }
}
