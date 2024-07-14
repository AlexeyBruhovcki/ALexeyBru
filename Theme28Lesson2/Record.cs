using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme28Lesson2
{
    internal class Record
    {
        private string? login;
        private string? password;

        public Record(string? login, string? password)
        {
            this.login = login;
            this.password = password;
        }
        public string getLogin() => login!;
        public string getPass() => password!;
        public void setLogin(string? login) => this.login = login;
        public void setPass(string? password) => this.password = password;
    }
}
