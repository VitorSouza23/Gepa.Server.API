using Gepa.Server.Entity.Calendar.SchoolCalendarModule;
using Gepa.Server.Entity.Validator.Exceptions;
using Gepa.Service.Entity.Base.Abstractions.Calendar;
using System.Collections.Generic;
using Xunit;

namespace Gepa.Server.Entity.Tests.Calendar.SchoolCalendarModule.SchoolCalendarTests
{
    public class SchoolCalendarCtroTests
    {
        [Fact]
        public void RetornaUmObjetoNaoNuloDadoAConstrucaoCorretaDoObjeto()
        {
            //Arrange
            long ID = 1;
            string observation = "Observation";
            string name = "Name";
            IList<ISchoolEvent> schoolEvents = new List<ISchoolEvent>();
            long teacherID = 2;

            //Act
            ISchoolCalendar schoolCalendar = SchoolCalendar.Factory
                .SetID(ID)
                .SetName(name)
                .SetObservation(observation)
                .SetSchoolEvents(schoolEvents)
                .SetTeacherID(teacherID)
                .Build();

            //Assert
            Assert.NotNull(schoolCalendar);
        }

        [Fact]
        public void LancaExcecaoDeFalhaDeValidacaoAoTentarConstruirObjetoComFalhasDeValidacao()
        {
            //Assert
            Assert.Throws<RuleNotValidException>(() =>
                //Act
                SchoolCalendar.Factory.Build()
            );
        }
    }
}
