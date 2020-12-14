<template>
   <div id="user-tournament-page">
       <div class="userInfo"> 
           <div>
                <h4 class="user-info">Current User: Joe Howell</h4>
                <div class="nav-input-boxes" style="justify-content: left;">
                    <label for="tournamentsToDisplay" style="padding-right: 5px;font-size: 18px;">Tournaments:</label>
                    <select v-model="selected" name="" id="" value="Show All">
                    <option v-for="option in options" v-bind:key="option">
                    {{ option }}
                    </option>
                    </select>
                </div>		
            </div>
       </div>
       <div class="user-tournament-margin">
        <div class="OngoingTournaments" v-if="option">
            <h5>Ongoing Tournaments</h5>
        </div>
        <div class="CompletedTournaments" v-else-if="oh-boy">
            <h5>Completed Tournaments</h5>
        </div>
        <div class="AllTournaments main" v-else>
            <h5>All Tournaments</h5>
        </div>
       </div>
   </div>
</template>

<script>
require("@/css/style.css");

export default {
	data(){
    return{
        selected:'',
        options:['Show All','Completed','Ongoing']
        }
    }
}
</script>

<style>
/* .myBrackets{
    display: flex;
} */

.user-info {
    color: #3a506b;
}

.allTournaments>div{
    display: inline-flex;    
    
}

.userInfo{
    margin: 5px 3px
}
.OngoingTournaments,
.CompletedTournaments{
    width: 50%;
    color: #3a506b;
}
</style>