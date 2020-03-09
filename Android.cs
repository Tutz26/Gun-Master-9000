using System;

namespace Gun_Master_9000{

 class Android : DodgingTarget {

        bool isDodging = false;
        bool dead = false;

        int lives = 9;

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

            this.lives -= 1;
                if(lives == 0){
                this.dead = true;
                } else {
                   Console.WriteLine("Remaining lives {0}", this.lives);
                }

        }

        public void Miss(){
            this.isDodging = false;

        }


            }

}
