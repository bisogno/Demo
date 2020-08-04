using AutoMapper;
using DemoDomain.Alunos.Interfaces.Repositories;
using DemoDTO;
using DemoNotification;

namespace DemoDomain.Alunos
{
    public class Aluno : DomainBase
    {
        private readonly INotificationHandler _notificationHandler;

        internal Aluno(CreateAlunoRequestDTO alunoRequestDTO, INotificationHandler notificationHandler, IMapper mapper)
        {
            _notificationHandler = notificationHandler;
            mapper.Map(alunoRequestDTO, this);
            Specify();
        }

        internal Aluno(UpdateAlunoRequestDTO alunoRequestDTO, INotificationHandler notificationHandler, IMapper mapper, IAlunoRepository alunoRepository)
        {
            _notificationHandler = notificationHandler;
            var alunoFromDataBase = alunoRepository.GetById(alunoRequestDTO.Id);
            mapper.Map(alunoRequestDTO, alunoFromDataBase);
            mapper.Map(alunoFromDataBase, this);
            Specify();
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        private bool isValid = false;
        public override bool IsValid => isValid;

        public override void Specify()
        {
            isValid = true;
            var alunoSpecifications = new AlunoSpecifications();
            foreach (var alunoSpecification in alunoSpecifications)
            {
                var condition = alunoSpecification.IsValid();
                if (!condition(this))
                {
                    isValid = false;
                    _notificationHandler.DefaultBuilder()
                        .WithCode(alunoSpecification.Code)
                        .WithMessage(alunoSpecification.Message)
                        .WithDetail(alunoSpecification.DetailMessage)
                        .RaiseNotification();
                }
            }
        }
    }
}
