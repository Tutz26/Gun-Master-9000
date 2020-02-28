using System;
using NUnit.Framework;

namespace Gun_Master_9000{
    [TestFixture]

    class UnitTests {

            [Test, Description("Character without gun can't shoot.")]
        public void NewGunTest() {

                Character arwendariz = new Character("Arwendariz");
                Assert.Throws<System.InvalidOperationException>(

                    () => {
                
                        arwendariz.Shoot(null);

                    }
                );
                
                arwendariz.Shoot(null);

        }
    }
}