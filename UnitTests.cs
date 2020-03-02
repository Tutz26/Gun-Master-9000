using System;
using NUnit.Framework;

namespace Gun_Master_9000{
    [TestFixture]

    class UnitTests {

            [Test, Description("Character without gun can't shoot.")]
        public void NewGunTest() {

                Character arwendariz = new Character("Arwendariz");
                Exception ex = Assert.Throws<System.InvalidOperationException>(

                    () => {
                
                        arwendariz.Shoot(null);

                    }
                );
                
                
                    
        }

            [Test, Description("Character with gun and without target  can't shoot.")]
        public void CharacterWithGunTest() {

                Character arwendariz = new Character("Arwendariz");
                Gun revolver = new Gun("Revolver",6);
                arwendariz.Equip(revolver);
                Exception ex = Assert.Throws<System.ArgumentException>(

                    () => {
                
                        arwendariz.Shoot(null);

                    }
                );
        }
                    
            [Test, Description("Character with gun and with target can shoot only after reloading.")]
        public void CharacterWithoutReloadTest() {

                Character arwendariz = new Character("Arwendariz");
                Gun revolver = new Gun("Revolver",6);
                arwendariz.Equip(revolver);
                Bug bug = new Bug();
                arwendariz.Shoot(bug);
                Assert.That(bug.IsDead(), Is.EqualTo(false));
                arwendariz.Reload();
                arwendariz.Shoot(bug);

                Assert.That(bug.IsDead(), Is.EqualTo(true));
         }
    }
}