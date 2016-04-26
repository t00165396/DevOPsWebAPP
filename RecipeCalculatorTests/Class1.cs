using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RecipeCalculator;

namespace RecipeCalculatorTests
{
    [TestFixture]
    public class Class1
    {

        const double DEFAULT_UNIT_SIZE = 1.0;
        [Test]

        public void AddServingShouldIncreaseUnitSize()
        {
            //Arrange
            Ingredient control = new Garlic(null, DEFAULT_UNIT_SIZE);
            Ingredient recipe = new Garlic(null, DEFAULT_UNIT_SIZE);

            //Assert
            Assert.IsTrue(control.Units == DEFAULT_UNIT_SIZE);
            Assert.IsTrue(recipe.Units == DEFAULT_UNIT_SIZE);

            //Act
            recipe.addServing(DEFAULT_UNIT_SIZE);

            //Assert
            Assert.IsTrue(recipe.Units > control.Units);
            Assert.IsTrue(recipe.Units == (DEFAULT_UNIT_SIZE * 2));
        }
    }
}
