<template>
   <div id="user-tournament-page">
       <div class="userInfo"> 
            <h4 class="user-info">Current User: Joe Howell</h4>		
       </div>
       <form>
           <div class="nav-input-boxes" style="justify-content: left;">
                <label for="tournamentsToDisplay" style="padding-right: 5px;font-size: 18px;">Tournaments:</label>
                <select v-model="selected" name="" id="" >
                    <option selected value="Show All">Show All</option>
                    <option value="Completed">Completed</option>
                    <option value="Ongoing">Ongoing</option>
                </select>
            </div>


            <div class="user-tournament-margin">
            <div class="OngoingTournaments" v-show="this.selected =='Ongoing'">
                <h5>Ongoing Tournaments</h5>
                <!-- <p v-for="tournament in tournaments"></p> -->
                <div class="tournament-item">
                    <p class="tournament-border">
                        placeholder tournament <span class="match-result">72</span>
                        <button class="tiny-button">Record a new match result</button>
                    </p>
                </div>
            </div>
            <div class="CompletedTournaments" v-show="this.selected =='Completed'">
                <h5>Completed Tournaments</h5>
                <div class="tournament-item">
                    <p class="tournament-border">
                        placeholder tournament <span class="match-result">match result</span>
                        <button class="tiny-button">Record a new match result</button>
                    </p>
                </div>
            </div>
            <div class="AllTournaments main" v-show="this.selected =='Show All'">
                <h5>All Tournaments</h5>
                <div class="tournament-item">
                    <p class="tournament-border">
                        placeholder tournament <span class="match-result">match result</span>
                        <button class="tiny-button">Record a new match result</button>
                    </p>
                </div>
            </div>
            </div>
       </form>
   </div>
</template>

<script>
require("@/css/style.css");

export default {
	data(){
    return{
        selected:"",
        options:["Show All","Completed","Ongoing",4]
        };
    }
}
</script>

<style>
/* .myBrackets{
    display: flex;
} */
.tiny-button {
    width: 100px;
    height: 50px;
    font-size: 14px;
    float: right;
    margin: -1.2%;
}

.tournament-item {
    display: inline;
}

.match-result {
    margin-left: 44em;
    font-weight: bold;
}

.tournament-border {
    border: 1px solid #CFCFCF;
    padding: 20px;
}

.user-info {
    color: #3a506b;
}

.allTournaments>div{
    display: inline-flex;    
    
}
.userInfo{
    margin: 5px 3px
}
</style>