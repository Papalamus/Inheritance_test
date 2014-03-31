using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training
{
    class Test
    {
        public void UserTest()
        {
            User user = new User()
            {
                Name = "Peka",
                Surname = "Lonely",
                Birthday = DateTime.Parse("2008-05-01T07:34:42-5:00")
            };
            System.Windows.Forms.MessageBox.Show(user.ToString());
        }
        public void EmployeeTest()
        {
            User employee= new Employee()
            {
                Name = "Peka",
                Surname = "Lonely",
                Birthday = DateTime.Parse("2008-05-01T07:34:42-5:00"),
                Expirience = (DateTime.Now -
                    DateTime.Parse("2012-05-01T07:34:42-5:00")),
                Post = "Manager"

            };
            System.Windows.Forms.MessageBox.Show(employee.ToString());
        }

        public void GraphicTest()
        {
                    
        }

    }
}
