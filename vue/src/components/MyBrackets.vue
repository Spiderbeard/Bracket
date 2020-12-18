<template>
   <div id="user-tournament-page">
       <div class="bracket-well">
       <div class="userInfo"> 
            <h4 class="user-info"><u>Current User:</u> {{this.$store.state.user.username}}</h4>		
       </div>
       <form>
           <div class="nav-input-boxes" style="justify-content: left; margin: -0.5% 2% 2%;">
                <label for="tournamentsToDisplay" style="padding-right: 5px;font-size: 18px;">Tournaments:</label>
                <select v-model="selected" name="" id="">
                    <option v-for="option in options" v-bind:key="option">
                        {{option}}
                    </option>
                    
                </select>
            </div>
            <div class="user-tournament-margin">
            <div class="OngoingTournaments" v-show="this.selected =='Ongoing'">
                <h5>Ongoing Tournaments</h5>
                <!-- <p v-for="tournament in tournaments"></p> -->
                <div class="tournament-item" v-for="tournament in myTournaments" v-bind:key="tournament">
                    <p class="tournament-border">
                        <span class="name">Tournament: {{tournament.name}}</span>
                        <span class="current-round">Round #: {{tournament.currentRound}}</span>
                        <span class="match-result">Participants remaining: <b>{{tournament.numberOfParticipants}}</b></span>
                        <button class="tiny-button">Record result</button>
                    </p>
                </div>
            </div>
            <div class="CompletedTournaments" v-show="this.selected =='Completed'">
                <h5>Completed Tournaments</h5>
                <div class="tournament-item">
                    <p class="tournament-border">
                        <span class="">Finished Tournament</span>
                        <span class="current-round">Round #</span>
                        <span class="match-result">Champion: <b>batman</b></span>
                        <button class="tiny-button">Record result</button>
                    </p>
                </div>
            </div>
            <div class="allTournaments" v-show="this.selected =='Show All'">
                <h5>All Tournaments</h5>
                <div class="tournament-item" v-for="tournament in myTournaments" v-bind:key="tournament">
                    <p class="tournament-border">
                        <span style="float:left; min-width:17rem; max-width:17rem;">Tournament: <b>{{tournament.name}}</b> </span>
                        <span class="current-round">Round #: <b>{{tournament.currentRound}}</b> </span>

                        <!-- TODO -->
                        <!-- v-if tournament is completed then show this -->
                        <span class="match-result" >Participants remaining: <b>{{tournament.numberOfParticipants}} </b></span>
                        <!-- v-else show this-->
                        <!-- <span class="match-result" >Champion: <b>batman or something idk</b></span> -->
                        
                        <button class="tiny-button">Record result</button>
                    </p>
                </div>
            </div>
            </div>
       </form>
       </div>
   </div>
</template>

<script>
require("@/css/style.css");
require("@/css/text-grid.css")
import tournamentService from "@/services/TournamentService"
export default {
    created(){
        this.GetMeMYTourneys();
    },
	data(){
    return{
        selected:"Show All",
        options:["Show All","Completed","Ongoing"],
        myTournaments:[],
        };
    },
    methods: {
    showText() {
      let text = document.getElementById("no-pants-text");
      text.style.display = "block";

    },
    GetMeMYTourneys(){
        tournamentService.GetTournaments(this.$store.state.user.userId)
        .then(response=>{
            if (response.status==200){
                this.myTournaments=response.data;
            }
        })
        .catch(error=>{
            console.log(error);
        })
    }
    }
}
</script>

<style>
/* .myBrackets{
    display: flex;
    flex-direction: row;
} */

.tiny-button {
    width: 100px;
    height: auto;
    font-size: 14px;
    float: right;
    margin-left: 20px;
    border: none;
    background-color: #fca311;
    border-radius: 5px;
    color: #FFFFFF;
}

.tournament-item {
    display: inline-block;
}

.match-result {
    margin-left: 5em;
}

.current-round {
    margin-left: 10em;
}

/* .match-name, .match-result, .current-round {
    padding-right: 30%;
    font-weight: normal;
} */

.tournament-border {
    border: 1.5px solid #CFCFCF;
    padding: 15px;
    background-color: #FFFFFF;
    width: 1060px;
}

/* .text-wrap {
    white-space: nowrap; 
    width: 10px; 
    overflow: hidden;
    text-overflow: ellipsis;
    background: -webkit-linear-gradient(gray, white);
    background-clip: text;
    -webkit-text-fill-color: transparent;
} */

.user-info {
    color: #3a506b;
}

.allTournaments>div{
    display: inline-flex;    
    
}
.userInfo{
    margin: 2% 2%;
}
.name{
    float:left;
    min-width:17rem;
    max-width:18rem;
}
</style>