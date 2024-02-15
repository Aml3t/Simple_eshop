using Microsoft.AspNetCore.Mvc;
using Simple_Eshop.Controllers;
using Simple_Eshop.ViewModels;
using SimpleEshopTests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEshopTests.Controllers
{
    public class PieControllerTests
    {
        [Fact]
        public void List_EmptyCategory_ReturnsAllPies()
        {
            //Arrange
            var mockPieRepository = RepositoryMocks.GetPieRepository();
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();

            var pieController = new PieController(mockPieRepository.Object, mockCategoryRepository.Object);

            //Act
            var result = pieController.List("");

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var pieListViewModel = Assert.IsAssignableFrom<PieListViewModel>
                (viewResult.ViewData.Model);
            Assert.Equal(10, pieListViewModel.Pies.Count());

        }
    }
}
