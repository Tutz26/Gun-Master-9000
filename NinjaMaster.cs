using System;

namespace Gun_Master_9000{

 class NinjaMaster : DodgingTarget {

        bool isDodging = false;
        bool dead = false;

         public void Shot() {
            if(this.isDodging){
                this.Miss();
            }

        }

        public bool IsDead() {
            return this.dead;

        }

        public void Dodge(){
            this.isDodging = true;

        }

        public void Hit(){
            this.dead = false;

        }

        public void Miss(){
            Console.WriteLine("The ninja master always dodges!.");

        }


    }

}
