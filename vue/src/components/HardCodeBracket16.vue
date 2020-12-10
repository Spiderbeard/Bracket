<template>
  <div>
      <div class = "bracket-16">
          <div>
              <h1>Round 1</h1>
              <h1>Round 2</h1>
              <h1>Round 3</h1>
              <h1>Round 4</h1>
          </div>
            <div class = "Round-1">
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
            <div class = "Round-2">   
                <div class= "match">
                    <div class = "team-top">

                    </div>
                    <div class = "team-botom">

                    </div>
                </div>
                <div>
                     <div class = "team-top">

                    </div>
                    <div class = "team-botom">
                        
                    </div>
                </div>
                <div>
                     <div class = "team-top">

                    </div>
                    <div class = "team-botom">
                        
                    </div>
                </div>
                <div>
                     <div class = "team-top">

                    </div>
                    <div class = "team-botom">
                        
                    </div>
                </div>
            </div>
            <div class= "Round-3">
                <div class= "match">
                    <div class = "team-top">

                    </div>
                    <div class = "team-botom">

                    </div>
                </div>
                <div>
                     <div class = "team-top">

                    </div>
                    <div class = "team-botom">
                        
                    </div>
                </div>
            </div>
            <div class ="Round-4">   
              <div class= "match">
                    <div class = "team-top">

                    </div>
                    <div class = "team-botom">

                    </div>
                </div>  
            </div>
            <div class ="champion">
                
            </div>
          </div>
      </div>
  </div>
</template>

<script>
export default {

}
</script>

<style>

</style>