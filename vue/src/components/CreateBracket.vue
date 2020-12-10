<template>
  <div>
  
    <div>
      <div class="headers d-flex flex-row justify-content-between pl-3 pr-3">
        <h3 v-for="Round in this.getRoundTitles" v-bind:key="Round" v-bind:class="{}" >
          {{ Round }}
        </h3>
        <h3>CHAMPION</h3>
      </div>
      <div class="matches round-1">
        <div
          class="match"
          v-for="(match, index) in this.constuctMatches"
          v-bind:key="match.index"
        >
          <div class="team-top">
            <input
              type="text" v-model="team[index]"
              :placeholder="[[$store.state.Participants[index].id]]"
            />
          </div>
          <div v-if="isLastOddElement(index)" class="team-bottom">
            <input
            
              type="text" v-model="team[$store.state.Participants.length - index - 1]"
              :placeholder="[
                [
                  $store.state.Participants[
                    $store.state.Participants.length - index - 1
                  ].id,
                ],
              ]"
            />
          </div>
          <br />
        </div>
        <button v-on:click="shuffleStore">Randomize</button>
        <button>Add Teams</button>
      </div>
      <div v-if="someRandomMethod() > 1" class="round-2">
        <div  class="matches"   v-for="(match,index) in this.round2Matches" v-bind:key="index">        
            <div class= "match border border-dark" >
                <div class = "team-top border-bottom border-dark">
                  <h3>NIck </h3>
                </div>                       
                <div class = "team-botom ">
                  <h3>Jess</h3>
                </div>
            </div>   
        </div>
      </div>      
      <div v-if="someRandomMethod() > 2" class="matches round-3">
        <h3>{{this.round3Matches.length}}</h3>
      </div>
      <div v-if="someRandomMethod() > 3 && this.$store.state.Participants.length !=8 " class="matches round-4">
        <h3>{{this.round4Matches.length}}</h3>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  created(){
    this.nextRoundMatches();
  },
  data() {
    return {
      numberOfRounds: this.getNumberOfRounds,
      team: [],
      round2Matches:[],
      round3Matches:[],
      round4Matches:[]
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
      this.shuffle(this.$store.state.Participants);
    },
    addTeams(){
      
    },
    someRandomMethod(){
      let output=0;
      let length = this.$store.state.Participants.length;
      if(length % 2 === 1){
        length--;
      }
      do{
          length/=2;
          output++;
      }while (length >=1)
      return output;
    },
    nextRoundMatches(){
    let fullLength= this.$store.state.Participants.length;
     if(fullLength>=13){
      this.round2Matches.push('','','','');
     }else if (fullLength<13 && fullLength>=9){
      this.round2Matches.push('','','');
     }else if(fullLength<9 && fullLength>=5){
      this.round2Matches.push('','');
     }else if(fullLength<5 && fullLength>=3){
      this.round2Matches.push('');
     }
      
    if( fullLength>= 5 && fullLength<=8){
      this.round3Matches.push('');
    }
      
    if(fullLength>=9){
      this.round4Matches.push('');
      this.round3Matches.push('','');
    }

      return length;
    },
    ifOddMinusOne(length){
      if(length % 2 ===1){
        length--;
      }
      return length;
    },
    IfOddPlusOne(length){
      if(length%2 ===1){
        length++;
      }
      return length;
    }
  },
};
</script>

<style>
/* .match:last-child .hide-this {
  display: none;
} */


</style>
