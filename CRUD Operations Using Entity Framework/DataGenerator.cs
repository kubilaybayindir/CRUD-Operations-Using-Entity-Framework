using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFramework.Services.FakeData;
namespace CRUD_Operations_Using_Entity_Framework
{
    
    public class DataGenerator
    {
        EFProductDBEntities db = new EFProductDBEntities();

        public void CategoryGenerate()
        {
            List<Category> categories = new List<Category>();

            Category category = new Category();
            for (int i = 0; i < 10; i++)
            {
                //category.Name=
                //categories.Add(Category );
            }
             

            //db.Category.Create();
        }





    }
}
