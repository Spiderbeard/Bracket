<template>
  <div>
  
    <div>
      <div class="headers">
        <h3 v-for="Round in this.getRoundTitles" v-bind:key="Round" v-bind:class="{}">
          {{ Round }}
        </h3>
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
      <div class="matches round-2">
        <div>

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

      // if( length % 2 != 0 ){
      //     length--;
      // }
      length /= 2;
      for (let i = 0; i < length; i++) {
        output.push(matchUp);
      }
      // if(length % 2 !=0){
      //
      // }

      return output;
    },

    hasOddPants() {
      return this.$store.state.Participants.length % 2 == 1 ? true : false;
    },
    // ,
    // addHideMe(){
    //     let output = false;
    //     if(this.hasOddPants && )
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
/* .match:last-child .hide-this {
  display: none;
} */

.headers> h3 {
  display: inline-block;
  width:25%;
  
}
</style>
