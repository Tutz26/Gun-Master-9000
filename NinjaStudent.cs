using System;

namespace Gun_Master_9000{

 class NinjaStudent : DodgingTarget {

        bool isDodging = false;
        bool dead = false;

         public void Shot() {
            if(this.isDodging){
                this.Miss();
            } else {
                this.Hit();
            }

        }

        public bool IsDead() {
            return this.dead;

        }

        public void Dodge(){
            this.isDodging = true;

        }

        public void Hit(){
            this.isDodging = true;
            this.dead = false;
            Console.WriteLine("Was Hit, dodging again");

        }

        public void Miss(){
            this.isDodging = false;

        }


            }

}
