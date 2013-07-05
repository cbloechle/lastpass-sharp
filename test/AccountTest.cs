using NUnit.Framework;

namespace LastPass.Test
{
    [TestFixture]
    class AccountTest
    {
        [Test]
        public void Accout_properties_are_set()
        {
            var id = "1234567890";
            var name = "name";
            var username = "username";
            var password = "password";
            var url = "url";

            var account = new Account(id, name, username, password, url);
            Assert.AreEqual(id, account.Id);
            Assert.AreEqual(name, account.Name);
            Assert.AreEqual(username, account.Username);
            Assert.AreEqual(password, account.Password);
            Assert.AreEqual(url, account.Url);
        }
    }
}