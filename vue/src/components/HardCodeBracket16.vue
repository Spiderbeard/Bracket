<template>
  <div class="">
         <div class= "headers container">
            <div class="row">
              <span class="top-row col-sm">Round 1</span>
              <span class="top-row col-sm">Round 2</span>
              <span class="top-row col-sm">Round 3</span>
              <span class="top-row col-sm">Round 4</span>
              <span class="top-row col-sm">CHAMPION</span>
            </div>
        </div>
      <div class = "bracket-16 container d-flex " >
          
            <div class = "Round flex-column d-flex align-center ">
                <div
            class="match w-100 "
            v-for="(match, index) in this.constuctMatches"
            v-bind:key="match.index"
            >
            <div class="team-top w-75">
                <input
                class="w-50"
                type="text" v-model="team[index]"
                
                :placeholder="[[$store.state.Participants[index].id]]"
                />
            </div>
            <div v-if="isLastOddElement(index)" class="team-bottom w-75">
                <input
                
                type="text" 
                class="w-50"
                v-model="team[$store.state.Participants.length - index - 1]"
                :placeholder="[
                    [
                    $store.state.Participants[
                        $store.state.Participants.length - index - 1
                    ].id,
                    ],
                ]"
                />
            </div>
           <br/>
            </div>
            </div>
            <div class = "Round d-flex flex-sm-column  justify-content-around ml-5  " >                   
                    <div class= "match border border-dark">
                        <div class = "team-top border-bottom border-dark">
                            greg
                        </div>                       
                        <div class = "team-botom ">
                            jim
                        </div>
                    </div>               
                    <div class= "match border border-dark">
                        <div class = "team-top border-bottom border-dark">
                            joe
                        </div>                       
                        <div class = "team-botom ">
                            george
                        </div>
                    </div>                    
                    <div class= "match border border-dark">
                        <div class = "team-top border-bottom border-dark">
                            nick
                        </div>
                        
                        <div class = "team-botom ">
                            jess
                        </div>
                    </div>                   
                    <div class= "match border border-dark">
                        <div class = "team-top border-bottom border-dark">
                            rachel
                        </div>
                        
                        <div class = "team-botom ">
                            nick
                        </div>
                    </div>                
            </div>
            <div class="d-flex w-75 justify-content-around">
              <div class= "Round3  d-flex align-items-around ml-5">
                  <div class="d-flex flex-sm-column  justify-content-around ml-5">
                      <div class= "match">
                          <div class = "team-top">
                              greg
                          </div>
                          
                          <div class = "team-botom">
                              george
                          </div>
                      </div>
                      
                      <div class= "match">
                          <div class = "team-top">
                              nick C
                          </div>
                          
                          <div class = "team-botom">
                              nick
                          </div>
                      </div>
                  </div>
              </div>
            
            <div class ="Round  d-flex align-items-center mr-5">   
              <div class= "match">
                    <div class = "team-top">
                        nick K
                    </div>
                    
                    <div class = "team-botom">
                        greg
                    </div>
                </div>  
            </div>
            <div class ="champion d-flex align-items-center pr-3">
                NICK K 
            </div>
          </div>
          </div>
      </div>
  
</template>

<script>

export default {
  data() {
    return {
      numberOfRounds: this.getNumberOfRounds,
      team: []
    };
  },
  computed: {
    getNumberOfRounds() {
      let output = 0;
      let numberOfPants = this.$store.state.Participants.length;
      if (numberOfPants == 2) {
        output = 1;
      } else if (numberOfPants == 4 || numberOfPants == 3) {
        output = 2;
      } else if (numberOfPants > 4 && numberOfPants < 9) {
        output = 3;
      } else {
        output = 4;
      }
      return output;
    },
    getRoundTitles() {
      let output = [];
      for (let i = 1; i <= this.getNumberOfRounds; i++) {
        output.push("Round " + i);
      }
      return output;
    },
    constuctMatches() {
      let output = [];
      let matchUp = {};
      let length = this.$store.state.Participants.length;
      length /= 2;
      for (let i = 0; i < length; i++) {
        output.push(matchUp);
      }
      

      return output;
    },

    hasOddPants() {
      return this.$store.state.Participants.length % 2 == 1 ? true : false;
    },
    
    // nextRoundMatches(){
    //   // let holderArray = this.constuctMatches();
    //   // if(holderArray.length === 8){
    //   //   let roundTwoMatches = holderArray.length /2;

    //   // }
      
    // }
  },
  methods: {
    isLastOddElement(index) {
      if (this.hasOddPants && index === this.constuctMatches.length - 1) {
        return false;
      }
      return true;
    },
    shuffle(array) {
      array.sort(() => Math.random() - 0.5);
    },
    shuffleStore() {
      this.shuffle(this.team);
      this.shuffle(this.team);
    },
    addTeams(){
      
    }
  },
};
</script>

<style>




/*.match{
    display:block;
} 
.headers>  {
    display:inline-flex;
    justify-content: space-between; 
   
    
}
.bracket-16> .Round{
     display:flex; 
     padding-left: 25%  
    max-width: 70px


}
 .top-rop{
     display: block 
}
.match{
 border: 2px solid black;
}*/
</style>