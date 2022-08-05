using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TechJobsPersistentAutograded.Controllers;
using TechJobsPersistentAutograded.ViewModels;
using Xunit;

namespace TaskTwo.Tests
{
    public class AddJobViewModelTests
    {
        [Fact]
        public void AddJobViewModel_ContainsCorrectNumberOfProperties()
        {
            //arrange
            Type testAJVM = typeof(AddJobViewModel);
            PropertyInfo[] infos = testAJVM.GetProperties();

            //assert
            Assert.Equal(5, infos.Length);
            //Should have Name, EmployerId, Employers, SkillId, & Skills
        }

        [Fact]
        public void AddJobViewModel_ContainsTwoConstructors()
        {
            Type testAJVM = typeof(AddJobViewModel);
            ConstructorInfo[] cInfo = testAJVM.GetConstructors();
            List<ConstructorInfo> cList = new List<ConstructorInfo>();

            foreach(var c in cInfo)
            {
                cList.Add(c);
            }

            Assert.Equal(2, cInfo.Length);
            // one should take a list of employers and a list of skills
            // other should be empty
            
        }

    }
}
