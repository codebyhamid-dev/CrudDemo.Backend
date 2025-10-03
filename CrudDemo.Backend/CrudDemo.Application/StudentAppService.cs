using AutoMapper;
using CrudDemo.Backend.CrudDemo.Contracts;
using CrudDemo.Backend.CrudDemo.Domain;
using CrudDemo.Backend.CrudDemo.EFCoreDbContext;
using Microsoft.EntityFrameworkCore;

namespace CrudDemo.Backend.CrudDemo.Application
{
    public class StudentAppService : IStudentAppService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public StudentAppService(AppDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<StudentDto> CreateAsync(StudentCreateDto input)
        {
            var student= _mapper.Map<Student>(input);
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return _mapper.Map<StudentDto>(student);
        }

        public async Task DeleteAsync(Guid id)
        {
            var student = await  _context.Students.FindAsync(id);
            if(student==null)
            {
                throw new Exception("Student not found");
            }
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }

        public async Task<StudentDto> GetAsync(Guid id)
        {
            var student=await _context.Students.FindAsync(id);
            if(student==null)
            {
                throw new Exception("Student not found");
            }
            return _mapper.Map<StudentDto>(student);
        }

        public async Task<List<StudentDto>> GetListAsync()
        {
            var students= await _context.Students.ToListAsync();
            return _mapper.Map<List<StudentDto>>(students);
        }

        public async Task<StudentDto> UpdateAsync(Guid id, StudentUpdateDto input)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                throw new Exception("Student not found");
            }
            var updatedStudent = _mapper.Map(input, student);
            await _context.SaveChangesAsync();
            return _mapper.Map<StudentDto>(updatedStudent);
        }
    }
}
