<template>
  <create-bracket />
  <!-- <hard-code-bracket-16 /> -->
</template>

<script>
import CreateBracket from "@/components/CreateBracket";
// import HardCodeBracket16 from '@/components/HardCodeBracket16';
import tournamentService from "@/services/TournamentService"

export default {
  created(){
    this.addTournament();
  },
  data(){
    return{
      tournament:{
        Name:this.$store.state.ActiveBracket.name,
        NumberOfParticipants:this.$store.state.Participants.length,
        CurrentRound:1,
        OrganizerId:this.$store.state.user.userId

      },
    }
  },
  components: { CreateBracket }, 
  methods:{
    addTournament(){
      tournamentService
      .AddTournament(this.tournament)
      .then(response=>{
        if(response.status == 200){
          console.log(response.data);
          this.$store.commit('SET_TOURNAMENT',response.data);
        }
      })
      .catch(error=>{
        console.log(error.response);
      })
    },

  }
  // I had to re clone the project and forgot to switch to my branch this is all the work to get to those picture.

};
</script>

<style>
</style>
