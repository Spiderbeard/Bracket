<template>
   <div class="myBrackets">
       <div class="userInfo"> 
           <div class="display-3">Current User: Joe Howell</div>
       </div>
       <div class="AllTournaments">
            <div class="OngoingTournaments">
                <h3 >OnGoing Tournaments</h3>
            </div>
            <div class="CompletedTournaments">
                <h3>Completed Tournaments</h3>
            </div>
       </div>
   </div>
</template>

<script>
export default {

}
</script>

<style>
.myBrackets{
    display: flexbox;
}
.allTournaments{
    display: flexbox;    
}
.userInfo{
    margin: 5px 3px
}
</style>