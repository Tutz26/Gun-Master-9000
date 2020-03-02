using System;
using NUnit.Framework;
using System.Collections.Generic;

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

            [Test, Description("Minigun can be used as a gun.")]
            public void MinigunTest() {

                    // Gun[] guns = new Gun[2];
                    List<Gun> guns = new List<Gun>();

                    Gun minigun = new Minigun("Minigun MK1", 3000);
                    Gun revolver = new Gun("Revolver", 6);
                    guns.Add(minigun);
                    guns.Add(revolver);

                    Bug bug = new Bug();

                    guns[0].Shoot(bug);

                    Assert.That(bug.IsDead(), Is.EqualTo(true));

                    Assert.Throws<System.InvalidOperationException>(
                        () => {
                            guns[0].Reload();
                        }

                    );
                    guns[1].Reload();
            }

    }
}